package main

import (
    "fmt"	
    "log"
    "net/http"
    "sync"

    "github.com/gorilla/websocket"
)

type Message struct {
    Sender    string `json:"sender,omitempty"`
    Recipient string `json:"recipient,omitempty"`
    Text      string `json:"text,omitempty"`
}

type Client struct {
    conn     *websocket.Conn
    nickname string
}

type Room struct {
    clients map[string]*Client
    mutex   sync.Mutex
}

func (room *Room) addClient(client *Client) {
    room.mutex.Lock()
    defer room.mutex.Unlock()
    room.clients[client.nickname] = client
}

func (room *Room) removeClient(client *Client) {
    room.mutex.Lock()
    defer room.mutex.Unlock()
    delete(room.clients, client.nickname)
}

func (room *Room) broadcast(sender *Client, msg *Message) {
    room.mutex.Lock()
    defer room.mutex.Unlock()

    for nickname, client := range room.clients {
        if nickname == msg.Recipient || msg.Recipient == "" {
            err := client.conn.WriteJSON(msg)
            if err != nil {
                log.Println("Error writing to client:", err)
            } else if nickname != sender.nickname {
                log.Printf("Message sent from %s to %s: %s", sender.nickname, nickname, msg.Text)
            }
        }
    }
}

func handleWebSocket(room *Room, w http.ResponseWriter, r *http.Request) {
    conn, err := websocket.Upgrade(w, r, w.Header(), 1024, 1024)
    if err != nil {
        log.Println("Error upgrading connection to WebSockets:", err)
        return
    }

    // Читаем сообщение от клиента с его ником.
    var msg Message
    err = conn.ReadJSON(&msg)
    if err != nil {
        log.Println("Error reading message from client:", err)
        return
    }
    if msg.Text == "" {
        log.Println("Error: empty nickname")
        conn.Close()
        return
    }
    client := &Client{conn, msg.Text}
    room.addClient(client)
    log.Printf("Client %s connected", client.nickname)

    // Читаем сообщения от клиента в отдельном горутине.
    go func() {
        defer func() {
            room.removeClient(client)
            log.Printf("Client %s disconnected", client.nickname)
            conn.Close()
        }()

        for {
            var msg Message
            err := conn.ReadJSON(&msg)
            if err != nil {
                log.Println("Error reading message from client:", err)
                return
            }

            // Отправляем сообщение конкретному клиенту или всем, если получатель не указан.
            room.broadcast(client, &msg)
        }
    }()
}

func main() {
    room := &Room{clients: make(map[string]*Client)}

    http.HandleFunc("/ws", func(w http.ResponseWriter, r *http.Request) {
        handleWebSocket(room, w, r)
    })

    fmt.Println("Server started on port 8080")
    log.Fatal(http.ListenAndServe(":8080", nil))
}

