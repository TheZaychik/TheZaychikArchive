from django.urls import path
from message import views

urlpatterns = [
    path('chat/', views.chat, name='chat'),
]
