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
            throw new NotImplementedException("To be develop!");
        }

        public async Task<PriceModel> GetPriceAsync(int id)
        {
            string productUrl = Util.FormatUrl(Consts.PRICE_GETPRICE);
            productUrl = productUrl.Replace("{{itemId}}", id.ToString());
            return await GetObjectFromUri<PriceModel>(productUrl);
        }

        public async Task<List<PriceModel>> GetFixedPricesAsync(int id)
        {
            string productUrl = Util.FormatUrl(Consts.PRICE_GETFIXEDPRICES);
            productUrl = productUrl.Replace("{{itemId}}", id.ToString());
            return await GetObjectFromUri<List<PriceModel>>(productUrl);
        }

        public async void CreateEditPriceAsync(int itemId, PriceModel price)
        {
            string productUrl = Util.FormatUrl(Consts.PRICE_GETFIXEDPRICES);
            productUrl = productUrl.Replace("{{itemId}}", itemId.ToString());

            var priceModel = JsonConvert.SerializeObject(price);

            var strRetorno = await this.HttpClient.PutAsync(productUrl, new StringContent(priceModel));
        }

    }
}
