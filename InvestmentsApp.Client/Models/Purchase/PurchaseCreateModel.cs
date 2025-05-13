namespace InvestmentsApp.Client.Models.Purchase;

public class PurchaseCreateModel
{
    public Guid ItemId { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerUnit { get; set; }
}