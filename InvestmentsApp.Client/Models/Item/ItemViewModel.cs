using InvestmentsApp.Client.Models.Quality;

namespace InvestmentsApp.Client.Models.Item;

public class ItemViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public Guid ItemTypeId { get; set; }
    public string ItemTypeName { get; set; }
    public string? NameOnMarket { get; set; }
    public Guid? QualityId { get; set; }
    public string? QualityName { get; set; }
    public decimal? LastPrice { get; set; }
}