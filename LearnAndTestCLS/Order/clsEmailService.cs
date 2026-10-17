using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAndTestCLS.Order
{
    public class clsEmailService
    {
        public void Subscribe(clsOrder order)
        {
            order.OnOrderPlaced += HandelNewOrder;
        }

        public void Unsubscribe(clsOrder order)
        {
            order.OnOrderPlaced -= HandelNewOrder;
        }

        private void HandelNewOrder(object sender, clsOrderEventArgs e)
        {
            Console.WriteLine($"======= Email Service =======");
            Console.WriteLine($"Sending email to {e.CustomerEmail} for Order ID: {e.OrderId}");
            Console.WriteLine($"Product: {e.ProductName}, Quantity: {e.Quantity}, Price: {e.Price}");
            Console.WriteLine($"Email sent successfully!");
            Console.WriteLine($"============================");

            // Here you can add logic to send an actual email using an SMTP client or any email service provider API.

        }
    }
}
