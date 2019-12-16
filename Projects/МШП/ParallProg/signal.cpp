#include <iostream>
#include <csignal>

void signal_handler(int signal){
    std::cout << "Kek" << signal << std::endl;
}

int main(){
    int a = 0;
    std::signal(SIGTERM, signal_handler);
    std::signal(SIGINT, signal_handler);
    std::cout << "Enter the number\n";
    std::cin >> a;
    std::cout << a + 1 << std::endl;
}