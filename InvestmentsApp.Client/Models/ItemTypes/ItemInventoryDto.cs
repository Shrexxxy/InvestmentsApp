namespace InvestmentsApp.Client.Models.ItemTypes;

public class ItemInventoryDto
{
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public decimal LastPrice { get; set; }
    public decimal TotalPrice { get; set; }
}