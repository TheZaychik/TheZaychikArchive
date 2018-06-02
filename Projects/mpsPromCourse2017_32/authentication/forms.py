from django import forms
from main.models import *
from django.contrib.auth.forms import UserCreationForm, UserChangeForm
from django.contrib.auth.models import User
from authentication.models import CustomUser


class FormReg(UserCreationForm):
    class Meta:
        model = User
        fields = ['email', 'username', 'password1', 'password2']


class CustomUserForm(forms.ModelForm):
    class Meta:
        model = CustomUser
        fields = ['photo']




class FormChangeProf(UserChangeForm):
    class Meta:
        model = User
        fields = ['email', 'username', 'password']

