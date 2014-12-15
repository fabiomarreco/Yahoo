using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yahoo
{
    public class TickerResult : IEnumerable<TickerOptionResult>
    {
        #region Enumerator
        public IEnumerator<TickerOptionResult> GetEnumerator()
        {
            return OptionResults.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return OptionResults.Values.GetEnumerator();
        }
        #endregion

        
        public TickerResult()
        {
            OptionResults = new Dictionary<TickerOptions,TickerOptionResult>();
        }

        public IDictionary<TickerOptions, TickerOptionResult> OptionResults { get; private set; }
        public string Ticker { get; set; }
    }


    public class TickerOptionResult
    {
        public TickerOptions Option { get; set; }
        public string Description { get; set; }
        public object Value { get; set; }
    }
}
