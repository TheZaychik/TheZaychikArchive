import pygame
from pacman import const
import sys
from pacman.menu_leaderboards import menu_leaderboards


class DeathMenu:

    @staticmethod
    def render(poverhnost, font, num_punkt,punkts):
        for i in punkts:
            if num_punkt == i[5]:
                poverhnost.blit(font.render(i[2], 1, i[4]), (i[0], i[1] - 30))
            else:
                poverhnost.blit(font.render(i[2], 1, i[3]), (i[0], i[1] - 30))

    @staticmethod
    def menu(window, score):
        text = u'Game Over'
        if score == 1620:
            text = u'You Win!'
        punkts = [(215, 300, text, (225, 51, 51), (225, 51, 51), 1),
                       (215, 350, u'Restart', (11, 0, 77), (250, 250, 30), 3),
                       (215, 400, u'Exit', (11, 0, 77), (250, 250, 30), 4),
                       (215, 450, u'Score: ' + str(score), (225, 51, 51), (225, 51, 51), 2)]
        screen = pygame.Surface(const.WIN_SIZE)
        done = True
        font_menu = pygame.font.Font(None, 50)
        pygame.key.set_repeat(0, 0)
        pygame.mouse.set_visible(True)
        punkt = 0
        while done:
            screen.fill((102, 102, 255))

            mp = pygame.mouse.get_pos()
            for i in punkts:
                if mp[0] > i[0] and mp[0] < i[0] + 250 and mp[1] > i[1] and mp[1] < i[1] + 50:
                    punkt = i[5]
            DeathMenu.render(screen, font_menu, punkt,punkts)
            for e in pygame.event.get():
                if e.type == pygame.QUIT:
                    sys.exit()
                if e.type == pygame.KEYDOWN:
                    if e.key == pygame.K_ESCAPE:
                        sys.exit()
                if e.type == pygame.MOUSEBUTTONDOWN and e.button == 1:
                    if punkt == 3:
                        return True
                    elif punkt == 4:
                        menu_leaderboards.record_recording(score)
                        exit()
            window.blit(screen, (0, 0))
            pygame.display.flip()

