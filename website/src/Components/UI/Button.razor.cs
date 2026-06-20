using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace LaPasta.src.Components.Shared;

public partial class Button : ComponentBase
{
    [Parameter] public string Text1 { get; set; } = "Button";
    [Parameter] public string Text2 { get; set; } = "Button";
    [Parameter] public string ButtonClass { get; set; } = "btn-primary";
    [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }
}