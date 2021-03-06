﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VTexConnector.Entity;

namespace VTexConnector.OMS
{
    public class Orders : BaseClass
    {
        public Orders() : base()
        {
        }

        public async Task<Entity.GetOrder.Order> GetOrderByIdAsync(int orderId)
        {
            string orderUrl = Util.FormatUrl(Consts.OMS_GETORDER);
            orderUrl = orderUrl.Replace("{{orderId}}", orderId.ToString());
            return await GetObjectFromUri<Entity.GetOrder.Order>(orderUrl);
        }

        public async Task<Entity.OrderList.ListOrder> ListOrdersByStatusAsync(string orderStatus)
        {
            string orderUrl = Util.FormatUrl(Consts.OMS_LISTORDERS);
            orderUrl += "?f_status=" + orderStatus;
            return await GetObjectFromUri<Entity.OrderList.ListOrder>(orderUrl);
        }

        public async Task<bool> ChangeOrderStateAsync(int orderId, string status)
        {
            string orderUrl = Util.FormatUrl(Consts.OMS_CHANGEORDERSTATE);
            orderUrl = orderUrl.Replace("{{orderId}}", orderId.ToString());
            orderUrl = orderUrl.Replace("{{status}}", status);
            var retValue = await PostToUri(orderUrl);
            return retValue.IsSuccessStatusCode;
        }


        public async Task<bool> CancelOrder(int orderId, string status)
        {
            string orderUrl = Util.FormatUrl(Consts.OMS_CANCELORDER);
            orderUrl = orderUrl.Replace("{{orderId}}", orderId.ToString());
            var retValue = await PostToUri(orderUrl);
            return retValue.IsSuccessStatusCode;
        }
    }
}
