using System.Web;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Net;
using System;
using System.Reflection;
using System.Data.Linq;
using System.Linq;
using System.Numeric;
using System.Text.RegularExpressions;
using System.Collections;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Yahoo
{
    public class YahooFeeder
    {
        private Regex r_csv = new Regex(
         "(\r\n(?<=(^|,)\\\").*?(?=\\\"(?:,|$))\r\n|\r\n(?<=(^|,))[^\\\"].*?" +
         "(?=(?:,|$))\r\n)\r\n",
            RegexOptions.IgnoreCase
            | RegexOptions.Compiled
            | RegexOptions.Multiline
            | RegexOptions.IgnorePatternWhitespace
            );

        public IList<TickerOptions> Options { get; private set; }

        public YahooFeeder()
        {
            Options = new List<TickerOptions>();

        }

        public YahooFeeder(IEnumerable<TickerOptions> options) : this()
        {
            foreach (TickerOptions opt in options)
                Options.Add(opt);
        }


        public string GetUrl(IEnumerable<string> tickers)
        {
            //http://finance.yahoo.com/d/quotes.csv?s = {lista de tickers separados por +} &f = {Parâmetros}
            //http://ichart.yahoo.com/table.csv?s=PETR4.SA (para historico)

          //      url = 'http://ichart.yahoo.com/table.csv?s=%s&' % symbol + \
          //'d=%s&' % str(int(end_date[4:6]) - 1) + \
          //'e=%s&' % str(int(end_date[6:8])) + \
          //'f=%s&' % str(int(end_date[0:4])) + \
          //'g=d&' + \
          //'a=%s&' % str(int(start_date[4:6]) - 1) + \
          //'b=%s&' % str(int(start_date[6:8])) + \
          //'c=%s&' % str(int(start_date[0:4])) + \
          //'ignore=.csv'


            string result = @"http://finance.yahoo.com/d/quotes.csv?s=";
            result += tickers.Skip(1).Aggregate(tickers.First(), (total, next) => total + "+" + next);

            Type type = typeof(TickerOptions);
            result += @"&f=";


            foreach (TickerOptions opt in Options)
            {
                FieldInfo field = type.GetField(opt.ToString());
                object[] attributes = field.GetCustomAttributes(typeof(TickerCodeAttribute), false);
                if (attributes.Length <= 0)
                    continue;

                TickerCodeAttribute attr = (TickerCodeAttribute)attributes[0];

                result += attr.TickerCode;

            }

            return result;
        }


        public IEnumerable<string> GetCsv(IEnumerable<string> tickers)
        {
            WebClient wc = new WebClient();
            string url = GetUrl(tickers);
            using (StringReader sr = new StringReader(wc.DownloadString(url)))
            {
                while (true)
                {
                    string linha = sr.ReadLine();
                    if (linha == null)
                        break;

                    yield return linha;
                }
            }
        }


        public IDictionary<string, TickerResult> Feed(IEnumerable<string> tickers)
        {
            string[] array_tickers = tickers.ToArray<string>();
            int index = 0;
            IDictionary<string, TickerResult> resultado = new Dictionary<string, TickerResult>();
            foreach (string str_ticker_result in GetCsv(tickers))
            {
                TickerResult ticker_result = new TickerResult();
                ticker_result.Ticker = array_tickers[index++];
                foreach (KeyValuePair<TickerOptions, string> valor in ParseLine(str_ticker_result))
                {
                    TickerOptionResult option_result = new TickerOptionResult();

                    FieldInfo field = typeof(TickerOptions).GetField(valor.Key.ToString());

                    object[] attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    option_result.Description = (attributes.Length <= 0) ? valor.Key.ToString() : ((DescriptionAttribute)attributes[0]).Description;
                    option_result.Option = valor.Key;
                    option_result.Value = valor.Value;

                    ticker_result.OptionResults.Add(valor.Key,option_result);
                }
                resultado.Add (ticker_result.Ticker, ticker_result);
            }

            return resultado;
        }


        public IDictionary<TickerOptions, string> ParseLine(string s)
        {
            int i =0;
            IDictionary<TickerOptions, string> resultado = new Dictionary<TickerOptions, string>();
            foreach (Match m in r_csv.Matches (s))
                resultado.Add (Options[i++], m.Value);
            return resultado;
        }

    }


    #region Codigos feeder
    /*
     * Código	Dado obtido
a	Ask
a2	Average Daily Volume
a5	Ask Size
b	Bid
b2	Ask (Real-time)
b3	Bid (Real-time)
b4	Book Value
b6	Bid Size
c	Change & Percent Change
c1	Change
c3	Commission
c6	Change (Real-time)
c8	After Hours Change (Real-time)
d	Dividend/Share
d1	Last Trade Date
d2	Trade Date
e	Earnings/Share
e1	Error Indication (returned for symbol changed / invalid)
e7	EPS Estimate Current Year
e8	EPS Estimate Next Year
e9	EPS Estimate Next Quarter
f6	Float Shares
g	Day's Low
g1	Holdings Gain Percent
g3	Annualized Gain
g4	Holdings Gain
g5	Holdings Gain Percent (Real-time)
g6	Holdings Gain (Real-time)
h	Day's High
i	More Info
i5	Order Book (Real-time)
j	52-week Low
j1	Market Capitalization
j3	Market Cap (Real-time)
j4	EBITDA
j5	Change From 52-week Low
j6	Percent Change From 52-week Low
k	52-week High
k1	Last Trade (Real-time) With Time
k2	Change Percent (Real-time)
k3	Last Trade Size
k4	Change From 52-week High
k5	Percebt Change From 52-week High
l	Last Trade (With Time)
l1	Last Trade (Price Only)
l2	High Limit
l3	Low Limit
m	Day's Range
m2	Day's Range (Real-time)
m3	50-day Moving Average
m4	200-day Moving Average
m5	Change From 200-day Moving Average
m6	Percent Change From 200-day Moving Average
m7	Change From 50-day Moving Average
m8	Percent Change From 50-day Moving Average
n	Name
n4	Notes
o	Open
p	Previous Close
p1	Price Paid
p2	Change in Percent
p5	Price/Sales
p6	Price/Book
q	Ex-Dividend Date
r	P/E Ratio
r1	Dividend Pay Date
r2	P/E Ratio (Real-time)
r5	PEG Ratio
r6	Price/EPS Estimate Current Year
r7	Price/EPS Estimate Next Year
s	Symbol
s1	Shares Owned
s7	Short Ratio
t1	Last Trade Time
t6	Trade Links
t7	Ticker Trend
t8	1 yr Target Price
v	Volume
v1	Holdings Value
v7	Holdings Value (Real-time)
w	52-week Range
w1	Day's Value Change
w4	Day's Value Change (Real-time)
x	Stock Exchange
y	Dividend Yield
*/
    #endregion
}


