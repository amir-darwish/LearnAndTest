using LearnAndTestCLS.Logger;
using System;
using System.IO;

namespace LearnAndTestCLS
{
    public class Program
    {
        static public void LogToConsole(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        static public void LogToFile(string message)
        {
            // Logic to log the message to a file can be added here
            string filePath = "log.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Log: {message}");
            }
        }
        static public void LogToDatabase(string message)
        {
            // Logic to log the message to a database can be added here
            Console.WriteLine($"Log to Database: {message}");
        }

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


            /////Test Order and Notification Services


            //clsOrder order = new clsOrder();

            //clsEmailService emailService = new clsEmailService();
            //clsSMSService smsService = new clsSMSService();
            //clsShippingService shippingService = new clsShippingService();

            //emailService.Subscribe(order);
            //smsService.Subscribe(order);
            //shippingService.Subscribe(order);

            //order.CreateOrder(1, "Product 1", 2, 199, "customer@example.com");

            //shippingService.Unsubscribe(order);

            //order.CreateOrder(2, "Product 2", 1, 299, "customer@linkdin.com");

            ////Test Logger

            clsLogger screenLogger = new clsLogger(LogToConsole);
            clsLogger fileLogger = new clsLogger(LogToFile);
            clsLogger databaseLogger = new clsLogger(LogToDatabase);

            screenLogger.Log("This is a log message to the console.");
            fileLogger.Log("This is a log message to the file.");
            databaseLogger.Log("This is a log message to the database.");
        }
    }
}
