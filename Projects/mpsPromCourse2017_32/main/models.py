from django.db import models
from django.contrib.auth.models import User
from session.models import Session


class ContactForm(models.Model):
    username = models.CharField(verbose_name="Имя", max_length=100)
    email = models.EmailField(verbose_name="Email")
    message = models.TextField(verbose_name="Сообщение")

    def __str__(self):
        return "{0} - ({1})".format(self.username, self.email)


class SessionMessage(models.Model):
    from_user = models.ForeignKey(to=User, name='Author', verbose_name='Author of the message', on_delete=models.CASCADE)
    session_id = models.ForeignKey(to=Session, name='Session id', verbose_name='ID of the session, in which the message was sent', on_delete=models.CASCADE)
    sending_time = models.TimeField(name='Message time', verbose_name='The moment of time when the message was sent')
    text = models.CharField(name='Message text', verbose_name='Message text', max_length=255)

    def __str__(self):
        return '{} {}: {}'.format(self.sending_time, self.from_user, self.text)
