#include <cstdio>
#include <iostream>
#include <unistd.h>
#include <fcntl.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <arpa/inet.h>
#include <sys/file.h>
#include <sys/mman.h>
#include <semaphore.h>
#include <csignal>

#define SEM_NAME "/tcpserver_sem1"

bool closed = false;

void handle_kill(int signal){
    std::cout << "SIGINT\n";
    closed = true;
}

void handle_child(int sig){

}

class TcpServer {
private:
    int _socket;
    int port;
    sem_t *sem;

    void createSocket() {
        this->_socket = socket(AF_INET, SOCK_STREAM, 0);
        if (this->_socket == -1) {
            printError("Failed to create socket", true);
        }

    }

    int setup_sem() {
        sem = sem_open(SEM_NAME, O_CREAT, 0777, 5);
        if (sem == SEM_FAILED) {
            perror("sem_open");
            return 1;
        }
        return 0;
    }

    void reusePort() {
        int enable = 1;
        if (setsockopt(this->_socket, SOL_SOCKET, SO_REUSEADDR, &enable, sizeof(int)) < 0) {
            printError("Failed to reuse port", true);
        }
    }

    void Stop(){
        close(this->_socket);
        sem_close(sem);
    }

    void printError(std::string error, bool critical = false) {
        std::cout << error << std::endl;
        if (critical) {
            created = false;
        }
    }

    void refuseConnection(int &client_sock) {
        std::string response = "Failed to connect, semaphore is locked";
        const char *c_response = response.c_str();
        write(client_sock, c_response, strlen(c_response));
        if (close(client_sock) == -1) {
            printError("Failed to close socket");
        }
    }

    void handleConnections() {
        void *shmem = create_shared(sizeof(int));
        int *connected = (int *) shmem;
        *connected = 0;
        struct sockaddr_in client;
        socklen_t client_len;
        client_len = sizeof(client);
        while (!closed) {
            int client_sock = accept(this->_socket, (struct sockaddr *) &client, &client_len);
            if (client_sock < 0) {
                printError("Failed to accept new connection");
            }
            int pid = fork();
            if (pid == 0) {
                sem = sem_open(SEM_NAME, O_CREAT, 0777, 5);
                std::cout << "Try to wait" << std::endl;
               //sem_wait(sem);
                if (sem_trywait(sem) != 0) {
                    std::cout << "Semaphore is locked, refuse connection" << std::endl;
                    perror("sem_trywait");
                    refuseConnection(client_sock);
                    return;
                }
                *connected += 1;
                std::cout << "Clients: " << *connected << std::endl;
                handleConnection(client_sock);
                *connected -= 1;
                std::cout << "Clients: " << *connected << std::endl;
                sem_post(sem); // увеличивет значение семафора на 1
                sem_close(sem);
                return;
            }
            close(client_sock);

        }
    }

    void handleConnection(int &client_sock) {
        char c_request[50] = {0};
        read(client_sock, c_request, 50);
        std::string request(c_request);
        std::string &response = Action(request);
        const char *c_response = response.c_str();
        write(client_sock, c_response, strlen(c_response));
        if (close(client_sock) == -1) {
            printError("Failed to close socket");
        }
    }

    void *create_shared(size_t size) {
        int protection = PROT_READ | PROT_WRITE;
        int visibility = MAP_ANONYMOUS | MAP_SHARED;
        return mmap(NULL, size, protection, visibility, 0, 0);
    }


    void CountClients(int status) {
        int client = 0;
        FILE *f = fopen("textfiles/clients.txt", "r+");
        if (!f) {
            std::cout << "Failed to open file" << std::endl;
        }
        int fd = fileno(f);
        int r = flock(fd, LOCK_EX);
        if (r == -1) {
            std::cout << "Failed to lock file" << std::endl;
        }
        fscanf(f, "%d", &client);
        if (status == 0) // connected;
            client++;
        else if (status == 1) //disconnect
            client--;
        fseek(f, 0, SEEK_SET);
        fprintf(f, "%d", client);
        fclose(f);
        flock(fd, LOCK_UN);
        std::cout << "Connections: " << client << std::endl;
    }

    std::string &Action(std::string &a) {
        reverse(a.begin(), a.end());
        return a;
    }

public:
    bool created = true;

    int _bind() {
        struct sockaddr_in server_addr = {0};
        server_addr.sin_family = AF_INET;
        server_addr.sin_addr.s_addr = htonl(INADDR_ANY);
        server_addr.sin_port = htons(this->port);
        int err = bind(this->_socket, (struct sockaddr *) &server_addr, sizeof(server_addr));
        return err;
    }

    int GetPort() {
        return this->port;
    }

    int _listen(int backlog) {
        int err = listen(this->_socket, backlog);
        return err;
    }

    void Run() {
        this->handleConnections();
    }

    TcpServer(int port) {
        this->port = port;
        this->createSocket();
        this->setup_sem();
        this->reusePort();
    }
    ~TcpServer(){

    }
};

int main() {
    //std::signal(SIGTERM, handle_kill);
    std::signal(SIGINT, handle_kill);
    std::signal(SIGCHLD, SIG_IGN);
    TcpServer server = TcpServer(5001);
    if (server.created) {
        std::cout << "Server created" << std::endl;
    }
    int err;
    err = server._bind();
    if (err == -1) {
        std::cout << "Failed to bind on port" << server.GetPort() << std::endl;
        return 1;
    }
    err = server._listen(100);
    if (err == -1) {
        std::cout << "Failed to listen on port" << server.GetPort() << std::endl;
        return 1;
    }
    std::cout << "Listening on port " << server.GetPort() << std::endl;
    server.Run();

    return 0;
}