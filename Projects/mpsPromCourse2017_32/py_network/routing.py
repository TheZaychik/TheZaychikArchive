from channels.auth import AuthMiddlewareStack
from channels.routing import ProtocolTypeRouter, URLRouter
import session.routing as rout

application = ProtocolTypeRouter({
    # http->django views is added by default

    'websocket': AuthMiddlewareStack(
        URLRouter(
            rout.websocket_urlpatterns
        )
    ),
})
