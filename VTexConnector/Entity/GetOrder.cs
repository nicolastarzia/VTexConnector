using System;
using System.Collections.Generic;
using System.Text;

namespace VTexConnector.Entity.GetOrder
{
    public partial class Order
{
    public string OrderId { get; set; }
    public string Sequence { get; set; }
    public string MarketplaceOrderId { get; set; }
    public string MarketplaceServicesEndpoint { get; set; }
    public string SellerOrderId { get; set; }
    public string Origin { get; set; }
    public string AffiliateId { get; set; }
    public string SalesChannel { get; set; }
    public dynamic MerchantName { get; set; }
    public string Status { get; set; }
    public string StatusDescription { get; set; }
    public long Value { get; set; }
    public DateTimeOffset CreationDate { get; set; }
    public DateTimeOffset LastChange { get; set; }
    public string OrderGroup { get; set; }
    public List<Total> Totals { get; set; }
    public List<Item> Items { get; set; }
    public List<dynamic> MarketplaceItems { get; set; }
    public ClientProfileData ClientProfileData { get; set; }
    public dynamic GiftRegistryData { get; set; }
    public MarketingData MarketingData { get; set; }
    public RatesAndBenefitsData RatesAndBenefitsData { get; set; }
    public ShippingData ShippingData { get; set; }
    public PaymentData PaymentData { get; set; }
    public PackageAttachment PackageAttachment { get; set; }
    public List<Seller> Sellers { get; set; }
    public dynamic CallCenterOperatorData { get; set; }
    public string FollowUpEmail { get; set; }
    public dynamic LastMessage { get; set; }
    public string Hostname { get; set; }
    public dynamic ChangesAttachment { get; set; }
    public dynamic OpenTextField { get; set; }
    public long RoundingError { get; set; }
    public string OrderFormId { get; set; }
    public dynamic CommercialConditionData { get; set; }
    public bool IsCompleted { get; set; }
    public dynamic CustomData { get; set; }
    public StorePreferencesData StorePreferencesData { get; set; }
    public bool AllowCancellation { get; set; }
    public bool AllowEdition { get; set; }
    public bool IsCheckedIn { get; set; }
    public Marketplace Marketplace { get; set; }
}

public partial class ClientProfileData
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DocumentType { get; set; }
    public string Document { get; set; }
    public string Phone { get; set; }
    public string CorporateName { get; set; }
    public string TradeName { get; set; }
    public string CorporateDocument { get; set; }
    public string StateInscription { get; set; }
    public string CorporatePhone { get; set; }
    public bool IsCorporate { get; set; }
    public string UserProfileId { get; set; }
    public string CustomerClass { get; set; }
}

public partial class Item
{
    public string UniqueId { get; set; }
    public string Id { get; set; }
    public string ProductId { get; set; }
    public string Ean { get; set; }
    public string LockId { get; set; }
    public ItemAttachment ItemAttachment { get; set; }
    public List<dynamic> Attachments { get; set; }
    public long Quantity { get; set; }
    public string Seller { get; set; }
    public string Name { get; set; }
    public string RefId { get; set; }
    public long Price { get; set; }
    public long ListPrice { get; set; }
    public dynamic ManualPrice { get; set; }
    public List<dynamic> PriceTags { get; set; }
    public string ImageUrl { get; set; }
    public string DetailUrl { get; set; }
    public List<dynamic> Components { get; set; }
    public List<dynamic> BundleItems { get; set; }
    public List<dynamic> Params { get; set; }
    public List<dynamic> Offerings { get; set; }
    public string SellerSku { get; set; }
    public dynamic PriceValidUntil { get; set; }
    public long Commission { get; set; }
    public long Tax { get; set; }
    public dynamic PreSaleDate { get; set; }
    public AdditionalInfo AdditionalInfo { get; set; }
    public string MeasurementUnit { get; set; }
    public long UnitMultiplier { get; set; }
    public long SellingPrice { get; set; }
    public bool IsGift { get; set; }
    public dynamic ShippingPrice { get; set; }
    public long RewardValue { get; set; }
    public long FreightCommission { get; set; }
}

public partial class AdditionalInfo
{
    public string BrandName { get; set; }
    public string BrandId { get; set; }
    public string CategoriesIds { get; set; }
    public string ProductClusterId { get; set; }
    public string CommercialConditionId { get; set; }
    public Dimension Dimension { get; set; }
    public dynamic OfferingInfo { get; set; }
    public dynamic OfferingType { get; set; }
    public dynamic OfferingTypeId { get; set; }
}

public partial class Dimension
{
    public double Cubicweight { get; set; }
    public long Height { get; set; }
    public double Length { get; set; }
    public long Weight { get; set; }
    public double Width { get; set; }
}

public partial class ItemAttachment
{
    public dynamic Name { get; set; }
}


