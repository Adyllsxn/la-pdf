using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.Event;

public partial class Event : ComponentBase
{
    public string Subtitle { get; set; } = "Atualizações Recentes";
    public string Title { get; set; } = "Próximos Eventos";
    public string BtnText { get; set; } = "Ver Blog";

    public List<EventItem> EventItems { get; set; } = new()
    {
        new EventItem { ImageUrl = "images/event-1.jpg", Date = "15/09/2022", Category = "Comida, Sabor", TitleText = "Sabor tão bom que vai querer comer com os olhos.", AltText = "Event" },
        new EventItem { ImageUrl = "images/event-2.jpg", Date = "08/09/2022", Category = "Comida Saudável", TitleText = "Sabor tão bom que vai querer comer com os olhos.", AltText = "Event" },
        new EventItem { ImageUrl = "images/event-3.jpg", Date = "03/09/2022", Category = "Receita", TitleText = "Sabor tão bom que vai querer comer com os olhos.", AltText = "Event" }
    };
}

public class EventItem
{
    public string ImageUrl { get; set; } = "";
    public string Date { get; set; } = "";
    public string Category { get; set; } = "";
    public string TitleText { get; set; } = "";
    public string AltText { get; set; } = "";
}