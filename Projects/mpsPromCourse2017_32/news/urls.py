from news import views
from django.conf.urls import url
from django.conf import settings
from django.conf.urls.static import static

app_name = 'news'
urlpatterns = [
    url(r'^news/(?P<pk>\d+)/$', views.news_detail, name='news'),
]


if settings.DEBUG:
    urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)