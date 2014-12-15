using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahoo;
using System.Linq;

namespace Test.Yahoo
{
    [TestClass]
    public class YahooFeederTest
    {
        [TestMethod]
        public void GetCsvTest()
        {
            var feeder = new YahooFeeder(new[] { TickerOptions.Last_Trade_Price_Only });

            var result = feeder.GetCsv(new[] { "ACN" }).ToArray(); ;
        }
    }
}
