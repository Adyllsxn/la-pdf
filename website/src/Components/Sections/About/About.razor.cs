using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.About;

public partial class About : ComponentBase
{
    public string Subtitle { get; set; } = "Nossa História";
    public string Title { get; set; } = "Cada Sabor Conta uma História";
    public string Description { get; set; } = "O La Pasta nasceu da paixão pela culinária italiana autêntica. Nossas receitas são passadas de geração em geração, combinando ingredientes frescos e técnicas tradicionais que fazem da nossa massa uma experiência única em Luanda.";

    public string ContactLabel { get; set; } = "Reservas";
    public string PhoneNumber { get; set; } = "+244900000000";
    public string PhoneNumberFormatted { get; set; } = "+244 900 000 000";
    public string BtnText { get; set; } = "Saber Mais";

    public string BannerImage { get; set; } = "images/about-banner.jpg";
    public string AbsImage1 { get; set; } = "images/about-abs-image.jpg";
    public string AbsImage2 { get; set; } = "images/badge-2.png";
    public string ShapeImage { get; set; } = "images/shape-3.png";
}