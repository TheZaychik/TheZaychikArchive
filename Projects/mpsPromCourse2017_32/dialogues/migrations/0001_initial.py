# Generated by Django 2.0.5 on 2018-05-06 20:05

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        ('authentication', '0001_initial'),
    ]

    operations = [
        migrations.CreateModel(
            name='Dialogue',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(default='Unknown', max_length=255)),
                ('creation_time', models.DateTimeField()),
                ('users', models.ManyToManyField(to='authentication.CustomUser')),
            ],
        ),
        migrations.CreateModel(
            name='Message',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('text', models.CharField(default='   ', max_length=255)),
                ('creation_time', models.DateTimeField()),
                ('creatorid', models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.CASCADE, to='authentication.CustomUser', verbose_name='Creator id')),
                ('dialogueid', models.ForeignKey(blank=True, null=True, on_delete=django.db.models.deletion.CASCADE, to='dialogues.Dialogue', verbose_name='Dialogue id')),
            ],
        ),
    ]
