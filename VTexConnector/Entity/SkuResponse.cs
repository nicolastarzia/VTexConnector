using System;
using System.Collections.Generic;
using System.Text;

namespace VTexConnector.Entity
{
    public class Dimension
    {
        public int cubicweight { get; set; }
        public int height { get; set; }
        public int length { get; set; }
        public int weight { get; set; }
        public int width { get; set; }
    }

    public class RealDimension
    {
        public int realCubicWeight { get; set; }
        public int realHeight { get; set; }
        public int realLength { get; set; }
        public int realWeight { get; set; }
        public int realWidth { get; set; }
    }

    public class SkuSeller
    {
        public string SellerId { get; set; }
        public int StockKeepingUnitId { get; set; }
        public string SellerStockKeepingUnitId { get; set; }
        public bool IsActive { get; set; }
        public int FreightCommissionPercentage { get; set; }
        public int ProductCommissionPercentage { get; set; }
    }

    public class Image
    {
        public string ImageUrl { get; set; }
        public string ImageName { get; set; }
        public int FileId { get; set; }
    }

    public class SkuSpecification
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public List<int> FieldValueIds { get; set; }
        public List<string> FieldValues { get; set; }
    }

    public class ProductSpecification
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public List<object> FieldValueIds { get; set; }
        public List<string> FieldValues { get; set; }
    }


    public class AlternateIds
    {
        public string Ean { get; set; }
        public string RefId { get; set; }
    }

    public class SkuResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string NameComplete { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string TaxCode { get; set; }
        public string SkuName { get; set; }
        public bool IsActive { get; set; }
        public bool IsTransported { get; set; }
        public bool IsInventoried { get; set; }
        public bool IsGiftCardRecharge { get; set; }
        public string ImageUrl { get; set; }
        public string DetailUrl { get; set; }
        public object CSCIdentification { get; set; }
        public string BrandId { get; set; }
        public string BrandName { get; set; }
        public Dimension Dimension { get; set; }
        public RealDimension RealDimension { get; set; }
        public string ManufacturerCode { get; set; }
        public bool IsKit { get; set; }
        public List<object> KitItems { get; set; }
        public List<object> Services { get; set; }
        public List<object> Categories { get; set; }
        public List<object> Attachments { get; set; }
        public List<object> Collections { get; set; }
        public List<SkuSeller> SkuSellers { get; set; }
        public List<int> SalesChannels { get; set; }
        public List<Image> Images { get; set; }
        public List<SkuSpecification> SkuSpecifications { get; set; }
        public List<ProductSpecification> ProductSpecifications { get; set; }
        public string ProductClustersIds { get; set; }
        public string ProductCategoryIds { get; set; }
        public int ProductGlobalCategoryId { get; set; }
        public Dictionary<string, IEnumerable<string>> ProductCategories { get; set; }
        public int CommercialConditionId { get; set; }
        public int RewardValue { get; set; }
        public AlternateIds AlternateIds { get; set; }
        public List<string> AlternateIdValues { get; set; }
        public object EstimatedDateArrival { get; set; }
        public string MeasurementUnit { get; set; }
        public int UnitMultiplier { get; set; }
        public string InformationSource { get; set; }
        public object ModalType { get; set; }
    }
}
