from pacman import const
from pacman.map.map_tiles import MapTile
def point_to_num(a):
    return const.WIN_BLOCK_WIDTH * a.y + a.x
def num_to_point(num):
    return Point(num % const.WIN_BLOCK_WIDTH, num // const.WIN_BLOCK_WIDTH)
def path_to_points(path):
    return [num_to_point(num) for num in path]
class Graph:
    def __init__(self):
        self.graph = {}
        self.dist = None
        self.p = None
    def add_vert(self, num):
        self.graph[num] = []
    def add_edge(self, a, b):
        if a not in self.graph:
            self.add_vert(a)
        if b not in self.graph:
            self.add_vert(b)
        self.graph[a] += [b]
    def bfs(self, start, finish = None):
        self.dist = {}
        self.p = {}
        color = {}
        for vert in self.graph:
            color[vert] = False
        queue = [start]
        queue2 = []
        dist_now = 0
        ok = True
        while len(queue) > 0 and ok:
            while len(queue) > 0 and ok:
                x = queue.pop()
                color[x] = True
                self.dist[x] = dist_now
                for to in self.graph[x]:
                    if not color[to]:
                        queue2.append(to)
                        self.p[to] = x
                if x == finish:
                    ok = False
            queue = queue2.copy()
            queue2.clear()
            dist_now += 1
    def get_path(self, start, finish):
        self.bfs(start)
        path = []
        x = finish
        while x != start:
            path.append(x)
            x = self.p[x]
        return path

class Point:
    def __init__(self, x, y):
        self.x = x
        self.y = y
    def __sub__(self, b):
        return Point(self.x - b.x, self.y - b.y)
    def __add__(self, b):
        return Point(self.x + b.x, self.y + b.y)
    def __str__(self):
        return '({};{})'.format(self.x, self.y)
    def __mul__(self, k):
        return Point(self.x * k, self.y * k)
    def __eq__(self, b):
        if b == None:
            return False
        return self.x == b.x and self.y == b.y
def graph_on_map(map):
    finder = Graph()
    for i in range(const.WIN_BLOCK_HEIGHT):
        for t in range(const.WIN_BLOCK_WIDTH):
            if map[i][t] == '-':
                continue
            if i - 1 >= 0:
                if map[i - 1][t] != '-':
                    finder.add_edge(point_to_num(Point(t, i - 1)), point_to_num(Point(t, i)))
            if i + 1 <= const.WIN_BLOCK_HEIGHT:
                if map[i + 1][t] != '-':
                    finder.add_edge(point_to_num(Point(t, i + 1)), point_to_num(Point(t, i)))
            if t - 1 >= 0:
                if map[i][t - 1] != '-':
                    finder.add_edge(point_to_num(Point(t - 1, i)), point_to_num(Point(t, i)))
            if t + 1 <= const.WIN_BLOCK_WIDTH:
                if map[i][t + 1] != '-':
                    finder.add_edge(point_to_num(Point(t + 1, i)), point_to_num(Point(t, i)))
    return finder

def Find_path(a, b, map):
    if map[a.y][a.x] == '-' or map[b.y][b.x] == '-':
        return None
    path_finder = graph_on_map(map)

    return path_to_points(path_finder.get_path(point_to_num(a), point_to_num(b)))

def dist(a, b):
    return ((a.x - b.x) ** 2 + (a.y - b.y) ** 2) ** 0.5

def test():
    print('\n'.join(map(str, Find_path(Point(18,18), Point(16, 18), MapTile.show_map()))))
if __name__ == '__main__':
    test()