public partial class MarketingData
{
    public string Id { get; set; }
    public string UtmSource { get; set; }
    public string UtmPartner { get; set; }
    public string UtmMedium { get; set; }
    public string UtmCampaign { get; set; }
    public string Coupon { get; set; }
    public string UtmiCampaign { get; set; }
    public string Utmipage { get; set; }
    public string UtmiPart { get; set; }
    public List<string> MarketingTags { get; set; }
}

public partial class Marketplace
{
    public string BaseUrl { get; set; }
    public dynamic IsCertified { get; set; }
    public string Name { get; set; }
}

public partial class PackageAttachment
{
    public List<dynamic> Packages { get; set; }
}

public partial class PaymentData
{
    public List<Transaction> Transactions { get; set; }
}

public partial class Transaction
{
    public bool IsActive { get; set; }
    public string TransactionId { get; set; }
    public string MerchantName { get; set; }
    public List<Payment> Payments { get; set; }
}

public partial class Payment
{
    public string Id { get; set; }
    public string PaymentSystem { get; set; }
    public string PaymentSystemName { get; set; }
    public long Value { get; set; }
    public long Installments { get; set; }
    public long ReferenceValue { get; set; }
    public string CardHolder { get; set; }
    public string CardNumber { get; set; }
    public string FirstDigits { get; set; }
    public string LastDigits { get; set; }
    public string Cvv2 { get; set; }
    public string ExpireMonth { get; set; }
    public string ExpireYear { get; set; }
    public string Url { get; set; }
    public string GiftCardId { get; set; }
    public string GiftCardName { get; set; }
    public string GiftCardCaption { get; set; }
    public string RedemptionCode { get; set; }
    public string Group { get; set; }
    public string Tid { get; set; }
    public string DueDate { get; set; }
}

public partial class RatesAndBenefitsData
{
    public string Id { get; set; }
    public List<dynamic> RateAndBenefitsIdentifiers { get; set; }
}

public partial class Seller
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
}

public partial class ShippingData
{
    public string Id { get; set; }
    public Address Address { get; set; }
    public List<LogisticsInfo> LogisticsInfo { get; set; }
    public dynamic TrackingHints { get; set; }
    public List<Address> SelectedAddresses { get; set; }
}

public partial class Address
{
    public string AddressType { get; set; }
    public string ReceiverName { get; set; }
    public string AddressId { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string Neighborhood { get; set; }
    public string Complement { get; set; }
    public string Reference { get; set; }
}

public partial class LogisticsInfo
{
    public long ItemIndex { get; set; }
    public string SelectedSla { get; set; }
    public string LockTtl { get; set; }
    public long Price { get; set; }
    public long ListPrice { get; set; }
    public long SellingPrice { get; set; }
    public dynamic DeliveryWindow { get; set; }
    public string DeliveryCompany { get; set; }
    public string ShippingEstimate { get; set; }
    public DateTimeOffset ShippingEstimateDate { get; set; }
    public List<Sla> Slas { get; set; }
    public List<string> ShipsTo { get; set; }
    public List<DeliveryId> DeliveryIds { get; set; }
    public string DeliveryChannel { get; set; }
    public PickupStoreInfo PickupStoreInfo { get; set; }
    public string AddressId { get; set; }
}

public partial class DeliveryId
{
    public string CourierId { get; set; }
    public string CourierName { get; set; }
    public string DockId { get; set; }
    public long Quantity { get; set; }
    public string WarehouseId { get; set; }
}

public partial class PickupStoreInfo
{
    public dynamic AdditionalInfo { get; set; }
    public dynamic Address { get; set; }
    public dynamic DockId { get; set; }
    public dynamic FriendlyName { get; set; }
    public bool IsPickupStore { get; set; }
}

public partial class Sla
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string ShippingEstimate { get; set; }
    public dynamic DeliveryWindow { get; set; }
    public long Price { get; set; }
    public string DeliveryChannel { get; set; }
    public PickupStoreInfo PickupStoreInfo { get; set; }
}

public partial class StorePreferencesData
{
    public string CountryCode { get; set; }
    public string CurrencyCode { get; set; }
    public CurrencyFormatInfo CurrencyFormatInfo { get; set; }
    public long CurrencyLocale { get; set; }
    public string CurrencySymbol { get; set; }
    public string TimeZone { get; set; }
}

public partial class CurrencyFormatInfo
{
    public long CurrencyDecimalDigits { get; set; }
    public string CurrencyDecimalSeparator { get; set; }
    public string CurrencyGroupSeparator { get; set; }
    public long CurrencyGroupSize { get; set; }
    public bool StartsWithCurrencySymbol { get; set; }
}

public partial class Total
{
    public string Id { get; set; }
    public string Name { get; set; }
    public long Value { get; set; }
}

}
