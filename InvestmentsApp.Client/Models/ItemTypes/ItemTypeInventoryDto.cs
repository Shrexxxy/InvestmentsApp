namespace InvestmentsApp.Client.Models.ItemTypes;

public class ItemTypeInventoryDto
{
    public string ItemType { get; set; }
    public List<ItemInventoryDto> Items { get; set; } = new();
}