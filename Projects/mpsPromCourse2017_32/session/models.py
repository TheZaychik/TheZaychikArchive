from django.db import models
from django.contrib.auth.models import User
from random import choice
from string import ascii_letters, digits

#from interpr import interpreter as intr
#from session import token


class Session(models.Model):
    MAX_NAME_LENGTH = 24
    TOKEN_LENGTH = 15

    text = models.TextField(verbose_name='Код')
    name = models.CharField(max_length=MAX_NAME_LENGTH, verbose_name='Название сессии', default="session")
    users = models.ManyToManyField(to=User, verbose_name='Подключенные люди') #Author defined through ForeignKey field in CustomUser model.
    token = models.CharField(max_length=TOKEN_LENGTH, verbose_name='Уникальный токен')
    datetime = models.DateTimeField(auto_now_add=True, verbose_name='Дата и время создания')
    lifetime = models.IntegerField(verbose_name='Время жизни в часах') # in hours
    language = models.CharField(verbose_name="Язык программирования сессии", max_length=20)

    def code(self, code):
        self.text = code

    def run(self, _input=''):
        return 0 #interpreter.run(_input)
