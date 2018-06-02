from django import forms
from main.models import ContactForm
from session.models import Session


class ContactFormF(forms.ModelForm):
    class Meta:
        model = ContactForm
        fields = ['username', 'email', 'message']


class CreateSession(forms.ModelForm):
    class Meta:
        model = Session
        fields = ['name', 'language']
