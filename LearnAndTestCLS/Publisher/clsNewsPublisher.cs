using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAndTestCLS.Publisher
{
    public class clsNewsPublisher
    {
        public event EventHandler<clsNewsArticle> OnNewsPublished;
        
        public void PublishNews(string title, string content)
        {
            var article = new clsNewsArticle(title, content);
            OnNewsPublishedEvent(article);
        }

        public void OnNewsPublishedEvent(clsNewsArticle article)
        {
            OnNewsPublished?.Invoke(this, article);
        }

    }
}
