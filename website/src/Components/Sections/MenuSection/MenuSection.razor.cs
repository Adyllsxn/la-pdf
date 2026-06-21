using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.MenuSection;

public partial class MenuSection : ComponentBase
{
    public string Subtitle { get; set; } = "Seleção Especial";
    public string Title { get; set; } = "Menu Delicioso";
    public string BtnText { get; set; } = "Ver Todo o Menu";

    public List<MenuItem> MenuItems { get; set; } = new()
    {
        new MenuItem { ImageUrl = "images/menu-1.png", Name = "Salada Grega", Badge = "Sazonal", Price = "8.500 Kz", Description = "Tomates, pimentão verde, pepino, cebola, azeitonas e queijo feta." },
        new MenuItem { ImageUrl = "images/menu-2.png", Name = "Lasanha", Badge = "", Price = "12.000 Kz", Description = "Vegetais, queijos, carnes moídas, molho de tomate, temperos e especiarias." },
        new MenuItem { ImageUrl = "images/menu-3.png", Name = "Abóbora", Badge = "", Price = "4.500 Kz", Description = "Abóbora assada com ervas, perfeita para vegetarianos." },
        new MenuItem { ImageUrl = "images/menu-4.png", Name = "Tokusen Wagyu", Badge = "Novo", Price = "18.500 Kz", Description = "Corte especial de carne Wagyu com acompanhamentos." },
        new MenuItem { ImageUrl = "images/menu-5.png", Name = "Olivas Rellenas", Badge = "", Price = "7.000 Kz", Description = "Azeitonas recheadas com caranguejo, cebola roxa e pimentão." },
        new MenuItem { ImageUrl = "images/menu-6.png", Name = "Peixe Opu", Badge = "", Price = "22.000 Kz", Description = "Peixe fresco grelhado com vegetais e molho especial." }
    };

    public string Shape2Image { get; set; } = "images/shape-5.png";
    public string Shape3Image { get; set; } = "images/shape-6.png";
}

public class MenuItem
{
    public string ImageUrl { get; set; } = "";
    public string Name { get; set; } = "";
    public string Badge { get; set; } = "";
    public string Price { get; set; } = "";
    public string Description { get; set; } = "";
}