#include <cstdio>
#include <iostream>
#include <unistd.h>
#include <fcntl.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <arpa/inet.h>

using namespace std;

class SServer {
private:
    int enable, client_sock;
    int port, ssocket, sbind, lst_port;
    const int backlog = 100;
    char c_request[50] = {0};
    const char *c_response;
    struct sockaddr_in server_addr = {0};
    struct sockaddr_in client;
    socklen_t client_len;

public:
    SServer(int port) {
        this->port = port;
        create_socket();
        reuse_option();
        bind_on();
        setup_port();
        acpt_con();
        req_resp();
        close_sock();
    }

private:
    int create_socket() {
        ssocket = socket(AF_INET, SOCK_STREAM, 0);
        if (ssocket == -1) {
            cout << "Failed to create socket" << endl;
            return ssocket;
        }
        return 0;
    }

    void reuse_option() {
        server_addr.sin_family = AF_INET;
        server_addr.sin_addr.s_addr = htonl(INADDR_ANY);
        server_addr.sin_port = htons(port);
        enable = 1;
        if (setsockopt(ssocket, SOL_SOCKET, SO_REUSEADDR, &enable, sizeof(int)) < 0) {
            cout << "Failed to set reuse option" << endl;
        }
    }

    int bind_on() {
        sbind = bind(ssocket, (struct sockaddr *) &server_addr, sizeof(server_addr));
        if (sbind == -1) {
            cout << "Failed to bind on " << 8001 << endl;
            return sbind;
        }
        return 0;
    }

    int setup_port() {
        lst_port = listen(ssocket, backlog);
        if (lst_port == -1) {
            std::cout << "Failed  to listen on port " << port << std::endl;
            return lst_port;
        }
        cout << "Listen on port: " << port << endl;
        return 0;
    }

    void acpt_con() {
        // Обработка и взятие из очереди 1 подключения !
        client_len = sizeof(client);
        client_sock = accept(ssocket, (struct sockaddr *) &client, &client_len);
        if (client_sock < 0) {
            cout << "Accept failed" << endl;

        }
    }

    void req_resp() {
        cout << "Accepted new connection: " << endl;
        read(client_sock, &c_request, 50);
        int pid = fork();
        if (pid == 0) {
            string request(c_request);
            cout << "Request " << request << std::endl;
            reverse(request.begin(), request.end());
            c_response = request.c_str();
            write(client_sock, c_response, strlen(c_response));
            exit(0);
        }
    }

    void close_sock() {
        if (close(client_sock) == -1) {
            std::cout << "Failed to close client socket " << std::endl;
        }

        if (close(ssocket) == -1) {
            std::cout << "Failed to close main socket" << std::endl;
        }
    }
};


int main() {
    int prt;
    cout << "Please, setup port: " << endl;
    cin >> prt;
    SServer obj(prt);
    return 0;
}