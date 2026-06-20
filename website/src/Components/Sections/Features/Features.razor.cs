using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.Features;

public partial class Features : ComponentBase
{
    public string Subtitle { get; set; } = "Porquê Escolher-nos";
    public string Title { get; set; } = "A Nossa Força";

    public List<FeatureItem> FeatureItems { get; set; } = new()
    {
        new FeatureItem { IconUrl = "images/features-icon-1.png", Title = "Comida Higiénica", Description = "Ingredientes frescos com os mais altos padrões." },
        new FeatureItem { IconUrl = "images/features-icon-2.png", Title = "Ambiente Acolhedor", Description = "Um espaço pensado para conforto e bem-estar." },
        new FeatureItem { IconUrl = "images/features-icon-3.png", Title = "Chefs Qualificados", Description = "Nossos chefs trazem a verdadeira essência italiana." },
        new FeatureItem { IconUrl = "images/features-icon-4.png", Title = "Eventos & Festas", Description = "Eventos especiais com menu personalizado." }
    };

    public string Shape1Image { get; set; } = "images/shape-7.png";
    public string Shape2Image { get; set; } = "images/shape-8.png";
}

public class FeatureItem
{
    public string IconUrl { get; set; } = "";
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
}