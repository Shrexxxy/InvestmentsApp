using InvestmentsApp.Client.Models.Item;

namespace InvestmentsApp.Client.Models.PriceHistory;

public class PriceHistoryViewModel
{
    public Guid Id { get; set; }
    public Guid ItemId { get; set; }
    public ItemViewModel? Item { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }
}