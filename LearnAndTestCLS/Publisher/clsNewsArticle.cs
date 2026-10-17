using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAndTestCLS.Publisher
{
    public class clsNewsArticle
    {
        public string Title { get; }
        public string Content { get; }

        public clsNewsArticle(string title, string content)
        {
            Title = title;
            Content = content;
        }

    }
}
