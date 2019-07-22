using System;
using Pedido.Entities.Enum;
using Pedido.Entities;
using System.Globalization;

namespace Pedido {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            Console.WriteLine("Enter the order data:");
            Console.Write("Status: ");
            OrderStatus statusOrder = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Order order = new Order(statusOrder, client);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Enter #"+i+" item data:");
                Console.Write("Product Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product Price: ");
                double priceProduct = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());
            Product product = new Product(nameProduct, priceProduct);
                OrderItem item = new OrderItem(quantityProduct, product);
                order.addItem(item);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.Write(order);
        }
    }
}
