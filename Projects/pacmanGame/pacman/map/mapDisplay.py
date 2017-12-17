import pygame
from pacman.map.map_tiles import MapTile

from pacman import const


class MapDisplay(pygame.sprite.Sprite):
    @staticmethod
    def update(map, screen, Pacman = None, Pinki = None, Inki = None, Blinki = None, Klyde = None):
        background = pygame.Surface(const.WIN_SIZE)
        background.fill(const.BG_COLOR)
        screen.blit(background, (0, 0))
        x = 0
        y = 0
        wall = pygame.Surface(const.BLOCK_SIZE)
        wall.fill((0, 0, 255))
        seed = pygame.Surface(const.SEED_SIZE)
        seed.fill((255, 255, 255))
        bigseed = pygame.Surface(const.BIG_SEED_SIZE)
        bigseed.fill((255, 255, 255))
        for row in MapTile.show_map():
            x = 0
            for col in row:
                if col == '-':
                    screen.blit(wall, (x, y))
                if col == '.':
                    screen.blit(seed, (
                                x + (const.BLOCK_WIDTH - const.SEED_WIDTH) // 2,
                                y + (const.BLOCK_HEIGHT - const.SEED_HEIGHT) // 2))
                if col == ',':
                    screen.blit(bigseed,
                                (x + (const.BLOCK_WIDTH - const.BIG_SEED_WIDTH) // 2,
                                 y + (const.BLOCK_HEIGHT - const.BIG_SEED_HEIGHT) // 2))
                x += const.BLOCK_WIDTH
            y += const.BLOCK_HEIGHT
            if Pacman != None:
                Pacman.render(screen)
            if Pinki != None:
                Pinki.render(screen)
            if Inki != None:
                Inki.render(screen)
            if Blinki != None:
                Blinki.render(screen)
            if Klyde != None:
                Klyde.render(screen)
