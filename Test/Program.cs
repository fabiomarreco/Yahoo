using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yahoo;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            YahooFeeder y = new YahooFeeder();
            y.Options.Add(TickerOptions.Last_Trade_Price_Only);
            y.Options.Add(TickerOptions.Change_Percent_Realtime);

            // string url = y.GetUrl(new string[] { "PETR4.SA", "GGBR4.SA" });

            foreach (string s in y.GetCsv(new string[] { "^BVSP", "PETR4.SA", "GGBR4.SA" }))
            {
                Console.WriteLine(s);
                Console.WriteLine("--------------------------");

                foreach (KeyValuePair<TickerOptions, string> valor in y.ParseLine(s))
                    Console.WriteLine(valor.Key.ToString() + "=" + valor.Value);
                Console.WriteLine("\n\n");
            }

            Console.ReadKey();
        }
    }
}
