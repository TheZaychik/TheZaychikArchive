# from django.utils import unittest
import unittest, requests, execjs


class Tests(unittest.TestCase):
    def main_test(self):
        self.assertEqual(requests.get('127.0.0.1:8000'), 200)

    def all_pages(self):
        pages = ['authentication/templates/reg.html',
                 'authentication/templates/profile.html',
                 'authentication/templates/reset_password.html',
                 'authentication/templates/confirm.html',
                 'authentication/templates/change_password.html',
                 'main/templates/about_us.html',
                 'main/templates/index.html',
                 'main/templates/base.html',
                 'main/templates/contact_us.html',
                 'main/templates/create_session.html#']
        for page in pages:
            self.assertEqual(requests.get('127.0.0.1:8000/' + page), 200)

    def login_test(self):
        self.assertEqual(
            requests.post(url='127.0.0.1:8000/authentication/templates/login.html', username='FirstTestPatternUser1',
                          password='zaqwedxs'), 200)

    def interpreter(self):
        f = open('interpreter.js', 'r')
        ctx = execjs.compile(f.read())
        codes = ['100+100',
                 'a=100\nif a>99:\n\ta*2',
                 'a=0\nfor i in range(200):\n\ta+=1\na',
                 'a=0\nwhile a!=200:\n\ta+=1\na',
                 'a=0\ntry:\n\t200//a\nexcept:\n\ta=200\na']
        for code in codes:
            self.assertEqual(ctx.call("load", code), 200)


unittest.main()

