from django.shortcuts import render, get_object_or_404
from django.utils import timezone
from .models import News


def news_list(request):
    news = News.objects.filter(date__lte=timezone.now()).order_by('date')
    return render(request, 'blog/post_list.html', {'news': news})


def news_detail(request, pk):
    news = get_object_or_404(News, pk=pk)
    return render(request, 'news_base.html', {'news': news})
