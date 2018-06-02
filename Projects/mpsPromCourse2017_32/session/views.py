from django.shortcuts import render, redirect
from django.http import JsonResponse, HttpResponse, HttpRequest, HttpResponseRedirect
from django.views.decorators.csrf import csrf_exempt
from session.models import Session
from main.forms import CreateSession
from random import choice
from string import ascii_letters, digits
from django.contrib.auth.decorators import login_required

import json
import logging


def join_session(request):
    return render(request, template_name='join_session.html')


def create_session(request: HttpRequest):
    if request.method == 'POST':
        form = CreateSession(request.POST)
        rand = ''.join([choice(ascii_letters + digits) for n in range(5)])
        NewSession = Session(name=form.data['name'], token=rand, lifetime=24, language=form.data['language'])
        if form.is_valid():
            NewSession.save()
            NewSession.users.add(*[request.user])
        return HttpResponseRedirect("/session/" + NewSession.token)
    return render(request, template_name='create_session.html')


def close(request):
    if not request.body:
      return render(request, template_name='base.html')
    AFTER_CLOSE_URL = '/index/'
    prequest = json.loads(request.body)
    session = Session.objects.raw('SELECT code FROM `{}` WHERE id LIKE '.format(self) + str(prequest['session_id']))
    session.delete()
    resp = HttpResponseRedirect(AFTER_CLOSE_URL, status_code=303)
    resp['Access-Control-Allow-Origin'] = 'null'
    return resp


@login_required
def session(request, token="QWER"):
    this_session = Session.objects.get(token=token)
    if request.user not in this_session.users.all():
        this_session.users.add(*[request.user])
    return render(request, template_name="session.html",
                  context={'token': token, 'session': this_session, 'users': this_session.users.all(), 'number': this_session.id})
