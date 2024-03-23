import socket

HOST = "127.0.0.1"
PORT = 38616

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    s.bind((HOST, PORT))
    print(f"Escuchando en el puerto {PORT} si")
    s.listen()
    conn, addr  = s.accept()
    with conn:
        print(f"Conectado a {addr}")
        while True:
            data = conn.recv(1024)
            if not data:
                break
            conn.sendall(data)