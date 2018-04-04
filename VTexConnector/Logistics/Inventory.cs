using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VTexConnector.Entity;

namespace VTexConnector.Logistics
{
    public class Inventory : BaseClass
    {
        public Inventory() : base()
        {
            throw new NotImplementedException("To be develop!");
        }

        public async Task<InventoryModel> GetPriceAsync(int id)
        {
            string productUrl = Util.FormatUrl(Consts.INVENTORY_GETBYSKU);
            productUrl = productUrl.Replace("{{skuId}}", id.ToString());
            return await GetObjectFromUri<InventoryModel>(productUrl);
        }


        public async Task<bool> UpdateInventory(int itemId, int warehouseId, InventoryUpdateModel price)
        {
            string productUrl = Util.FormatUrl(Consts.INVENTORY_UPDATEINVENTORYBYSKUWAREHOUSE);
            productUrl = productUrl.Replace("{{skuId}}", itemId.ToString());
            productUrl = productUrl.Replace("{{warehouseId}}", warehouseId.ToString());

            var priceModel = JsonConvert.SerializeObject(price);
            var httpResponse = await PutToUri(productUrl, new StringContent(priceModel));

            return httpResponse.IsSuccessStatusCode;

        }
    }
}
