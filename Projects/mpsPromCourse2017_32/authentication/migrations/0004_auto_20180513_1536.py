# Generated by Django 2.0.5 on 2018-05-13 12:36

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('authentication', '0003_auto_20180513_0302'),
    ]

    operations = [
        migrations.AlterField(
            model_name='customuser',
            name='photo',
            field=models.ImageField(upload_to='images', verbose_name='фото юзера'),
        ),
    ]
