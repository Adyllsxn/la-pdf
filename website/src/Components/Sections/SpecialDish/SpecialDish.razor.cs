using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.SpecialDish;

public partial class SpecialDish : ComponentBase
{
    public string BannerImage { get; set; } = "images/special-dish-banner.jpg";
    public string BadgeImage { get; set; } = "images/badge-1.png";
    public string Subtitle { get; set; } = "Prato Especial";
    public string Title { get; set; } = "Lobster Tortellini";
    public string Description { get; set; } = "Lorem Ipsum is simply dummy text of the printing and typesetting industry lorem Ipsum has been the industrys standard dummy text ever since the when an unknown printer took a galley of type.";
    public string OldPrice { get; set; } = "$40.00";
    public string NewPrice { get; set; } = "$20.00";
    public string BtnText { get; set; } = "Ver Menu";
    public string Shape1Image { get; set; } = "images/shape-4.png";
    public string Shape2Image { get; set; } = "images/shape-9.png";
}