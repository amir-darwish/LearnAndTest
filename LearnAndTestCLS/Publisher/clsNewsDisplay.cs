using System;

namespace LearnAndTestCLS.Publisher
{
    public class clsNewsDisplay
    {
        public string Name { get; }
        public clsNewsDisplay(string name)
        {
            Name = name;
        }
        public void Subscribe(clsNewsPublisher publisher)
        {
            publisher.OnNewsPublished += HandleNewsPublished;
        }
        public void Unsubscribe(clsNewsPublisher publisher)
        {
            publisher.OnNewsPublished -= HandleNewsPublished;
        }
        private void HandleNewsPublished(object sender, clsNewsArticle article)
        {
            Console.WriteLine($"\n\n[{Name}] received news article: {article.Title}");
            Console.WriteLine($"New article published: {article.Title}");
            Console.WriteLine($"Content: {article.Content}");
        }
    }
}
