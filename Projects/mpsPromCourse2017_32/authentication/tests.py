from django.test import TestCase
from django.test.client import Client


class Test(TestCase):
    def registration_test(self):
        c = Client()
        response = c.post('/reg/', {'email': 'qwerty@uiop.ru', 'username': 'Admin', 'password1': 'rootAdmin98789', 'password2': 'rootAdmin98789'})
        self.assertEqual(response.status_code, 200)

    def login_test(self):
        c = Client()
        response = c.post('/login/', {'username': 'Admin', 'password': 'rootAdmin98789'})
        self.assertEqual(response.status_code, 200)
