using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace InvestmentsApp.Client.Components;

public partial class ConfirmationDialog
{
    [CascadingParameter] IMudDialogInstance MudDialog { get; set; }

    [Parameter] public string ContentText { get; set; }

    [Parameter] public string ButtonText { get; set; }

    [Parameter] public Color Color { get; set; }
    [Parameter] public Guid EntityId { get; set; }

    void Submit() => MudDialog.Close(DialogResult.Ok(EntityId));
    void Cancel() => MudDialog.Cancel();
}