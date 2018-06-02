from django.shortcuts import render
from news.models import News
from django.core.paginator import Paginator, EmptyPage, PageNotAnInteger
from django.http import JsonResponse, HttpRequest, HttpResponse
from django.views.decorators.csrf import csrf_exempt
import json
import logging
from main import forms as f
from main import models


def index(request):
    news_list = News.objects.all()
    paginator = Paginator(news_list, 5)

    page = request.GET.get('page')
    try:
        news = paginator.page(page)
    except PageNotAnInteger:
        # If page is not an integer, deliver first page.
        news = paginator.page(1)
    except EmptyPage:
        # If page is out of range (e.g. 9999), deliver last page of results.
        news = paginator.page(paginator.num_pages)
    return render(request, template_name='index.html', context={'news': news})


def contact_us(request):
    if request.method == 'POST':
        form = f.ContactFormF(request.POST or None)
        if form.is_valid():
            form.save()
        return render(request, template_name='contact_us.html', context={"form": form})
    else:
        return render(request, template_name='contact_us.html')


def about_us(request):
    return render(request, template_name='about_us.html')


def profile(request):
    return render(request, template_name='profile.html')


def error_404(request):
    return render(request, template_name='404.html')


def error_403(request):
    return render(request, template_name='403.html')
