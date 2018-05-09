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
        internal static string PRODUCT_PRODUCTANDSKUIDS = "http://{{accountName}}.{{environment}}.com.br/api/catalog_system/pvt/products/GetProductAndSkuIds?categoryId={{categoryId}}&_from={{from}}&_to={{to}}";
        internal static string SKU_GETBYID = "http://{{accountName}}.{{environment}}.com.br/api/catalog_system/pvt/sku/stockkeepingunitbyid/{{skuId}}";
        internal static string PRICE_GETPRICE = "https://api.vtex.com/{{accountName}}/pricing/prices/{{itemId}}";
        internal static string PRICE_GETFIXEDPRICES = "https://api.vtex.com/{{accountName}}/pricing/prices/{{itemId}}/fixed";
        internal static string PRICE_GETCOMPUTEDPRICES = "https://api.vtex.com/{{accountName}}/pricing/prices/{{itemId}}/computed/{{tradePolicyId}}?categoryIds=[{{categoryId}}]&brandId={{brandId}}&quantity={{quantity}}";
        internal static string PRICE_CREATEEDITPRICES = "https://api.vtex.com/{{accountName}}/pricing/prices/{{itemId}}";
        internal static string PRICE_CREATEEDITFIXEDPRICES = "https://api.vtex.com/{{account}}/pricing/prices/{{itemId}}/fixed";
        internal static string PRICE_DELETEFIXEDPRICE = "https://api.vtex.com/{{account}}/pricing/prices/{{itemId}}";

        internal static string OMS_GETORDER = "http://{{accountName}}.{{environment}}.com.br/api/oms/pvt/orders/{{orderId}}";
        internal static string OMS_LISTORDERS = "http://{{accountName}}.{{environment}}.com.br/api/oms/pvt/orders";
        internal static string OMS_CANCELORDER = "http://{{accountName}}.{{environment}}.com.br/api/oms/pvt/orders/{{orderId}}/cancel";
        internal static string OMS_CHANGEORDERSTATE = "http://{{accountName}}.{{environment}}.com.br/api/oms/pvt/orders/{{orderId}}/changestate/{{status}}";

        internal static string INVENTORY_UPDATEINVENTORYBYSKUWAREHOUSE = "http://logistics.{{environment}}.com.br/api/logistics/pvt/inventory/skus/{{skuId}}/warehouses/{{warehouseId}}?an={{accountName}}";
        internal static string INVENTORY_GETBYSKU = "http://logistics.{{environment}}.com.br/api/logistics/pvt/inventory/skus/{{skuId}}?an={{accountName}}";


        internal static string SEARCH_PRODUCTSEARCH = "http://{{accountName}}.{{environment}}.com.br/api/catalog_system/pub/products/search/{{search}}";
    }
}
