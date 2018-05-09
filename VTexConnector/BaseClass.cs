using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http;

namespace VTexConnector
{
    public abstract class BaseClass
    {

        protected System.Net.Http.HttpClient HttpClient { get; set; }

        /// <summary>
        /// Base constructor
        /// </summary>
        public BaseClass()
        {

            ThrowExceptionIfNull(Configuration.AccountName, "AccountName");

            ThrowExceptionIfNull(Configuration.AppKey, "AppKey");

            ThrowExceptionIfNull(Configuration.AppToken, "AppToken");

            ThrowExceptionIfNull(Configuration.Environment, "Environment");

            HttpClient = new System.Net.Http.HttpClient();
            HttpClient.DefaultRequestHeaders.Add("X-VTEX-API-AppKey", Configuration.AppKey);
            HttpClient.DefaultRequestHeaders.Add("X-VTEX-API-AppToken", Configuration.AppToken);
            HttpClient.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Throw excepction if Var is Null
        /// </summary>
        /// <param name="varToCompare">Value var</param>
        /// <param name="propertyName">Name of property</param>
        private void ThrowExceptionIfNull(string varToCompare, string propertyName)
        {
            if (string.IsNullOrEmpty(varToCompare))
                throw new ArgumentNullException(propertyName, "Preencher a propriedade " + propertyName + " da classe Configuration");
        }

        /// <summary>
        /// Extract object from Uri
        /// </summary>
        /// <typeparam name="T">Type of object to return</typeparam>
        /// <param name="productUri">URL to find object</param>
        /// <returns></returns>
        protected async Task<T> GetObjectFromUri<T>(string productUri)
        {
            var strRetorno = await this.HttpClient.GetStringAsync(productUri);
            return JsonConvert.DeserializeObject<T>(strRetorno);
        }


        /// <summary>
        /// Return Oject stream 
        /// </summary>
        /// <param name="productUri">URL to find object</param>
        /// <returns></returns>
        protected async Task<HttpResponseMessage> GetResponseMessageFromUri(string productUri)
        {
            var strRetorno = await this.HttpClient.GetAsync(productUri);
            return strRetorno;
        }

        /// <summary>
        /// Post object to Uri 
        /// </summary>
        /// <typeparam name="T">Type of object to return</typeparam>
        /// <param name="productUri">URL to find object</param>
        /// <returns></returns>
        protected async Task<HttpResponseMessage> PostToUri(string productUri, HttpContent content = null)
        {
            return await this.HttpClient.PostAsync(productUri, content);
        }


        /// <summary>
        /// Put object to Uri 
        /// </summary>
        /// <typeparam name="T">Type of object to return</typeparam>
        /// <param name="productUri">URL to insert object</param>
        /// <returns></returns>
        protected async Task<HttpResponseMessage> PutToUri(string productUri, HttpContent content = null)
        {
            return await this.HttpClient.PutAsync(productUri, content);
        }
    }
}
