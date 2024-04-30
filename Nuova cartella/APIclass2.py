from http.server import BaseHTTPRequestHandler, HTTPServer
import json

from Products2 import Product
from dbmanager import DbManager

class RequestHandler(BaseHTTPRequestHandler):
    def do_GET(self):
        if self.path.startswith('/products'):
            if self.path == '/products':
                self.send_response(200)
                self.send_header('Content-type', 'application/json')
                self.end_headers()
                products = Product.fetchAll()
                self.wfile.write(json.dumps(products).encode())
            else:
                product_id = int(self.path.split('/')[-1])
                product = Product.find_id(product_id)
                if product:
                    self.send_response(200)
                    self.send_header('Content-type', 'application/json')
                    self.end_headers()
                    self.wfile.write(json.dumps(product.__dict__).encode())
                else:
                    self.send_response(404)
                    self.end_headers()
                    self.wfile.write(b'Product not found.')
        else:
            self.send_response(404)
            self.end_headers()
            self.wfile.write(b'Page not found.')

    def do_POST(self):
        if self.path == '/products':
            content_length = int(self.headers['Content-Length'])
            post_data = json.loads(self.rfile.read(content_length).decode())
            new_product = Product.create_product(post_data)
            self.send_response(201)
            self.send_header('Content-type', 'application/json')
            self.end_headers()
            self.wfile.write(json.dumps(new_product.__dict__).encode())
        else:
            self.send_response(404)
            self.end_headers()
            self.wfile.write(b'Page not found.')

def run(server_class=HTTPServer, handler_class=RequestHandler, addr="localhost", port=8081):
    server_address = (addr, port)
    httpd = server_class(server_address, handler_class)
    print(f"Starting server on {addr}:{port}...")
    httpd.serve_forever()

if __name__ == "__main__":
    db_manager = DbManager("localhost", 3306, "root", "", "DBproducts")
    db_manager.connect()
    run()


