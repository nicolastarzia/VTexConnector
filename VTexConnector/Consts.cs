using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTexConnector
{
    internal static class Consts
    {
        internal static string PRODUCT_GETBYID = "http://{{accountName}}.{{environment}}.com.br/api/catalog_system/pvt/products/ProductGet/{{productId}}";
        internal static string PRODUCT_GETBYREFID = "http://{{accountName}}.{{environment}}.com.br/api/catalog_system/pvt/products/productgetbyrefid/{{refId}}";
    }
}
