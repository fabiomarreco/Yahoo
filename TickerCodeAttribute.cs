using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yahoo
{
    [AttributeUsage (AttributeTargets.Field, AllowMultiple=false)] 
    class TickerCodeAttribute : Attribute
    {
        public string TickerCode { get; set; }

        public TickerCodeAttribute(string tickerCode)
        {
            this.TickerCode = tickerCode;
        }
    }
}
