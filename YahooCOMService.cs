using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Yahoo
{
    [Guid("B28B51F9-F600-4A91-A3DE-4D14FD61E567")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface YahooCOMService
    {

        double last_price(string ticker);
    }

    [Guid("2532B6B6-97EF-41C3-8195-4DA3D09D5AFA")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class YahooCOMServiceClass : YahooCOMService
    {
        public double last_price(string ticker)
        {
            var yahoo = new YahooFeeder(new[] { TickerOptions.Last_Trade_Price_Only });
            var strresult = yahoo.GetCsv(new[] { ticker }).ToArray()[0];
            var result = double.Parse(strresult, CultureInfo.GetCultureInfo("en-US").NumberFormat);
            return result;
        }
    }
}
