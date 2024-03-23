import socket
HOST = "127.0.0.1" 
PORT = 38616

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    s.connect((HOST, PORT))
    s.sendall(b"Hola soy gaston")
    data = s.recv(1024)
   
print(f"Recibido {data!r}")    