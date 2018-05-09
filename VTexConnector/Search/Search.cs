using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VTexConnector.Entity;

namespace VTexConnector.Search
{
    public class Search : BaseClass
    {
        private int MAX_ITEMS_ALLOWED = 49;

        public Search() : base()
        {
        }

        /// <summary>
        /// Get all products 
        /// </summary>
        /// <returns>Return request from VTex</returns>
        public async Task<List<ProductSearch>> GetAllProductsAsync(int startItem = 0)
        {
            IEnumerable<string> lstResources;
            List<ProductSearch> lstReturn = new List<ProductSearch>();
            int endItems = startItem + MAX_ITEMS_ALLOWED;
            int iTotal = endItems;

            string productUrl = Util.FormatUrl(Consts.SEARCH_PRODUCTSEARCH);
            productUrl = productUrl.Replace("{{search}}", $"?_from={startItem}&_to={endItems}");

            using (var rtMessage = await GetResponseMessageFromUri(productUrl))
            {
                var strProducts = await rtMessage.Content.ReadAsStringAsync();
                foreach (var item in JsonConvert.DeserializeObject<List<ProductSearch>>(strProducts))
                {
                    lstReturn.Add(item);
                }

                if (rtMessage.Headers.TryGetValues("resources", out lstResources))
                {
                    var strResources = string.Join("", lstResources);
                    iTotal = Convert.ToInt32(strResources.Split('/')[1]);
                }
            }

            if (iTotal > endItems)
            {
                var anotherSearch = await GetAllProductsAsync(startItem + MAX_ITEMS_ALLOWED);
                foreach (var item in anotherSearch)
                {
                    lstReturn.Add(item);
                }
            }

            return lstReturn;
        }



    }
}
