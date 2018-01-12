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
            return await ExtractObject<ProductModel>(productUrl);
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
            return await ExtractObject<ProductModel>(productUrl);
        }

    }


    
}
