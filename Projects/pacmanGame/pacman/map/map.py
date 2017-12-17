import random


class Map:
    WIDTH = 10
    HEIGHT = 10

    def __init__(self):
        self.map = [[random.randint(0, 1) for y in range(self.WIDTH)] for x in range(self.HEIGHT)]

    def show(self):
        for i in range(self.HEIGHT):
            for j in range(self.WIDTH):
                print(self.map[i][j])

map = Map()
map.show()