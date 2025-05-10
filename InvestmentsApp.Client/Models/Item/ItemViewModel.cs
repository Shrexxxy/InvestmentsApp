using InvestmentsApp.Client.Models.Quality;

namespace InvestmentsApp.Client.Models.Item;

public class ItemViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public Guid ItemTypeId { get; set; }
    public ItemTypeViewModel ItemType { get; set; }
    
    public Guid? QualityId { get; set; }
    public QualityViewModel? Quality { get; set; }
}