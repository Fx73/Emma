
import socket
import threading

#ma liste chainee de message
class tabmessage:
    def __init__(self, dest=None,msg=None, next=None): 
        self.dest = dest
        self.msg = msg
        self.suivant = next
    
    
messages = tabmessage(dest='Control',msg='integrite des messages')
#host = '192.168.1.102'
host = '127.0.0.1'
port = 11000

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind((host, port))
server.listen(10)

print ('Listening on {}:{}'.format(host, port))

#Le serveur
def handle_client_connection(client_socket):
    try:
        while True:
            data = client_socket.recv(1024).decode("utf-8")[:-2]
            print ('Message recu : {}'.format(data))
            stock_message(data)
            if not data:
                break
    except:
        print("Le client distant a ferme la connexion")
        return

while True:
    client_sock, address = server.accept()
    print ('Accepted connection from {}:{}'.format(address[0], address[1]))
    client_handler = threading.Thread(
        target=handle_client_connection,
        args=(client_sock,)  # without comma you'd get a... TypeError: handle_client_connection() argument after * must be a sequence, not _socketobject
    )
    client_handler.start()


#La gestion des messages
def stock_message(M):
    if M[0] != '+': #Check for good message
        return
    
    if M[1] == 'd': #Stockage d'un message
        for c in range(3,len(M)):
            if c == '+':
                break
        tempdest,tempmsg = M[3:c],M[c+3:len(M)]
        (d,m,s) = (messages.dest,messages.msg,message.suivant)
        while (s != None):
            if d == tempdest:
                m = tempmsg
                print("Overstock du msg pour"+d+" : "+m);
                return
            (d,m,s)=(s.dest,s.msg,s.suivant)
        
        s = tabmessage(dest=tempdest,msg=tempmsg)
        print("stock du msg pour"+s.dest+" : "+s.msg);
        return
    
    if M[1] == 'w': #Envoi d'un message si flag
        for c in range(2,len(M)):
            if c == '+':
                break
        flager = M[2:c]

        (d,m,s) = (messages.dest,messages.msg,message.suivant)
        old = messages
        while (s != None):
            if d == flager:
                client_socket.send(m)
                print(d+ " : envoi du msg :" +m);
                old.s=old.s.s
                return
            old = s
            (d,m,s)=(s.dest,s.msg,s.suivant)
        return
