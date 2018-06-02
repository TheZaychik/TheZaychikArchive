from django.contrib import admin
from django.urls import path
from dialogues import views

app_name = 'dialogues'
urlpatterns = [
   path('dialogues/', views.create_dialogue, name='create_dialogue'),
]