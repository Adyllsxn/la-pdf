using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.Service;

public partial class Service : ComponentBase
{
    public string Subtitle { get; set; } = "Sabores para Realeza";
    public string Title { get; set; } = "Oferecemos o Melhor";
    public string Description { get; set; } = "No La Pasta, cada prato é preparado com ingredientes frescos e selecionados, combinando tradição e inovação para proporcionar uma experiência gastronómica inesquecível. Venha descobrir sabores que encantam!";  

    public List<ServiceItem> ServiceItems { get; set; } = new()
    {
        new ServiceItem { ImageUrl = "images/service-1.jpg", Title = "Pequeno-Almoço", BtnText = "Ver Menu" },
        new ServiceItem { ImageUrl = "images/service-2.jpg", Title = "Entradas", BtnText = "Ver Menu" },
        new ServiceItem { ImageUrl = "images/service-3.jpg", Title = "Bebidas", BtnText = "Ver Menu" }
    };
}

public class ServiceItem
{
    public string ImageUrl { get; set; } = "";
    public string Title { get; set; } = "";
    public string BtnText { get; set; } = "";
}