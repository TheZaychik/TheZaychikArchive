import random

with open('nums.txt', 'w') as out:
    for x in range(int(1e7)):
        print(random.randint(-2 * 1e6, 2 * 1e6), file=out)
