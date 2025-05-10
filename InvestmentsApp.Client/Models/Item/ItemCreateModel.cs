namespace InvestmentsApp.Client.Models.Item;

public class ItemCreateModel
{
    public string Name { get; set; }
    public Guid ItemTypeId { get; set; }
    public Guid? QualityId { get; set; }
}