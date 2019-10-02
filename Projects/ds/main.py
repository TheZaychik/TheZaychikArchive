from aiohttp import web
import datetime
import smtplib
import aiohttp_jinja2
import jinja2


# v.1.1.4

async def index(request):
    return aiohttp_jinja2.render_template('index.html', request, {})


async def send_message(request):
    data = await request.post()
    e_host = "smtp.yandex.ru"
    e_subject = "Заявка на обртаную свзяь от " + str(datetime.datetime.now())[:19]
    e_IP = str(request.headers['X-Forward-For'])
    e_to = "dominus-school@yandex.ru"  # email администратора
    e_from = "no-reply.dominus-school@yandex.ru"
    e_text = ('IP: ' + e_IP  + '\n' + 'Имя: ' + data['name'] + '\n' + 'Email: ' + data['email'] + '\n' + 'Телефон: ' + data['telephone']
              + '\n' + 'Cообщение: ' + data['message'])
    e_body = "\r\n".join((
        "From: %s" % e_from,
        "To: %s" % e_to,
        "Subject: %s" % e_subject,
        "",
        e_text
    )).encode('utf-8').strip()
    try:
        server = smtplib.SMTP_SSL(host=e_host, port=465)
        server.login('no-reply.dominus-school@yandex.ru', 'ShubBardUremFu6')
        server.sendmail(e_from, e_to, e_body)
    except Exception:
        return aiohttp_jinja2.render_template('index.html', request, {'fnd_email': 'True'})
    return aiohttp_jinja2.render_template('index.html', request, {'snd_email': 'True'})


app = web.Application()
aiohttp_jinja2.setup(app, loader=jinja2.FileSystemLoader('templates'))
app.add_routes([web.get('/', index)])
app.add_routes([web.post('/', send_message)])
app.router.add_static('/static', 'templates/static')
web.run_app(app, port=8376)
