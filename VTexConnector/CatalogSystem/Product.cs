using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VTexConnector.Entity;

namespace VTexConnector.CatalogSystem
{
    /// <summary>
    /// Get Product info
    /// </summary>
    public class Product : BaseClass
    {
        public Product() : base()
        {

        }

        /// <summary>
        /// Get product By Internal ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Return request from VTex</returns>
        public async Task<ProductModel> GetByIdAsync(int id)
        {
            string productUrl = Util.FormatUrl(Consts.PRODUCT_GETBYID);
            productUrl = productUrl.Replace("{{productId}}", id.ToString());
            return await GetObjectFromUri<ProductModel>(productUrl);
        }

        /// <summary>
        /// Get product By reference id
        /// </summary>
        /// <param name="refId">Reference ID</param>
        /// <returns>Return request from VTex</returns>
        public async Task<ProductModel> GetByRefIdAsync(string refId)
        {
            string productUrl = Util.FormatUrl(Consts.PRODUCT_GETBYREFID);
            productUrl = productUrl.Replace("{{refId}}", refId);
            return await GetObjectFromUri<ProductModel>(productUrl);
        }

        /// <summary>
        /// Get product and all sku related by Category Id
        /// </summary>
        /// <param name="categoryId">Category Id</param>
        /// <param name="from">register from</param>
        /// <param name="to">register to</param>
        /// <returns></returns>
        public async Task<ProductAndSkuResponse> GetProductAndSkuIds(int categoryId, int from, int to)
        {
            string productUrl = Util.FormatUrl(Consts.PRODUCT_PRODUCTANDSKUIDS);
            productUrl = productUrl.Replace("{{categoryId}}", categoryId.ToString());
            productUrl = productUrl.Replace("{{from}}", from.ToString());
            productUrl = productUrl.Replace("{{to}}", to.ToString());
            return await GetObjectFromUri<ProductAndSkuResponse>(productUrl);
        }

    }


    
}
