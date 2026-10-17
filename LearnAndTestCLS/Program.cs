using LearnAndTestCLS.Publisher;

namespace LearnAndTestCLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            clsNewsPublisher publisher = new clsNewsPublisher();

            clsNewsDisplay display1 = new clsNewsDisplay("Display 1");
            clsNewsDisplay display2 = new clsNewsDisplay("Display 2");

            display1.Subscribe(publisher);
            display2.Subscribe(publisher);

            publisher.PublishNews("Breaking News", "This is the content of the breaking news article.");
            publisher.PublishNews("Sports Update", "This is the content of the sports update article.");

            display1.Unsubscribe(publisher);

            publisher.PublishNews("Weather Alert", "This is the content of the weather alert article.");
        }
    }
}
