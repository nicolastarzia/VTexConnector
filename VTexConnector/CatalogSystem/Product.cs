using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VTexConnector.Entity;

namespace VTexConnector.CatalogSystem
{
    public class Product : BaseClass
    {
        public Product() : base()
        {

        }

        public async Task<ProductModel> GetByIdAsync(int id)
        {
            string productUrl = Util.FormatUrl(Consts.PRODUCT_GETBYID);
            productUrl = productUrl.Replace("{{productId}}", id.ToString());
            return await ExtractObject<ProductModel>(productUrl);
        }

        public async Task<ProductModel> GetByRefIdAsync(string refId)
        {
            string productUrl = Util.FormatUrl(Consts.PRODUCT_GETBYREFID);
            productUrl = productUrl.Replace("{{refId}}", refId);
            return await ExtractObject<ProductModel>(productUrl);
        }

    }


    
}
