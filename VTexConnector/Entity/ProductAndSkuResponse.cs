using System;
using System.Collections.Generic;
using System.Text;

namespace VTexConnector.Entity
{
    public class ProductAndSkuResponse
    {
        public Dictionary<string, IEnumerable<int>> data { get; set; }
        public Range Range { get; set; }
    }

    public class Range
    {
        public int total { get; set; }
        public int from { get; set; }
        public int to { get; set; }
    }
}
