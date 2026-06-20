using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.Hero;

public partial class Hero : ComponentBase
{
    public string BookingText { get; set; } = "Reservar";

    public List<SlideItem> Slides { get; set; } = new()
    {
        new SlideItem
        {
            ImageUrl = "images/hero-slider-1.jpg",
            Subtitle = "Tradição & Higiene",
            Title = (MarkupString)"Pelo amor à <br>comida deliciosa",
            Text = "Venha com a família e sinta a alegria de uma comida de dar água na boca",
            BtnText = "Ver Menu",
            IsActive = true
        },
        new SlideItem
        {
            ImageUrl = "images/hero-slider-2.jpg",
            Subtitle = "Experiência Deliciosa",
            Title = (MarkupString)"Sabores Inspirados <br>pelas Estações",
            Text = "Venha com a família e sinta a alegria de uma comida de dar água na boca",
            BtnText = "Ver Menu",
            IsActive = false
        },
        new SlideItem
        {
            ImageUrl = "images/hero-slider-3.jpg",
            Subtitle = "Incrível & Delicioso",
            Title = (MarkupString)"Onde cada sabor <br>conta uma história",
            Text = "Venha com a família e sinta a alegria de uma comida de dar água na boca",
            BtnText = "Ver Menu",
            IsActive = false
        }
    };
}

public class SlideItem
{
    public string ImageUrl { get; set; } = "";
    public string Subtitle { get; set; } = "";
    public MarkupString Title { get; set; }
    public string Text { get; set; } = "";
    public string BtnText { get; set; } = "";
    public bool IsActive { get; set; } = false;
}