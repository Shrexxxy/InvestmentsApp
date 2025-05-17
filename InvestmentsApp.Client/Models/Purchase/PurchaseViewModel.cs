using InvestmentsApp.Client.Models.Item;

namespace InvestmentsApp.Client.Models.Purchase;

public class PurchaseViewModel
{
    public Guid Id { get; set; }
    public string ItemName { get; set; }
    public string? QualityName { get; set; }
    public string ItemTypeName { get; set; }
    public Guid ItemId { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerUnit { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime PurchaseDate { get; set; }
    public decimal CurrentPricePerUnit { get; set; }
    public decimal CurrentTotalPrice { get; set; }
    public decimal PriceDifference { get; set; }
    public decimal PriceDifferencePercent { get; set; }
}