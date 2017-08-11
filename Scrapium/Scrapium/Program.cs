using System;
using HtmlAgilityPack;

namespace Scrapium
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = @"https://www.cronista.com/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");

            Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

            Console.ReadLine();
        }
    }
}