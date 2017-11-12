import pygame,easygui
from random import randint
from button import Button

import sys,os

RED = (255,0,0)
BLUE = (0,0,255)
GREEN = (0,255,0)
BLACK = (0,0,0)
WHITE = (255,255,255)
ORANGE = (255,180,0)

size = width, height = 640, 480
bg_color = randint(0, 255), randint(0, 255), randint(0, 255)
isPaused = False
AddedBall = False
Balls = []  # список шаров
records = []  # словарь
nickname = ""
curr_time = 0

with open("recs.txt",'r') as f:
    records = f.readlines()

class Ball:
    def __init__(self):
        self.speed = [2, 2]
        self.ball = pygame.transform.scale(pygame.image.load("1_a_football.png"), (20, 20))
        self.geometry = self.ball.get_rect()

    def shift(self):
        self.geometry = self.geometry.move(self.speed)
        if self.geometry.left <= 0 or self.geometry.right >= width:
            self.speed[0] *= -1
        if self.geometry.top <= 0 or self.geometry.bottom >= height:
            self.speed[1] *= -1

    def set_position(self, pos):
        self.geometry.x = pos[0] - self.geometry.width // 2
        self.geometry.y = pos[1] - self.geometry.height // 2

    def move_key(self, key):
        key = chr(key)
        if key == 'w':
            self.speed[1] = -2
            self.speed[0] = 0
        elif key == 's':
            self.speed[1] = 2
            self.speed[0] = 0
        if key == 'a':
            self.speed[1] = 0
            self.speed[0] = -2
        elif key == 'd':
            self.speed[1] = 0
            self.speed[0] = 2

def add():
    global AddedBall
    AddedBall = True
    b1=Ball()
    b1.shift()
    Balls.append(b1)

def pause():
    global isPaused
    isPaused = not isPaused
def sortpos():
    pass

def rec_zap():
    global records, curr_time,nickname

    records.append(nickname + " - " + str(curr_time) + "\n")
    with open("recs.txt",'w') as f:
        f.writelines(records)

def vvod():
    global nickname
    msg = "Введите свой никнейм:"
    title = "Ввод"
    nickname = easygui.enterbox(msg,title)

def showrec():
    easygui.msgbox(records,"Рекорды")

def main():

    os.environ["SDL_VIDEO_CENTERED"] = '1'
    vvod()
    pygame.init()

    BUTTON_STYLE = {"hover_color": BLUE,
                    "clicked_color": GREEN,
                    "clicked_font_color": BLACK,
                    "hover_font_color": ORANGE,
                    "hover_sound": pygame.mixer.Sound("blipshort1.wav")}

    screen = pygame.display.set_mode(size)
    font = pygame.font.SysFont("timesnewroman",26)
    button1 = Button((0, 0, 200, 50), RED, pause,text="Pause", **BUTTON_STYLE)
    button1.rect.center = (100, 80)
    button2 = Button((0, 0, 200, 50), RED, add, text="Add", **BUTTON_STYLE)
    button3 = Button((0, 0, 200, 50), RED, showrec, text="Records", **BUTTON_STYLE)
    button3.rect.center = (100, 135)
    bl1 = Ball()
    Balls.append(bl1)
    w_close = False
    bl1.shift()
    global curr_time
    while not w_close:
        # --- обработка событий --
        for event in pygame.event.get():
            if AddedBall: curr_ball = Balls[1]
            else: curr_ball = Balls[0]

            if event.type == pygame.QUIT:
                w_close = True
                curr_time = round(pygame.time.get_ticks() / 1000, 1)
            if event.type == pygame.MOUSEBUTTONUP:
                pos = pygame.mouse.get_pos()
                curr_ball.set_position(pos)
            if event.type == pygame.KEYDOWN:
                curr_ball.move_key(event.key)

            button1.check_event(event)
            button2.check_event(event)
            button3.check_event(event)


        # --- игровая логика ---

        if not isPaused:
            for b in Balls:
                b.shift()

        # --- отрисовка объектов ---
        text = font.render("Timer: " + str(round(pygame.time.get_ticks() / 1000, 1)), True, (0, 0, 0))
        screen.fill(bg_color)
        screen.blit(text,(500,20))
        button1.update(screen)
        button3.update(screen)
        if not AddedBall:
            button2.update(screen)
        for b in Balls:
            screen.blit(b.ball, b.geometry)
        pygame.display.flip()
        pygame.time.wait(10)

    rec_zap()
    sys.exit()


main()