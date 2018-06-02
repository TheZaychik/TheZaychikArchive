"""PyNetwork URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/2.0/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.urls import path
from django.conf.urls import url, include
from django.contrib import admin
from main import views
from session import views as session_views
from django.conf.urls import handler404, handler403

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', views.index, name='index'),
    path("contact_us", views.contact_us, name='contact_us'),
    url('', include('authentication.urls')),
    url('', include('main.urls')),
    url('', include('news.urls')),
    url('', include('session.urls')),
    url('', include('message.urls')),
    url('', include('dialogues.urls')),
]

handler404 = 'views.error_404'
handler403 = 'views.error_403'