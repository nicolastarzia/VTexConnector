using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTexConnector.Entity
{
    public class DateRange
    {
        public DateTime from { get; set; }
        public DateTime to { get; set; }
    }

    public class FixedPrice
    {
        public string tradePolicyId { get; set; }
        public double value { get; set; }
        public object listPrice { get; set; }
        public int minQuantity { get; set; }
        public DateRange dateRange { get; set; }
    }

    public class PriceModel
    {
        public string itemId { get; set; }
        public int listPrice { get; set; }
        public int costPrice { get; set; }
        public int markup { get; set; }
        public int basePrice { get; set; }
        public List<FixedPrice> fixedPrices { get; set; }
    }
}
