
namespace Pedido.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; } = new Product();

        public OrderItem() { }

        public OrderItem(int quantity,double price, Product orderProduct) {
            Quantity = quantity;
            Price = price;
            product = orderProduct;
        }

        public double SubTotal() {
            return Price * Quantity;
        }
    }
}
