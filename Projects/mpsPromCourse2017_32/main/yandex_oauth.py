import requests
APP_ID = 'e517ece0413c4f168c7a0707ef3bb315'
APP_PASSWORD = 'c300c7e07b0d40d48729fa43dff7a95c'
def get_verification_url(user_token=''):
    ans = requests.get(
        url='https://oauth.yandex.ru/authorize',
        params={
            'response_type':'code',
            'client_id':APP_ID,
            'state':user_token
        }
    )
    return ans.url #Пользователь после подтверждения отправляется обратно на сайт с кодом подтверждения, как аргументом.
def get_oauth_json(code):
    ans = requests.post(
        url='https://oauth.yandex.ru/token',
        data={
            'grant_type':'authorization_code',
            'code':code,
            'client_id':APP_ID,
            'client_secret':APP_PASSWORD
        }
    )
    return ans.json()
def get_account_info(oauth_token):
    info = requests.get(
        'https://login.yandex.ru/info',
        params={
            'format':'json',
            'oauth_token':oauth_token
        }
    )
    return info.json()