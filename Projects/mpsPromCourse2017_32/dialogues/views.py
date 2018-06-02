from django.shortcuts import render
import dialogues.forms as forms
import datetime
from django.core.cache import cache
from django.http import HttpRequest, HttpResponse
from dialogues.models import Dialogue, Message
from django.contrib.auth.models import User
from authentication.models import CustomUser


def create_dialogue(request):
    username = request.user.username
    user_id = request.user.id
    user = CustomUser.objects.get(id=user_id)
    user_dialogues = Dialogue.objects.filter(users__id=user_id)
    for dialogue in user_dialogues:
        arr = dialogue.name.split('?')
        for a in arr:
            if a != username:
                dialogue.name = a
    if request.POST:
        if 'create_dialogue' in request.POST:
            formdialogue = forms.DialogueCreation(request.POST)
            if formdialogue.is_valid():
                name = formdialogue.clean_name()
                anuser = User.objects.get(username=name)
                if anuser != None:
                    if not Dialogue.objects.filter(users__id=user_id).filter(users__id=anuser.id):
                        dialogue = Dialogue()
                        dialogue.creation_time = datetime.datetime.today()
                        dialogue.name = name + '?' + username
                        dialogue.save()
                        dialogue.users.add(user_id, anuser.id)
                        dialogue.name = name
                        list_of_dialogues = list(user_dialogues)
                        list_of_dialogues.append(dialogue)
                        return render(request, "dialogues.html", {"user_dialogues": list_of_dialogues})
        elif 'dialogue_id' or 'create_message' in request.POST:
            if 'dialogue_id' in request.POST:
                dict = request.POST
                dialogueid = dict.get("dialogue_id")
                dialogue_messages = Message.objects.filter(dialogueid_id=dialogueid)
                return render(request, "dialogues.html",
                              {"dialogue_id": dialogueid, "dialogue_messages": dialogue_messages,
                               "user_dialogues": user_dialogues})
            elif 'create_message' in request.POST:
                formmessage = forms.MessageCreation(request.POST)
                if formmessage.is_valid():
                    text = formmessage.clean_message()
                    message = Message()
                    dictionary = request.POST
                    dialogue_id = dictionary.get("create_message")
                    dialogue_messages = Message.objects.filter(dialogueid_id=dialogue_id)
                    message.dialogueid = Dialogue.objects.get(id=dialogue_id)
                    message.creatorid = CustomUser.objects.get(id=user_id)
                    message.text = text
                    message.creation_time = datetime.datetime.today()
                    message.save()
                    list_of_messages = list(dialogue_messages)
                    list_of_messages.append(message)
                    return render(request, "dialogues.html",{"dialogue_id": dialogue_id, "dialogue_messages": dialogue_messages, "user_dialogues": user_dialogues})
                else:
                    dict = request.POST
                    dialogueid = dict.get("create_message")
                    dialogue_messages = Message.objects.filter(dialogueid_id=dialogueid)
                    return render(request, "dialogues.html",
                                  {"dialogue_id": dialogueid, "dialogue_messages": dialogue_messages,
                                   "user_dialogues": user_dialogues})
    return render(request, "dialogues.html", {"dialogue_id": None, "user_dialogues": user_dialogues})



#