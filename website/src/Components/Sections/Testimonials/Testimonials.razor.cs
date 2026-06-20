using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.Testimonials;

public partial class Testimonials : ComponentBase
{
    public string BgImage { get; set; } = "images/testimonial-bg.jpg";
    public string Quote { get; set; } = "A melhor massa que já comi em Luanda! O ambiente é acolhedor, o atendimento impecável e os ingredientes são fresquíssimos. Recomendo a todos!";
    public string Author { get; set; } = "Maria Silva";
    public string AvatarImage { get; set; } = "images/testi-avatar.jpg";
}