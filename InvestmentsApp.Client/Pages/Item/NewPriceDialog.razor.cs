using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace InvestmentsApp.Client.Pages.Item;

public partial class NewPriceDialog : ComponentBase
{
    [CascadingParameter] IMudDialogInstance MudDialog { get; set; } = default!;

    [Parameter] public string ContentText { get; set; } = string.Empty;
    [Parameter] public string ButtonText { get; set; } = "ОК";
    [Parameter] public Color Color { get; set; } = Color.Primary;

    public decimal? NewPrice { get; set; }

    void Submit()
    {
        MudDialog.Close(DialogResult.Ok(NewPrice));
    }

    void Cancel()
    {
        MudDialog.Cancel();
    }
}