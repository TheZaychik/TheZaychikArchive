import pygame

from pacman.ghosts.ghost import Ghost
from pacman import const
from pacman.ghosts.ghost import Ghost
from pacman import path_alg
from pacman.path_alg import Point

class Clyde(Ghost):
    def __init__(self, x, y, img, finder):
        super().__init__(x, y, img, finder)
        self.ps = (Point(9, 14), Point(18, 14), Point(18, 20), Point(9, 20))
        self.to = 0
    def update(self, pacx, pacy):
        self.update_nxy()
        if self.rect.x % const.BLOCK_WIDTH == 0 and self.rect.y % const.BLOCK_HEIGHT == 0:
            x = pacx // const.BLOCK_WIDTH
            y = pacy // const.BLOCK_HEIGHT
            if path_alg.dist(Point(x, y), Point(self.nxy[0], self.nxy[1])) <= 8:
                self.to = 0
            else:
                if path_alg.dist(Point(self.nxy[0], self.nxy[1]), self.ps[self.to]) <= 1:
                    self.to = (self.to + 1) % len(self.ps)
                target = self.ps[self.to]
                #target = self.near_cell(target.x, target.y)
                x, y = target.x, target.y
            myx, myy = self.nxy
            if Point(myx, myy) == Point(x, y):
                self.dir = 0
            else:
                next = path_alg.path_to_points(self.graph.get_path(path_alg.point_to_num(Point(myx, myy)),
                                                                   path_alg.point_to_num(Point(x, y)))[-1:])[0]
                self.dir = self.path_to_dirs(Point(myx, myy), [next])[0]

        self.move_dir()