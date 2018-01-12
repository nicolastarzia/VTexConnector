using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace VTexConnector
{
    public abstract class BaseClass
    {
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

        public System.Net.Http.HttpClient HttpClient { get; set; }

        private void ThrowExceptionIfNull(string varToCompare, string propertyName)
        {
            if (string.IsNullOrEmpty(varToCompare))
                throw new ArgumentNullException(propertyName, "Preencher a propriedade " + propertyName + " da classe Configuration");
        }

        protected async Task<T> ExtractObject<T>(string productUrl)
        {
            var strRetorno = await this.HttpClient.GetStringAsync(productUrl);

            return JsonConvert.DeserializeObject<T>(strRetorno);
        }
    }
}
