using System;
using HtmlAgilityPack;
using YahooFinanceApi;
using System.Threading.Tasks;

namespace Scrapium
{
    class Program
    {
        static void Main(string[] args)
        {
            //var html = @"https://www.cronista.com/";

            //HtmlWeb web = new HtmlWeb();

            //var htmlDoc = web.Load(html);

            //var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");

            //Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);


            Req();

            
            Console.ReadLine();
        }

        static async Task<string> Req()
        {
            var quotes = await Yahoo.Symbol("AAPL", "GOOG").Tag(Tag.LastTradePriceOnly, Tag.Open, Tag.DaysHigh, Tag.DaysLow, Tag.PreviousClose).GetAsync();
            var aapl = quotes["AAPL"];
            //var price = aapl[Tag.LastTradePriceOnly];

            Console.WriteLine(aapl);
            return aapl.ToString();
        }
    }
}