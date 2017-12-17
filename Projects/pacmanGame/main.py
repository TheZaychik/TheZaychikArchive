"""This file contains logic for start game"""
from pacman import const
from pacman.menu_leaderboards.menu_leaderboards import Menu
from pacman.menu_leaderboards.menu_leaderboards import record_recording
from pacman.map.mapDisplay import MapDisplay
from pacman.map.map_tiles import MapTile
from pacman.ghosts.inky import Inky as InkyCl
from pacman.ghosts.clyde import Clyde as ClydeCl
from pacman.ghosts.pinky import Pinky as PinkyCl
from pacman.ghosts.blinky import Blinky as BlinkyCl
from pacman.menu_leaderboards.death_screen import DeathMenu
from music.sound import Sound
import pygame
import random
import time
from pacman import path_alg
from pacman.player.pacman_character import Pacman as PacmanCl


def game():
    pacman_anim = [pygame.transform.scale(pygame.image.load('pacman/player/resources/Pacman_img/{}.png'.format(i + 1)),const.BLOCK_SIZE) for i in range(3)]
    mega_pacman_anim = [pygame.transform.scale(pygame.image.load('pacman/player/resources/Pacman_img/mega{}.png'.format(i + 1)),const.BLOCK_SIZE) for i in range(3)]

    inky_anim = [pygame.transform.scale(pygame.image.load('pacman/player/resources/Inky_img/{}.png'.format(i + 1)),const.BLOCK_SIZE) for i in range(8)]
    pinky_anim = [pygame.transform.scale(pygame.image.load('pacman/player/resources/Pinky_img/{}.png'.format(i + 1)),const.BLOCK_SIZE) for i in range(8)]
    blinky_anim = [pygame.transform.scale(pygame.image.load('pacman/player/resources/Blinky_img/{}.png'.format(i + 1)),const.BLOCK_SIZE) for i in range(8)]
    clyde_anim = [pygame.transform.scale(pygame.image.load('pacman/player/resources/Clyde_img/{}.png'.format(i + 1)),const.BLOCK_SIZE) for i in range(8)]
    death_img = pygame.transform.scale(pygame.image.load('pacman/player/resources/ghost_death_image.png'), const.BLOCK_SIZE)
    Bigmode_timer = -1

    score = 0
    screen = pygame.display.set_mode(const.WIN_SIZE)
    pygame.font.init()
    score_text = pygame.font.Font(None, 60)
    start = Menu()
    finder = path_alg.graph_on_map(MapTile.show_map())
    start.menu(screen)
    ok = True
    Pacman = PacmanCl(9 * const.BLOCK_WIDTH, 13 * const.BLOCK_HEIGHT, pacman_anim, mega_pacman_anim)
    Inky = InkyCl(11 * const.BLOCK_WIDTH, 16 * const.BLOCK_HEIGHT, inky_anim, finder)
    Pinky = PinkyCl(16 * const.BLOCK_WIDTH, 16 * const.BLOCK_HEIGHT, pinky_anim, finder)
    Clyde = ClydeCl(11 * const.BLOCK_WIDTH, 18 * const.BLOCK_HEIGHT, clyde_anim, finder)
    Blinky = BlinkyCl(16 * const.BLOCK_WIDTH, 18 * const.BLOCK_HEIGHT, blinky_anim, finder)
    dict_pac_dir = {'w' : 1, 'd' : 2, 's' : 3, 'a' : 4}
    key_now = 'w'

    big = False

    InkyAlive = True
    PinkyAlive = True
    ClydeAlive = True
    BlinkyAlive = True
    PacmanAlive = True


    sound = Sound()
    rand=random.randint(1,4)
    namber_chanell = 0
    kill = "music/kill.ogg"
    eating= "music/eating.ogg"
    zerno = "music/zerno.ogg"
    if rand>=2:
        if rand==1:
            main_theme = "music/main_theme.ogg"
        else:
            main_theme = "music/background_music1.ogg"

    elif rand == 3:
            main_theme = "music/background_music3.ogg"
    else:
        main_theme = "music/background_music2.ogg"
    win = "music/win.ogg"
    if rand%2==0:
        death_sound = "music/death_sound.ogg"
    else:
        death_sound = "music/loss.ogg"
    a=0

    while ok:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                ok = False
            if event.type == pygame.KEYDOWN:
                key_now = event.unicode.lower()
        Pacman.move_key(key_now)
        Pacman.update(MapTile.show_map())
        plus_score = MapTile.update(Pacman.geometry.x, Pacman.geometry.y)
        score += plus_score

        if plus_score == 100:
            Pacman.bigmode(True)
            Bigmode_timer = time.time()
            big = True
            #пакман большой
        if time.time() - Bigmode_timer >= 10 and big:
            Pacman.bigmode(False)
            big = False

        if InkyAlive:
            Inky.update(Pacman.geometry.x, Pacman.geometry.y, Blinky.rect.x, Blinky.rect.y)
            if Pacman.geometry.colliderect(Inky.rect):
                if not Pacman.bigMode:
                    PacmanAlive = False
                else:
                    Inky.imgs = [death_img] * 8
                    InkyAlive = False
        else:
            Inky.update_death(11 * const.BLOCK_WIDTH, 16 * const.BLOCK_HEIGHT)
            if Inky.rect.x == 11 * const.BLOCK_WIDTH and Inky.rect.y == 16 * const.BLOCK_HEIGHT:
                Inky.imgs = inky_anim
                InkyAlive = True

        if PinkyAlive:
            Pinky.update(Pacman.geometry.x, Pacman.geometry.y, dict_pac_dir.get(key_now, '0'))
            if Pacman.geometry.colliderect(Pinky.rect):
                if not Pacman.bigMode:
                    PacmanAlive = False
                else:
                    Pinky.imgs = [death_img] * 8
                    PinkyAlive = False
        else:
            Pinky.update_death(16 * const.BLOCK_WIDTH, 16 * const.BLOCK_HEIGHT)
            if Pinky.rect.x == 16 * const.BLOCK_WIDTH and Pinky.rect.y == 16 * const.BLOCK_HEIGHT:
                Pinky.imgs = pinky_anim
                PinkyAlive = True

        if BlinkyAlive:
            Blinky.update(Pacman.geometry.x, Pacman.geometry.y)
            if Pacman.geometry.colliderect(Blinky.rect):
                if not Pacman.bigMode:
                    PacmanAlive = False
                else:
                    Blinky.imgs = [death_img] * 8
                    BlinkyAlive = False
        else:
            Blinky.update(16 * const.BLOCK_WIDTH, 18 * const.BLOCK_HEIGHT)
            if Blinky.rect.x == 16 * const.BLOCK_WIDTH and Blinky.rect.y == 18 * const.BLOCK_HEIGHT:
                Blinky.imgs = blinky_anim
                BlinkyAlive = True

        if ClydeAlive:
            Clyde.update(Pacman.geometry.x, Pacman.geometry.y)
            if Pacman.geometry.colliderect(Clyde.rect):
                if not Pacman.bigMode:
                    PacmanAlive = False
                else:
                    Clyde.imgs = [death_img] * 8
                    ClydeAlive = False
        else:
            Clyde.update(11 * const.BLOCK_WIDTH, 18 * const.BLOCK_HEIGHT)
            if Clyde.rect.x == 11 * const.BLOCK_WIDTH and Clyde.rect.y == 18 * const.BLOCK_HEIGHT:
                Clyde.imgs = clyde_anim
                ClydeAlive = True

        if PacmanAlive:
            MapDisplay.update(MapTile.show_map(), screen, Pacman, Inky, Blinky, Pinky, Clyde)
            screen.blit(score_text.render(str(score), 0, (255, 255, 255)), (10, 10))
            if score == 1620:
                if 1:
                    sound.stop(6)
                    sound.get_sound(win, 7, 0)
                    DeathMenu.menu(screen, score)
                    pygame.quit()
                    MapTile.reload()
                    record_recording(score)
                    game()
        else:
            sound.stop(6)
            sound.get_sound(death_sound, 7, 0)
            time.sleep(1)
            DeathMenu.menu(screen, score)
            pygame.quit()
            MapTile.reload()
            record_recording(score)
            game()

        #музыка (6 канал- фоновая музыка,(1-4)-зерна,5-пакман на охоте),7 - cvthnm
        if a==0:
            sound.get_sound(main_theme,6,-1)
            a=1
        if namber_chanell >= 4:
            namber_chanell = 0
        if plus_score == 100:
            sound.pause(6)
            sound.get_sound(eating, 5, 0)

        if plus_score == 5:
            namber_chanell+=1
            if big:
                sound.get_sound(kill, namber_chanell, 0,0.5)
            else:
                sound.get_sound(zerno,namber_chanell,0,0.5)



        if time.time() - Bigmode_timer >= 10 and big:
            sound.stop(5)
            sound.unpause(6)
        if 0 == big :
            if sound.check(5):
                sound.stop(5)
                sound.get_sound(main_theme, 6, -1)


        pygame.display.update()
        pygame.time.wait(3)
    record_recording(score)

game()