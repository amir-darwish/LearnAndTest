using LearnAndTestCLS.Order;

namespace LearnAndTestCLS
{
    public class Program
    {
        static void Main(string[] args)
        {


            //clsNewsPublisher publisher = new clsNewsPublisher();

            //clsNewsDisplay display1 = new clsNewsDisplay("Display 1");
            //clsNewsDisplay display2 = new clsNewsDisplay("Display 2");

            //display1.Subscribe(publisher);
            //display2.Subscribe(publisher);

            //publisher.PublishNews("Breaking News", "This is the content of the breaking news article.");
            //publisher.PublishNews("Sports Update", "This is the content of the sports update article.");

            //display1.Unsubscribe(publisher);

            //publisher.PublishNews("Weather Alert", "This is the content of the weather alert article.");

            // Test Order and Notification Services
            clsOrder order = new clsOrder();

            clsEmailService emailService = new clsEmailService();
            clsSMSService smsService = new clsSMSService();
            clsShippingService shippingService = new clsShippingService();

            emailService.Subscribe(order);
            smsService.Subscribe(order);
            shippingService.Subscribe(order);

            order.CreateOrder(1, "Product 1", 2, 199, "customer@example.com");

            shippingService.Unsubscribe(order);

            order.CreateOrder(2, "Product 2", 1, 299, "customer@linkdin.com");
        }
    }
}
