using System;

namespace LearnAndTestCLS.Order
{
    public class clsShippingService
    {
        public void Subscribe(clsOrder order)
        {
            order.OnOrderPlaced += HandleNewOrder;
        }
        public void Unsubscribe(clsOrder order)
        {
            order.OnOrderPlaced -= HandleNewOrder;
        }
        private void HandleNewOrder(object sender, clsOrderEventArgs e)
        {
            Console.WriteLine($"======= Shipping Service =======");
            Console.WriteLine($"Preparing shipment for Order ID: {e.OrderId}");
            Console.WriteLine($"Product: {e.ProductName}, Quantity: {e.Quantity}, Price: {e.Price}");
            Console.WriteLine($"Shipping process initiated for customer: {e.CustomerEmail}");
            Console.WriteLine($"============================");

            // Logic to handle shipping can be added here
        }
    }
}
