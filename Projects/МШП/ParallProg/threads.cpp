#include <thread>
#include <iostream>
#include <cmath>
#include <fstream>
#include <vector>
#include <map>

std::map<std::string, int> stats;

void count_words(std::string &filename) {
    std::cout << "Starting read " << filename << std::endl;
    std::ifstream f(filename);
    int counter = 0;
    std::string temp;
    while (f >> temp) {
        counter++;
    }
    f.close();
    stats[filename] = counter;
    std::cout << "Finished read " << filename << std::endl;
}

int main() {
    std::vector<std::string> files = {"/etc/passwd", "textfiles/keklol.txt"};
    std::vector<std::thread> threads;
    for (std::string &s : files) {
        threads.emplace_back(std::thread(count_words, std::ref(s)));
    }
    for (std::thread &t : threads) {
        t.join();
    }
    for (auto p : stats) {
        std::cout << p.first << " has " << p.second << " words" << std::endl;
    }
    return 0;
}