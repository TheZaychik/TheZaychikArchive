from django import forms
from dialogues.models import Dialogue, Message
from django.utils import timezone
import datetime
from django.core.exceptions import ValidationError


class DialogueCreation(forms.ModelForm):
    def clean_name(self):
        cleaned_name = self.cleaned_data['name']
        return cleaned_name

    class Meta:
        model = Dialogue
        fields = ['name', ]


class MessageCreation(forms.ModelForm):
    def clean_message(self):
        cleaned_message = self.cleaned_data['text']
        return cleaned_message

    class Meta:
        model = Message
        fields = ['text']
