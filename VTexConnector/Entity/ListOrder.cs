using System;
using System.Collections.Generic;

namespace VTexConnector.Entity.OrderList
{
    public class Item
    {
        public string seller { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
        public string ean { get; set; }
        public string refId { get; set; }
        public string id { get; set; }
        public string productId { get; set; }
        public int sellingPrice { get; set; }
        public int price { get; set; }
    }

    public class Order
    {
        public string orderId { get; set; }
        public DateTime creationDate { get; set; }
        public string clientName { get; set; }
        public List<Item> items { get; set; }
        public int totalValue { get; set; }
        public string paymentNames { get; set; }
        public string status { get; set; }
        public string statusDescription { get; set; }
        public string sequence { get; set; }
        public string salesChannel { get; set; }
        public string affiliateId { get; set; }
        public string origin { get; set; }
        public bool workflowInErrorState { get; set; }
        public bool workflowInRetry { get; set; }
        public string lastMessageUnread { get; set; }
        public DateTime ShippingEstimatedDate { get; set; }
        public bool orderIsComplete { get; set; }
        public DateTime authorizedDate { get; set; }
    }

    public class Paging
    {
        public int total { get; set; }
        public int pages { get; set; }
        public int currentPage { get; set; }
        public int perPage { get; set; }
    }

    public class Facets
    {
    }

    public class TotalValue
    {
        public int Count { get; set; }
        public int Max { get; set; }
        public int Mean { get; set; }
        public int Min { get; set; }
        public int Missing { get; set; }
        public int StdDev { get; set; }
        public int Sum { get; set; }
        public int SumOfSquares { get; set; }
        public Facets Facets { get; set; }
    }

    public class Facets2
    {
    }

    public class TotalItems
    {
        public int Count { get; set; }
        public int Max { get; set; }
        public int Mean { get; set; }
        public int Min { get; set; }
        public int Missing { get; set; }
        public int StdDev { get; set; }
        public int Sum { get; set; }
        public int SumOfSquares { get; set; }
        public Facets2 Facets { get; set; }
    }

    public class Stats2
    {
        public TotalValue totalValue { get; set; }
        public TotalItems totalItems { get; set; }
    }

    public class Stats
    {
        public Stats2 stats { get; set; }
    }

    public class ListOrder
    {
        public List<Order> list { get; set; }
        public Paging paging { get; set; }
        public Stats stats { get; set; }
    }
}
