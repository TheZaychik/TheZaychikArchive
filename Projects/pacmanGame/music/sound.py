from pygame import mixer
import pygame
import time
class Sound():
    def __init__(self):
        None

    def get_sound(self,file_name,channel_number,a,volum=1):# a- колличество повторений, а=0 -один раз проиграть, а=-1 - проигрывать беcконечно
         mixer.init(44010, -16, channel_number,2024)
         mixer.init()
         sound=mixer.Sound(file_name)
         sound.set_volume(volum)
         channel = mixer.Channel(channel_number)
         channel.play(sound,a)

    def stop(self,channe_numbere):
        channel= mixer.Channel(channe_numbere)
        channel.stop()

    def pause(self,channe_numbere):
        channel = mixer.Channel(channe_numbere)
        channel.pause()

    def check(self,channel_numbere):
        channel = mixer.Channel(channel_numbere)
        a= channel.get_busy()
        return a
    def unpause(self,channe_numbere):
        channel = mixer.Channel(channe_numbere)
        channel.unpause()
def test():#можно проверить работу всех методов
    a = Sound()
    while 1:
        a.get_sound('death_sound.ogg',1,1)
        a.get_sound('zerno.ogg',2,-1)
        time.sleep(2)
        a.pause(1)
        a.pause(3)
        time.sleep(2)
        a.unpause(3)
        a.stop(2)
        a.get_sound("main_theme.ogg",3,-1)
        time.sleep(2)
        b=a.check(3)
        print(b)
if __name__ == '__main__':
    test()
