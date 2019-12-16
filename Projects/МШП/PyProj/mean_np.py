import numpy as np

import time


start = time.time()
a = np.loadtxt('nums.txt')
print(a.mean())
print(time.time() - start)

