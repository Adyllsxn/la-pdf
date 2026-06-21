using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.SpecialDish;

public partial class SpecialDish : ComponentBase
{
    public string BannerImage { get; set; } = "images/special-dish-banner.jpg";
    public string BadgeImage { get; set; } = "images/badge-1.png";
    public string Subtitle { get; set; } = "Prato Especial";
    public string Title { get; set; } = "Lobster Tortellini";
    public string Description { get; set; } = "Uma combinação perfeita de massa fresca recheada com lagosta, servida com um molho de manteiga e ervas aromáticas. Uma experiência gastronómica que vai surpreender o seu paladar.";
    public string OldPrice { get; set; } = "16.500 Kz";
    public string NewPrice { get; set; } = "9.500 Kz";
    public string BtnText { get; set; } = "Ver Menu";
    public string Shape1Image { get; set; } = "images/shape-4.png";
    public string Shape2Image { get; set; } = "images/shape-9.png";
}