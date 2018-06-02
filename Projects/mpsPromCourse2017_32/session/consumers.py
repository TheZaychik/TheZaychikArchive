from channels.generic.websocket import AsyncJsonWebsocketConsumer
from redis import StrictRedis
from functools import reduce
from hashlib import md5


class SyncListenConsumer(AsyncJsonWebsocketConsumer):
    async def connect(self):
        await self.accept()

    async def disconnect(self, close_code):
        pass

    async def receive_json(self, content):
        self.token = content["token"]
        self.clid = content["origin"]
        await self.channel_layer.group_add(self.token, self.channel_name)

    async def sync_event(self, event):
        if event["content"]["origin"] != self.clid:
            await self.send_json(content=event["content"])

class SyncTellConsumer(AsyncJsonWebsocketConsumer):
    text = ""
    redis = StrictRedis()
    md5 = md5()

    async def connect(self):
        await self.accept()

    async def disconnect(self, close_code):
        pass

    async def receive_json(self, query):
        self.token = query["token"]
        self.text = self.redis.get(self.token).decode('UTF-8') if self.redis.get(self.token) else ""
        
        if query["length"] > 0: 
            for i in range(query["length"]):
                self.text = self.applyChange(self.text, query["pull"][i])
                self.redis.set(self.token, self.text)

            await self.channel_layer.group_send(self.token, {
                "type": "sync.event",
                "content": query,
                })

        response = {}

        if query["hashCheck"] == True:
            self.md5.update(self.text.encode('UTF-8'))
            if query["textHash"] != self.md5.hexdigest():
                response["inapt"] = True
                response["refText"] = self.text

        await self.send_json(content=response)

    async def sync_event(self):
        pass

    @staticmethod
    def applyChange (text, data):
        neu = text.split("\n")

        startRow = data["start"]["row"]
        endRow = data["end"]["row"]
        startPos = data["start"]["column"]
        endPos = data["end"]["column"]
        length = len(data["lines"])

        if data["action"] == "insert":
            left = neu[startRow][:startPos]
            rest = neu[startRow][startPos:]
            neu[startRow] = left + "\n".join(data["lines"]) + rest
        elif data["action"] == "remove":
            left = neu[startRow][:startPos]
            rest = neu[endRow][endPos:]
            neu[startRow:endRow + 1] = [left + rest]

        return "\n".join(neu)

