import asyncio, aiohttp, sys
from aiohttp import web
from datetime import datetime

# Краснознаменный ордена Ленина сервер обработки кода имени М.В.Капленко
# v.0.7.1.1 - Лог-система, подправлен импорт


async def check_code(code):
    banned = ['input', 'sys', 'exec', 'eval', 'os', 'subprocess']
    for word in banned:
        if word in code:
            return False, word
    return True, None


async def run(request):
    log = open('isLogs.txt', 'a')
    response = {}
    post_data = await request.post()
    log.write('------------------\n')  # logs
    log.write('<{0}>\n'.format(datetime.now()))
    log.write("Request from {0} is\n".format(request.remote))
    log.write(str(dict(post_data)) + "\n")
    print('------------------')
    print('<{0}>'.format(datetime.now()))
    print("Request from {0} is".format(request.remote))
    print(dict(post_data), request.remote)
    allow, word = await check_code(post_data['code'])
    if allow:
        code = post_data['code']
    else:  # if code have banned method
        response['output'] = ''
        response['traceback'] = 'Not allowed code:\n {0} is banned!'.format(word)
        log.write('WARNING! Server has stopped execution of not allowed code! See:\n {0}\n'.format(response))
        log.close()
        return web.json_response(response, headers={'Access-Control-Allow-Origin': '*'})

    process = await asyncio.create_subprocess_exec(sys.executable, '-c', code, stdin=asyncio.subprocess.PIPE,
                                                   stderr=asyncio.subprocess.PIPE, stdout=asyncio.subprocess.PIPE)
    output, traceback = await process.communicate(input=None)
    data_output = output.decode('ascii').rstrip()
    data_traceback = traceback.decode('ascii').rstrip()
    response['output'] = data_output
    response['traceback'] = data_traceback
    log.write("Response to {0} is\n {1}\n".format(request.remote, response))
    log.close()
    print(response)
    return web.json_response(response, headers={'Access-Control-Allow-Origin': '*'})

app = aiohttp.web.Application()
app.router.add_post('/', run)
web.run_app(app)
