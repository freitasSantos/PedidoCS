using System;
using Pedido.Entities.Enum;
using System.Collections.Generic;
using System.Globalization;

namespace Pedido.Entities {
    class Order {
        public DateTime Momment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client ClientData { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(OrderStatus status,Client clientData) {
            Status = status;
            ClientData = clientData;
        }

        public void addItem(OrderItem obj) {
            items.Add(obj);
        }

        public void removeItem(OrderItem obj) {
            items.Remove(obj);
        }

        public double total() {
            double Total = 0;
            foreach(OrderItem obj in items) {
                Total += obj.SubTotal();
            }
            return Total;
        }

        public override string ToString() {
            string msg = "";
            msg += "Order moment: " + Momment +
                   "\nOrder status: " + Status +
                   "\nClient: " + ClientData.Name + " (" + ClientData.BirthDate.ToString("dd/MM/yyyy") + ") - " + ClientData.Email +
                   "\nOrder Items:\n";
            foreach(OrderItem obj in items) {
                msg += obj.product.Name + ", $" + obj.product.Price.ToString("F2", CultureInfo.InvariantCulture) +
                       ", Quantity: " + obj.Quantity + ", Subtotal: $" + obj.SubTotal().ToString("F2", CultureInfo.InvariantCulture) + "\n";
            }
            msg += "Total Price: $" + total().ToString("F2", CultureInfo.InvariantCulture)+"\n";
            return msg;
        }
    }
}
