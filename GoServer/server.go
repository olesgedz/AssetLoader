package main

//https://blog.logrocket.com/creating-a-web-server-with-golang/
import (
	"fmt"
	"log"
	"net/http"
)

func main() {
	fileServer := http.FileServer(http.Dir("./")) // New code
	http.Handle("/", fileServer)                  // New code
	// http.HandleFunc("/hello", helloHandler)

	fmt.Printf("Starting server at port 8080\n")
	if err := http.ListenAndServe(":8080", nil); err != nil {
		log.Fatal(err)
	}
}
