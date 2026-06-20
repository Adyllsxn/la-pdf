using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Layout.TopBar;

public partial class TopBar : ComponentBase
{
    public string Address { get; set; } = "Talatona, Luanda - Angola";
    public string OpeningHours { get; set; } = "Diariamente: 11:00 - 23:00";
    public string PhoneNumber { get; set; } = "+244900000000";
    public string PhoneNumberFormatted { get; set; } = "+244 900 000 000";
    public string Email { get; set; } = "reservas@lapasta.com";
}