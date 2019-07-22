
namespace Pedido.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public Product product { get; set; } = new Product();

        public OrderItem() { }

        public OrderItem(int quantity, Product orderProduct) {
            Quantity = quantity;
            product = orderProduct;
        }

        public double SubTotal() {
            return product.Price * Quantity;
        }
    }
}
