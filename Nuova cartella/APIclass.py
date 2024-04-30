import json
from http.server import BaseHTTPRequestHandler, HTTPServer
from Products import Product

class RequestHandler(BaseHTTPRequestHandler):
    
    def _set_response(self, status_code=200, content_type='application/json'):
        self.send_response(status_code)
        self.send_header('Content-type', content_type)
        self.end_headers()

    def do_GET(self):
        try:
            if self.path == '/products':
                self._handle_get_products()
            elif self.path.startswith('/products/'):
                parts = self.path.split('/')
                product_id = int(parts[2])
                self._handle_get_product(product_id)
            else:
                self.send_error(404, 'Not Found')
        except Exception as e:
            self.send_error(500, str(e))

    def _handle_get_products(self):
        try:
            records = Product.fetchAll()
            products_list = []
            for record in records:
                product_dict = self._format_product(record)
                products_list.append(product_dict)

            self._set_response()
            response_data = {'data': products_list}
            self.wfile.write(json.dumps(response_data).encode('utf-8'))
        except Exception as e:
            self.send_error(500, str(e))

    def _handle_get_product(self, product_id):
        try:
            product = Product.find_id(product_id)
            if product is not None:
                product_dict = self._format_product(product)
                self._set_response()
                response_data = {'data': product_dict}
                self.wfile.write(json.dumps(response_data).encode('utf-8'))
            else:
                self.send_error(404, 'Product Not Found')
        except Exception as e:
            self.send_error(500, str(e))

    # Rimuovi i blocchi try-except per le altre operazioni poiché non sono state evidenziate dagli errori riportati precedentemente.

    def _format_product(self, product):
        if isinstance(product, dict):
            return {
                'type': 'products',
                'id': str(product.get('id', '')),
                'attributes': {
                    'marca': product.get('marca', ''),
                    'nome': product.get('nome', ''),
                    'prezzo': str(product.get('prezzo', ''))
                }
            }
        else:
            return None

def run(server_class=HTTPServer, handler_class=RequestHandler, port=8000):
    server_address = ('', port)
    httpd = server_class(server_address, handler_class)
    print(f'Starting server on port {port}...')
    httpd.serve_forever()

if __name__ == '__main__':
    run()

