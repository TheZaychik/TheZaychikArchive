import os, time

MAX_CHUNK_SIZE = 1000


def create_if_indeed(path):
    if not os.path.exists(path):
        os.makedirs(path)


def divide(input_file):
    create_if_indeed('data')
    inp_file = open(input_file, 'r')
    counter = 0
    out = open(f'data/nums{counter // MAX_CHUNK_SIZE}.txt', 'w')
    for line in inp_file:
        print(line.strip(), file=out)
        counter += 1
        if counter % MAX_CHUNK_SIZE == 0:
            out.close()
            out = open(f'data/nums{counter // MAX_CHUNK_SIZE}.txt', 'w')


def sort_file(input_file):
    f = open(input_file, 'r')
    data = f.read()
    data = data.split('\n')
    data = (int(x) for x in data if x != '')
    data = sorted(data)
    # print(data)
    f.close()
    f = open(input_file, 'w')
    for x in data:
        print(x, file=f)
    f.close()


def getnum(line):
    return int(line.strip())


def merge_file(input1, input2, output):
    ffile = open(input1, 'r')
    sfile = open(input2, 'r')
    outfile = open(output, 'w')
    fclose = False
    sclose = False
    n1 = getnum(next(ffile))
    n2 = getnum(next(sfile))
    while not (fclose and sclose):
        if not sclose and (n1 > n2 or fclose):
            print(n2, file=outfile)
            try:
                n2 = getnum(next(sfile))
            except StopIteration:
                sclose = True
        else:
            print(n1, file=outfile)
            try:
                n1 = getnum(next(ffile))
            except StopIteration:
                fclose = True

    ffile.close()
    sfile.close()
    outfile.close()


start = time.time()

divide('nums.txt')
for x in range(10000):
    sort_file(f'data/nums{x}.txt')
# merge_file('data/nums0.txt', 'data/nums1.txt', 'data/merge.txt')
NUM_OF_FILES = 10000
prefix = 'nums'
c = 0
while NUM_OF_FILES > 1:
    new_prefix = f'm_{c}'
    f1 = f'data/{prefix}{x}.txt'
    f2 = f'data/{prefix}{x + 1}.txt'
    merge_file(f1, f2, f'data/{new_prefix}{x // 2}.txt')
    prefix = new_prefix
    NUM_OF_FILES //= 2
    c += 1
print(time.time() - start)
