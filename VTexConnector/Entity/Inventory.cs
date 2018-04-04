using System.Collections.Generic;

namespace VTexConnector.Entity
{
    public class Balance
    {
        public string warehouseId { get; set; }
        public string warehouseName { get; set; }
        public int totalQuantity { get; set; }
        public int reservedQuantity { get; set; }
        public bool hasUnlimitedQuantity { get; set; }
    }

    public class InventoryModel
    {
        public string skuId { get; set; }
        public List<Balance> balance { get; set; }
    }

    public class InventoryUpdateModel
    {
        public bool unlimitedQuantity { get; set; }
        public System.DateTime dateUtcOnBalanceSystem { get; set; }
        public int quantity { get; set; }
    
    }
}
