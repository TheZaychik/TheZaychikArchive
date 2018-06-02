from django.db import models
from django.contrib.auth.models import User
from session.models import Session
from django.db.models.signals import post_save
from django.dispatch import receiver


class CustomUser(models.Model):
    user = models.OneToOneField(verbose_name="реальный пользователь", to=User, on_delete=models.CASCADE,
                                related_name="customuser")
    AdminSessions = models.ForeignKey(verbose_name="Сессии, к котормым у него есть админки", to=Session,
                                      on_delete=models.CASCADE, null=True, blank=True)
    info = models.CharField(verbose_name="информация о юзере", max_length=255)
    photo = models.ImageField(verbose_name="фото юзера",upload_to='images')


class FriendShip(models.Model):
    creator = models.ForeignKey(verbose_name="первый друг", to=User, on_delete=models.CASCADE,
                                     related_name="first_friend")
    friend = models.ForeignKey(verbose_name="первый друг", to=User, on_delete=models.CASCADE,
                               related_name="second_friend")

