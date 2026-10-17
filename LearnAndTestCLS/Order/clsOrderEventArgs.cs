using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAndTestCLS.Order
{
    public class clsOrderEventArgs : EventArgs
    {
        public int OrderId { get; }
        public string ProductName { get; }
        public int Quantity { get; }
        public decimal Price { get; }
        public string CustomerEmail { get; }

        public clsOrderEventArgs(int orderId, string productName, int quantity, decimal price, string customerEmail)
        {
            OrderId = orderId;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
            CustomerEmail = customerEmail;
        }
    }
}
