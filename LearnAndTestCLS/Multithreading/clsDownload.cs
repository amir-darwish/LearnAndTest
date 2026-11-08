using System;
using System.Net;


namespace LearnAndTestCLS.Multithreading
{
    internal class clsDownload
    {
        public static void WebPage(string url)
        {
            string content = null;

            using (WebClient webClient = new WebClient())
            {
                content = webClient.DownloadString(url);
            }

            Console.WriteLine($"{url} : {content.Length} charachters downloaded");
        }
    }
}
