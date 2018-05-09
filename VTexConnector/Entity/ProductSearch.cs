using System;
using System.Collections.Generic;
using System.Text;

namespace VTexConnector.Entity
{
    public class ProductSearch
    {
        public string productId { get; set; }
        public string productReference { get; set; }
        public List<Item> items { get; set; }
    }

    public class Item
    {
        public string itemId { get; set; }
        public List<Reference> referenceId { get; set; }
    }
    public class Reference
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
