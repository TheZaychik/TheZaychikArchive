from django.db import models


class News(models.Model):
    title = models.CharField(max_length=30)
    subtitle = models.CharField(max_length=150, null=True, default="")
    img = models.ImageField(upload_to='news', null=True, default="images/no.jpg")
    text = models.TextField()
    date = models.DateTimeField(auto_now=True)

    