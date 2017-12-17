import pygame
from pacman.character import Character
from pacman import const
from pacman.map.map_tiles import MapTile
from copy import deepcopy
from pacman import path_alg
import random
from pacman.path_alg import Point
class Ghost(Character):
    @classmethod
    def path_to_dirs(cls, start, path):
        dirs = []
        mpath = [start] + path
        for p in range(1, len(mpath)):
            if mpath[p].x == mpath[p - 1].x + 1:
                dirs.append(2)
            if mpath[p].x == mpath[p - 1].x - 1:
                dirs.append(4)
            if mpath[p].y == mpath[p - 1].y + 1:
                dirs.append(3)
            if mpath[p].y == mpath[p - 1].y - 1:
                dirs.append(1)
        return dirs

    def __init__(self, x, y, anim, finder):
        super().__init__(x, y)
        self.imgs = anim
        self.nxy = [x // const.BLOCK_WIDTH, y // const.BLOCK_HEIGHT]
        self.graph = finder
        self.dir = 0
        self.speed = 1
        self.disp = 0
    def move_dir(self):
        if self.dir == 0:
            pass
        elif self.dir == 1:
            self.rect.y -= self.speed
        elif self.dir == 2:
            self.rect.x += self.speed
        elif self.dir == 3:
            self.rect.y += self.speed
        elif self.dir == 4:
            self.rect.x -= self.speed
    def update_nxy(self):
        if self.rect.x % const.BLOCK_WIDTH == 0:
            self.nxy[0] = self.rect.x // const.BLOCK_WIDTH
        if self.rect.y % const.BLOCK_HEIGHT == 0:
            self.nxy[1] = self.rect.y // const.BLOCK_HEIGHT
    @classmethod
    def near_cell(self, x, y):
        minx, miny = 9, 13
        for i in range(100):
            rx = random.randint(0, const.WIN_BLOCK_WIDTH - 1)
            ry = random.randint(0, const.WIN_BLOCK_HEIGHT - 1)
            if MapTile.show_map()[ry][rx] != '-' and path_alg.dist(Point(minx, miny), Point(x, y)) > path_alg.dist(Point(rx, ry), Point(x, y)):
                minx, miny = rx, ry
        return Point(minx, miny)
    def render(self, screen):
        if self.disp == 0:
            screen.blit(self.imgs[3 + self.disp//250], (self.rect.x, self.rect.y))
            self.disp = (self.disp + 1) % 500
        else:
            screen.blit(self.imgs[self.dir * 2 - 2 + self.disp//250], (self.rect.x, self.rect.y))
            self.disp = (self.disp + 1) % 500