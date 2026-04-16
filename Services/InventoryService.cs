using InventoryManagement.Models;

            _products.Add(new Product
            {
                Id = _idCounter++,
                Name = name,
                Price = price,
                Quantity = quantity
            });

            Console.WriteLine("Product Added Successfully!");
        }

        public void ViewProducts()
        {
            if (!_products.Any())
            {
                Console.WriteLine("No products available.");
                return;
            }

            foreach (var p in _products)
            {
                Console.WriteLine($"ID: {p.Id} | Name: {p.Name} | Price: ₹{p.Price} | Qty: {p.Quantity}");
            }
        }

        public void SearchProduct()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine()!;

            var product = _products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (product == null)
                Console.WriteLine("Product not found.");
            else
                Console.WriteLine($"Found -> ID: {product.Id}, Price: ₹{product.Price}, Qty: {product.Quantity}");
        }

        public void DeleteProduct()
        {
            Console.Write("Enter Product ID: ");
            int id = int.Parse(Console.ReadLine()!);

            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            _products.Remove(product);
            Console.WriteLine("Product deleted successfully.");
        }
    }
}
