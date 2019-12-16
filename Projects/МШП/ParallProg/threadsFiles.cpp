#include <thread>
#include <iostream>
#include <cmath>
#include <fstream>
#include <vector>
#include <map>

std::map<std::string, int> wcount;
std::mutex m;
void count_words(std::string &filename) {
    std::cout << "Starting read " << filename << std::endl;
    std::ifstream f(filename);
    std::string temp;
    while (f >> temp){
        std::lock_guard<std::mutex> l(m);
        wcount[temp]++;
    }
    f.close();
    std::cout << "Finished read " << filename << std::endl;
}

int main() {
    std::vector<std::string> files = {"textfiles/keklol.txt", "textfiles/file1.txt"};
    std::vector<std::thread> threads;
    for (std::string &s : files) {
        threads.emplace_back(std::thread(count_words, std::ref(s)));
    }
    for (std::thread &t : threads) {
        t.join();
    }

    for(auto n : wcount){
        std::cout << n.first << " counts " << n.second << std::endl;
    }
    return 0;
}