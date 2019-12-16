#include <iostream>
#include <thread>
#include <future>

bool isPrime(int x){
    for(int i = 2; i<=x/2; i++){
        if(x% i == 0){
            return false;
        }
    }
    return true;
}

int main(){
    std::packaged_task<bool(int)> task(isPrime);
    //task(5);
    std::future<bool> future = task.get_future();
    std::thread t(std::move(task),121);
    t.detach();
    bool res = future.get();
    if(res){
        std::cout << "is prime" << std::endl;
    } else {
        std::cout << "not prime" << std::endl;
    }
    return 0;
};