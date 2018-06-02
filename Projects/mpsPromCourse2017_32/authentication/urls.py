from authentication import views
from django.urls import path
from django.conf import settings
from django.conf.urls.static import static

app_name = 'authentication'
urlpatterns = [
    path('register/', views.register, name='register'),
    path('register/confirm', views.confirm, name='confirm'),
    path('profile/<int:id>', views.userprofile, name='profile'),
    path('profile/change_password/', views.change_pass, name='change_password'),
    path('login/', views.log_in, name='login'),
    path('logout/', views.log_out, name='log_out'),
    path('yandex_auth/', views.yandex_auth, name='yandex authentication'),
    path('reset_password/', views.reset_password, name='reset_password'),
    path('change_avatar/<int:id>',views.change_avatar,name='change_avatar'),
    path('friends', views.friends, name='friends'),

    # НУЖНО БУДЕТ ПЕРЕРАБОТАТЬ, В ССЫЛКЕ ДОЛЖЕН БЫТЬ СПЕЦТОКЕН
]
if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL,
                          document_root=settings.MEDIA_ROOT)