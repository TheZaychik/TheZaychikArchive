# Generated by Django 2.0.2 on 2018-03-31 12:51

from django.conf import settings
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        ('session', '0001_initial'),
        migrations.swappable_dependency(settings.AUTH_USER_MODEL),
    ]

    operations = [
        migrations.CreateModel(
            name='ContactForm',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('username', models.CharField(max_length=100, verbose_name='Имя')),
                ('email', models.EmailField(max_length=254, verbose_name='Email')),
                ('message', models.TextField(verbose_name='Сообщение')),
            ],
        ),
        migrations.CreateModel(
            name='SessionMessage',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('Message time', models.TimeField(verbose_name='The moment of time when the message was sent')),
                ('Message text', models.CharField(max_length=255, verbose_name='Message text')),
                ('Author', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to=settings.AUTH_USER_MODEL, verbose_name='Author of the message')),
                ('Session id', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='session.Session', verbose_name='ID of the session, in which the message was sent')),
            ],
        ),
    ]