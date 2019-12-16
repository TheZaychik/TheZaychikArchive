import time


start = time.time()
f = open('nums.txt', 'r')
s = 0
c = 0

for line in f:
    s += int(line.strip())
    c += 1
f.close()
print(s / c)

print(time.time() - start)
