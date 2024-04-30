class Product:
    products = []

    def __init__(self, id, nome, prezzo, marca):
        self.id = id
        self.nome = nome
        self.prezzo = prezzo
        self.marca = marca

    @classmethod
    def fetchAll(cls):
        return cls.products

    @classmethod
    def find_id(cls, id):
        for product in cls.products:
            if product.id == id:
                return product
        return None

    @classmethod
    def create_product(cls, product_data):
        new_product = Product(**product_data)
        cls.products.append(new_product)
        return new_product

    def update_product(self, product_data):
        self.nome = product_data.get('nome', self.nome)
        self.prezzo = product_data.get('prezzo', self.prezzo)
        self.marca = product_data.get('marca', self.marca)

    def delete_product(self):
        Product.products = [p for p in Product.products if p.id != self.id]

