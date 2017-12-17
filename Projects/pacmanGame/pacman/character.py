import pygame
from pacman import const
class Character(pygame.sprite.Sprite):

    def __init__(self, x, y):
        self.dir = 1
        self.rect = pygame.Rect((x, y), const.BLOCK_SIZE)
    def render(self, screen):
        pass