import pygame

from pacman.ghosts.ghost import Ghost
from pacman import const
from pacman import path_alg
from pacman.path_alg import Point

class Inky(Ghost):
    def __init__(self, x, y, img, finder):
        super().__init__(x, y, img, finder)

    def update(self, pacx, pacy, blinkyx, blinkyy):
        self.update_nxy()
        if self.rect.x % const.BLOCK_WIDTH == 0 and self.rect.y % const.BLOCK_HEIGHT == 0:
            x, y = pacx // const.BLOCK_WIDTH, pacy // const.BLOCK_HEIGHT
            bx, by = blinkyx // const.BLOCK_WIDTH, blinkyy // const.BLOCK_HEIGHT
            pac, bl = Point(x, y), Point(bx, by)
            target = (pac - bl) * 2 + bl
            target = self.near_cell(target.x, target.y)
            if target != None:
                x, y = target.x, target.y
                myx, myy = self.nxy
                if Point(myx, myy) == Point(x, y):
                    self.dir = 0
                else:
                    next = path_alg.path_to_points(self.graph.get_path(path_alg.point_to_num(Point(myx, myy)),
                                                                       path_alg.point_to_num(Point(x, y)))[-1:])[0]
                    self.dir = self.path_to_dirs(Point(myx, myy), [next])[0]
            else:
                self.dir = 0
        self.move_dir()

    def update_death(self, pacx, pacy):
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