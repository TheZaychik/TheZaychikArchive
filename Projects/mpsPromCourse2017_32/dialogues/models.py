from django.db import models
from authentication.models import CustomUser
from django.utils import timezone
from django.contrib.auth.models import User


class Dialogue(models.Model):
    name = models.CharField(default='Unknown', max_length=255)
    creation_time = models.DateTimeField()
    users = models.ManyToManyField(CustomUser)


class Message(models.Model):
    dialogueid = models.ForeignKey(verbose_name="Dialogue id", to=Dialogue, on_delete=models.CASCADE, null=True, blank=True)
    creatorid = models.ForeignKey(verbose_name="Creator id", to=CustomUser, on_delete=models.CASCADE, null=True, blank=True)
    text = models.CharField(default='   ', max_length=255)
    creation_time = models.DateTimeField()

