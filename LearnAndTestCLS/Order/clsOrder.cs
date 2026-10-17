using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAndTestCLS.Order
{
    public class clsOrder
    {
        public event EventHandler<clsOrderEventArgs> OnOrderPlaced;

        public void CreateOrder(int orderId, string productName, int quantity, decimal price, string customerEmail)
        {
            Console.WriteLine($"------------ New Order Created -----------");
            // Logic to create the order (save to database) can be added here



            // Raise the OnOrderPlaced event thid is another way to raise the event
            if (OnOrderPlaced != null)
            {
                OnOrderPlaced(this, new clsOrderEventArgs(orderId, productName, quantity, price, customerEmail));
            }


        }
    }
}
