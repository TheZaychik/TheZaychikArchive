# Generated by Django 2.0.5 on 2018-05-07 00:56

import datetime
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        ('authentication', '0001_initial'),
    ]

    operations = [
        migrations.CreateModel(
            name='Dialog',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
            ],
        ),
        migrations.CreateModel(
            name='Message',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('text', models.TextField(verbose_name='Содержимое сообщения')),
                ('date', models.DateField(default=datetime.date.today, verbose_name='Дата отправления')),
                ('is_read', models.BooleanField(default=False, verbose_name='Было ли прочитано сообщение')),
                ('Author', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='authentication.CustomUser', verbose_name='Человек в чате')),
            ],
        ),
        migrations.AddField(
            model_name='dialog',
            name='messages',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='dialoges.Message', verbose_name='Человек в чате'),
        ),
        migrations.AddField(
            model_name='dialog',
            name='users',
            field=models.ForeignKey(null=True, on_delete=django.db.models.deletion.SET_NULL, to='authentication.CustomUser', verbose_name='Человек в чате'),
        ),
    ]
