from django.conf.urls import url

from session import consumers

websocket_urlpatterns = [
    url('sync/listen/', consumers.SyncListenConsumer),
    url('sync/tell/', consumers.SyncTellConsumer),
]
