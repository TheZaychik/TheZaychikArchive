from bs4 import BeautifulSoup
import requests
import csv
import time
import json
import datetime
from qwikidata.sparql import return_sparql_query_results
import multiprocessing

headers = {
    'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10.9; rv:45.0) Gecko/20100101 Firefox/45.0'
}


def get_urls_of_query(url):
    time.sleep(1)  # костыль, но без него спам начинается
    urls = []
    id_ph = url[url.find('Q'):]
    res = return_sparql_query_results('SELECT ?item  WHERE { ?item wdt:P39 wd:' + id_ph + '. }')
    for s in res['results']['bindings']:
        urls.append([s['item']['value'], id_ph])
    return urls


def parse_wikidata(url, id_ph, data):
    person = {'person': url}
    response = requests.get(url, headers=headers)
    print("Request get at parse_wikidata", url)
    js = json.loads(response.text)['entities']
    js = js[list(js.keys())[0]]['claims']
    position = None
    try:
        if len(js['P39']) > 1 and id_ph != 0:
            for p in js['P39']:
                if p['mainsnak']['datavalue']['value']['id'] == id_ph:
                    person['position'] = 'https://www.wikidata.org/wiki/' + p['mainsnak']['datavalue']['value']['id']
                    position = p
        else:
            position = js['P39'][0]['mainsnak']['datavalue']['value']['id']
            person['position'] = 'https://www.wikidata.org/wiki/' + position
    except Exception as e:
        person['position'] = 'N/A'
    try:
        person['start_precision'] = position['qualifiers']['P580'][0]['datavalue']['value'][
            'precision']
    except Exception as e:
        person['start_precision'] = 'N/A'
    try:
        person['start'] = position['qualifiers']['P580'][0]['datavalue']['value'][
            'time']
    except Exception as e:
        person['start'] = 'N/A'
    try:
        person['end_precision'] = position['qualifiers']['P582'][0]['datavalue']['value'][
            'precision']
    except Exception as e:
        person['end_precision'] = 'N/A'
    try:
        person['end'] = position['qualifiers']['P582'][0]['datavalue']['value'][
            'time']
    except Exception as e:
        person['end'] = 'N/A'
    if person is not None:
        data.append(person)
        print('data appended', person)
        print('Time', datetime.datetime.now().time())


def get_right_url(tag):
    for t in tag.children:
        print(t.name)
        if t.name == 'img':
            return False
    else:
        return True


def parse_table(url, url_table):
    response = requests.get(url, headers=headers)
    print("Request get", url)
    id = url.find('org/')
    url = url[:id + 4]
    soup = BeautifulSoup(response.text, 'html.parser')
    tables = soup.find_all('table', {'class': 'wikitable'})
    for t in tables:
        for row in t.find_all('tr'):
            for col in row.find_all('td'):
                if col.find('b', recursive=False) or col.find('a', recursive=False) and 'img' not in str(col):
                    response = requests.get(url + col.find('a')['href'], headers=headers)
                    time.sleep(1)
                    soup = BeautifulSoup(response.text, 'html.parser')
                    try:
                        link = soup.find('a', {'accesskey': 'g'})['href']
                    except:
                        break
                    url_table.append(['https://www.wikidata.org/entity/' + link[link.find('Q'):], 0])
                    print('Url_table appended', link)
                    print('Time', datetime.datetime.now().time())
                    break
            print()


def run():
    pages = []
    manager = multiprocessing.Manager()
    urltable = manager.list()
    data = manager.list()
    with open('pages.txt', "r") as f_obj:
        for line in f_obj:
            pages.append(str(line).replace('\n', ''))
    with open('pages2.txt', "r") as f_obj:
        jobs = []
        for line in f_obj:
            p = multiprocessing.Process(target=parse_table, args=(line.replace('\n', ''), urltable))
            jobs.append(p)
            p.start()
            if len(jobs) > 7:
                for j in jobs:
                    j.join()
                jobs = []
        for j in jobs:
            j.join()
    for p in pages:
        urltable += get_urls_of_query(p)
    print(urltable)
    print('Len', len(urltable))
    jobs = []
    for url in urltable:
        p = multiprocessing.Process(target=parse_wikidata, args=(url[0], url[1], data))
        jobs.append(p)
        p.start()
        if len(jobs) > 7:
            for j in jobs:
                j.join()
            jobs = []
    for j in jobs:
        j.join()
    print(data)
    print(data.__len__())
    input('Write to file?')
    with open('KIPFA_results.csv', "w", newline='') as f_obj:
        fieldnames = data[0].keys()
        writer = csv.DictWriter(f_obj, fieldnames=fieldnames)
        writer.writeheader()
        for row in data:
            writer.writerow(row)

def test():
    url_table = []
    url = 'https://en.wikipedia.org/wiki/List_of_French_monarchs'
    parse_table(url, url_table)

if __name__ == '__main__':
    run()
