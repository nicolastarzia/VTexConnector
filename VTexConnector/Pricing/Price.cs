﻿using Newtonsoft.Json;
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

        public async Task<bool> CreateEditPriceAsync(int itemId, PriceModel price)
        {
            string productUrl = Util.FormatUrl(Consts.PRICE_CREATEEDITPRICES);
            productUrl = productUrl.Replace("{{itemId}}", itemId.ToString());

            var priceModel = JsonConvert.SerializeObject(price);
            var httpResponse = await PutToUri(productUrl, new StringContent(priceModel));

            return httpResponse.IsSuccessStatusCode;

        }

    }
}
