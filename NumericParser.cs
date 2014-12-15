using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yahoo
{
    public class NumericParser
    {
        public NumericParser()
        {
        }

        public Regex RegularExpression { get; set; }
        public string DecimalSeparator { get; set; }
        public string ThousandSeparator { get; set; }
    }
}
