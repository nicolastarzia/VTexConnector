using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTexConnector.Entity;

namespace VTexConnector.CatalogSystem
{
    public class Sku : BaseClass
    {
        public Sku() : base()
        {
        }


        public async Task<SkuResponse> GetBySkuIdAsync(int skuId)
        {
            string skuUrl = Util.FormatUrl(Consts.SKU_GETBYID);
            skuUrl = skuUrl.Replace("{{skuId}}", skuId.ToString());
            return await GetObjectFromUri<SkuResponse>(skuUrl);
        }
    }
}
