import pygame
from pacman import const
from pacman.ghosts.ghost import Ghost
from pacman import path_alg
from pacman.path_alg import Point
class Blinky(Ghost):
    def __init__(self, x, y, img, finder):
        super().__init__(x, y, img, finder)
    def update(self, pacx, pacy):
        self.update_nxy()
        if self.rect.x % const.BLOCK_WIDTH == 0 and self.rect.y % const.BLOCK_HEIGHT == 0:
            x = pacx // const.BLOCK_WIDTH
            y = pacy // const.BLOCK_HEIGHT
            myx, myy = self.nxy
            if Point(myx, myy) == Point(x, y):
                self.dir = 0
            else:
                next = path_alg.path_to_points(self.graph.get_path(path_alg.point_to_num(Point(myx, myy)),
                                     path_alg.point_to_num(Point(x, y)))[-1:])[0]
                self.dir = self.path_to_dirs(Point(myx, myy), [next])[0]
        self.move_dir()

