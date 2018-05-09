using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VTexConnector.Entity;

namespace VTexConnector.Pricing
{
    public class Price : BaseClass
    {
        public Price() : base()
        {
        }

        public async Task<bool> CreateEditPriceAsync(int itemId, SetPriceModel price)
        {
            string productUrl = Util.FormatUrl(Consts.PRICE_CREATEEDITPRICES);
            productUrl = productUrl.Replace("{{itemId}}", itemId.ToString());

            var priceModel = JsonConvert.SerializeObject(price);
            var httpResponse = await PutToUri(productUrl, new StringContent(priceModel));

            return httpResponse.IsSuccessStatusCode;

        }

    }
}
