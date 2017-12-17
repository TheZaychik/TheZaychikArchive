import pygame
import easygui
import sys
from pacman import const


def record_recording(score):
    name = easygui.enterbox(msg="Your score = " + str(score) + "\nPlease, enter your name (less than 20 symbols")
    if name == None:
        return
    while len(name) > 20:
        name = easygui.enterbox(msg="Reenter your name (less than 20 symbols")
    if not name:
        name = "Unknown"
    file = open("leaderboard.txt", "a")
    string = name + " " * (20 - len(name)) + str(score) + "\n"
    file.write(string)
    file.close()


def show_records(screen,mp):
    file = open("leaderboard.txt", "r")
    arr = [(line.split()[0], line.split()[1]) for line in file]
    arr.sort(key=lambda x: -int(x[1]))
    add_space = 0
    leng=0
    arr_message = []
    message = ""
    font = pygame.font.Font(None, 40)
    if len(arr) > 10:
        leng = 10
    else:
        leng = len(arr)
    for i in range(leng):
        screen.fill((255, 150, 200))
        message = str(i + 1) + "." + arr[i][0] + " " * (20 - len(arr[i][0]) - len(str(i + 1))) + arr[i][1]
        arr_message.append(message)
        add_space = 0
        for j in range(len(arr_message)):
            SurfaceObj = font.render(arr_message[j], True, (0, 0, 0), (255, 150, 200))
            RectObj = SurfaceObj.get_rect()
            RectObj.center = (const.WIN_WIDTH / 2, const.WIN_HEIGHT / 4 + add_space)
            screen.blit(SurfaceObj, RectObj)
            add_space += 40
        pygame.display.flip()
        pygame.time.wait(10)
    # SurfaceObj = font.render("EXIT", True, (0, 0, 0), (255, 150, 200))
    # RectObj = SurfaceObj.get_rect()
    # RectObj.center = (const.WIN_WIDTH / 2, const.WIN_HEIGHT - 100)
    # screen.blit(SurfaceObj, RectObj)
    pygame.display.flip()

    pygame.time.wait(3700)


class Menu:
    def __init__(self, punkts=[(215, 300, u'Play', (11, 0, 77), (250, 250, 30), 0),
                               (215, 400, u'Exit', (11, 0, 77), (250, 250, 30), 2),
                               (215, 350, u'Leaderboard', (11, 0, 77), (250, 250, 30), 1)]):
        self.punkts = punkts

    def render(self, poverhnost, font, num_punkt):
        for i in self.punkts:
            if num_punkt == i[5]:
                poverhnost.blit(font.render(i[2], 1, i[4]), (i[0], i[1] - 30))
            else:
                poverhnost.blit(font.render(i[2], 1, i[3]), (i[0], i[1] - 30))

    def menu(self, screen):
        done = True
        font_menu = pygame.font.Font(None, 50)
        pygame.key.set_repeat(0, 0)
        pygame.mouse.set_visible(True)
        punkt = 0
        y = 0
        while done:
            screen.fill((255, 150, 200))
            mp = pygame.mouse.get_pos()
            for i in self.punkts:
                if mp[0] > i[0] and mp[0] < i[0] + 250 and mp[1] > i[1] and mp[1] < i[1] + 50:
                    punkt = i[5]
            self.render(screen, font_menu, punkt)
            for e in pygame.event.get():
                if e.type == pygame.QUIT:
                    sys.exit()
                if e.type == pygame.KEYDOWN:
                    if e.key == pygame.K_ESCAPE:
                        sys.exit()
                    if e.key == pygame.K_UP:
                        if punkt > 0:
                            punkt -= 1
                    if e.key == pygame.K_DOWN:
                        if punkt < len(self.punkts) - 1:
                            punkt += 1
                if e.type == pygame.MOUSEBUTTONDOWN and e.button == 1:
                    if punkt == 0:
                        done = False
                    if punkt == 1:
                        show_records(screen,mp)
                    elif punkt == 2:
                        exit()
            pygame.display.flip()
