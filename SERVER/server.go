package main

import (
	"encoding/json"
	"log"
	"net/http"

	"github.com/gorilla/websocket"
)

// Client представляет подключенного клиента.
type Client struct {
	Nickname string          `json:"nickname"` // ник клиента
	conn     *websocket.Conn // соединение клиента
	server   *Server         // экземпляр сервера
}

// Message представляет сообщение, отправленное клиентом.
type Message struct {
	Sender      string `json:"sender"`      // ник отправителя
	Recipient   string `json:"recipient"`   // ник получателя
	Text        string `json:"text"`        // текст сообщения
	TypeMessage string `json:"typeMessage"` // текст сообщения
}

// Server представляет сервер WebSockets.
type Server struct {
	clients    []*Client          // список подключенных клиентов
	register   chan *Client       // канал для регистрации новых клиентов
	unregister chan *Client       // канал для удаления подключенных клиентов
	messages   chan *Message      // канал для передачи сообщений между клиентами
	upgrader   websocket.Upgrader // объект для обновления HTTP-соединения до WebSocket-соединения
}

// NewServer создает новый экземпляр сервера WebSockets.
func NewServer() *Server {
	return &Server{
		clients:    make([]*Client, 0),
		register:   make(chan *Client),
		unregister: make(chan *Client),
		messages:   make(chan *Message),
		upgrader: websocket.Upgrader{
			CheckOrigin: func(r *http.Request) bool { return true },
		},
	}
}

// Run запускает сервер WebSockets.
func (s *Server) Run(addr string) {
	http.HandleFunc("/ws", s.handleWebSocket)
	go s.run()
	log.Printf("Listening on %s\n", addr)
	if err := http.ListenAndServe(addr, nil); err != nil {
		log.Fatal(err)
	}
}

// run запускает цикл обработки событий сервера.
func (s *Server) run() {
	for {
		select {
		case client := <-s.register:
			s.clients = append(s.clients, client)
			log.Printf("Client %s connected\n", client.Nickname)

			jsonData, _ := json.Marshal(s.clients)

			for _, c := range s.clients {

				m := &Message{
					Sender:      "server",
					Recipient:   c.Nickname,
					TypeMessage: "clientsList",
					Text:        string(jsonData),
				}

				if err := c.conn.WriteJSON(m); err != nil {
					log.Printf("Error sending message to client %s: %v\n", c.Nickname, err)
				}
			}

		case client := <-s.unregister:
			for i, c := range s.clients {
				if c == client {
					s.clients = append(s.clients[:i], s.clients[i+1:]...)
					log.Printf("Client %s disconnected\n", client.Nickname)

					jsonData, _ := json.Marshal(s.clients)

					for _, c := range s.clients {

						m := &Message{
							Sender:      "server",
							Recipient:   c.Nickname,
							TypeMessage: "clientsList",
							Text:        string(jsonData),
						}

						if err := c.conn.WriteJSON(m); err != nil {
							log.Printf("Error sending message to client %s: %v\n", c.Nickname, err)
						}
					}

					break
				}
			}

		case msg := <-s.messages:
			for _, c := range s.clients {
				if c.Nickname == msg.Recipient {
					if err := c.conn.WriteJSON(msg); err != nil {
						log.Printf("Error sending message to client %s: %v\n", c.Nickname, err)
					}
				}
			}
		}
	}
}

func (s *Server) handleWebSocket(w http.ResponseWriter, r *http.Request) {
	// Обновляем HTTP-соединение до WebSocket-соединения.
	conn, err := s.upgrader.Upgrade(w, r, nil)
	if err != nil {
		log.Printf("Error upgrading HTTP connection to WebSocket: %v\n", err)
		return
	}

	// Читаем ник клиента из сообщения.
	var msg Message
	if err := conn.ReadJSON(&msg); err != nil {
		log.Printf("Error reading client Nickname: %v\n", err)
		conn.Close()
		return
	}

	// Создаем новый экземпляр клиента.
	client := &Client{
		Nickname: msg.Sender,
		conn:     conn,
		server:   s,
	}

	// Регистрируем клиента в сервере.
	s.register <- client

	// Выводим сообщение о подключении клиента.
	log.Printf("Client connected: %s\n", client.Nickname)

	// Обрабатываем входящие сообщения от клиента.
	go client.handleIncomingMessages()
}

func (c *Client) handleIncomingMessages() {
	for {
		var msg Message
		if err := c.conn.ReadJSON(&msg); err != nil {
			log.Printf("Error reading message from client %s: %v\n", c.Nickname, err)
			c.server.unregister <- c
			break
		}

		// Проверяем, что текст сообщения не пустой.
		if msg.Text == "" {
			log.Printf("Empty message received from client %s\n", c.Nickname)
			continue
		}

		msg.Sender = c.Nickname
		c.server.messages <- &msg
	}
}

func main() {
	server := NewServer()
	server.Run(":8080")
}
