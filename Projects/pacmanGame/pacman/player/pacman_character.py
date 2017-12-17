# ver. 0.5
import pygame
from pacman import const
from pacman.character import Character


class Pacman(Character):
    def __init__(self, x, y, Imgs, bigImgs):
        self.speed = [0, 0]
        self.constspeed = 2
        self.big = bigImgs
        self.small = Imgs
        self.image = self.small  # да-да, быдлокод, однако нам нужно на это место подставлять либо картинку
        self.ball = self.image[0]    # большого пакмана, либо стандартную из-за особенностей поворота изображения
        self.geometry = pygame.Rect((x, y), const.BLOCK_SIZE)
        self.bigMode = False  # режим поедания призраков
        self.rot_mode = [True, True, True, True]  # положение картинки пакмана
        self.want_move = [False, False, False, False]  # если пакман хочет повернуть
        self.now_move = [False, False, False, False]  # куда сейчас движется
        self.framespeed = 30
        self.frame = 0
        self.rotate = 0

    def next_cell(self, map):
        x = self.geometry.x // const.BLOCK_WIDTH
        y = self.geometry.y // const.BLOCK_HEIGHT
        if self.now_move[0]:
            return map[y-1][x]
        if self.now_move[1]:
            return map[y+1][x]
        if self.now_move[2]:
            return map[y][x-1]
        if self.now_move[3]:
            return map[y][x+1]

    def bigmode(self, status):
        self.bigMode = status
        if self.bigMode:
            self.image = self.big
            self.frame = 0
            self.framespeed = 15
        else:
            self.frame = 0
            self.framespeed = 30
            self.image = self.small

    def update(self, map):
        if (self.geometry.x % const.BLOCK_WIDTH == 0) and (self.geometry.y % const.BLOCK_HEIGHT == 0):
            x = self.geometry.x // const.BLOCK_WIDTH
            y = self.geometry.y // const.BLOCK_HEIGHT
            if self.want_move[0]:
                if map[y-1][x] != '-':
                    self.now_move = self.want_move
                    self.speed[1] = -self.constspeed
                    self.speed[0] = 0
                    self.rotate = 90
                    if self.rot_mode[0]:

                        self.rot_mode = [False, True, True, True]
                else:
                    if self.next_cell(map) == '-':
                        self.speed[1] = 0
                        self.speed[0] = 0

            elif self.want_move[1]:
                if map[y+1][x] != '-':
                    self.now_move = self.want_move
                    self.speed[1] = self.constspeed
                    self.speed[0] = 0
                    self.rotate  = 270
                    if self.rot_mode[1]:

                        self.rot_mode = [True, False, True, True]
                else:
                    if self.next_cell(map) == '-':
                        self.speed[1] = 0
                        self.speed[0] = 0

            elif self.want_move[2]:
                if map[y][x-1] != '-':
                    self.now_move = self.want_move
                    self.speed[1] = 0
                    self.speed[0] = -self.constspeed
                    self.rotate =  180
                    if self.rot_mode[2]:
                        self.rot_mode = [True, True, False, True]
                else:
                    if self.next_cell(map) == '-':
                        self.speed[1] = 0
                        self.speed[0] = 0

            elif self.want_move[3]:
                if map[y][x+1] != '-':
                    self.now_move = self.want_move
                    self.speed[1] = 0
                    self.speed[0] = self.constspeed
                    self.rotate = 0
                    if self.rot_mode[3]:
                          # зачем ротейт когда инит картинка и так влево повернута
                        self.rot_mode = [True, True, True, False]
                else:
                    if self.next_cell(map) == '-':
                        self.speed[1] = 0
                        self.speed[0] = 0
        self.ball = pygame.transform.rotate(self.image[self.frame // (self.framespeed // 3)], self.rotate)
        self.geometry.x += self.speed[0]
        self.geometry.y  += self.speed[1]
        self.frame = (self.frame + 1) % self.framespeed

    def move_key(self, key):
        if (key == "w") or (key == "ц"):
            self.want_move = [True, False, False, False]

        elif (key == "s") or (key == "ы"):
            self.want_move = [False, True, False, False]

        elif (key == "a") or (key == "ф"):
            self.want_move = [False, False, True, False]

        elif (key == "d") or (key == "в"):
            self.want_move = [False, False, False, True]
    def render(self, screen):
        screen.blit(self.ball, (self.geometry.x, self.geometry.y))



