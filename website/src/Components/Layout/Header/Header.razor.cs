using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Layout.Header;

public partial class Header : ComponentBase
{
    // ============================================
    // PROPRIEDADES
    // ============================================

    // Logo
    public string LogoUrl { get; set; } = "images/logo.svg";
    public string LogoWidth { get; set; } = "140";
    public string LogoHeight { get; set; } = "60";
    public string LogoAlt { get; set; } = "La Pasta - Início";

    // Classe do Header (scroll)
    public string HeaderClass { get; set; } = "";

    // Navegação
    public List<NavItem> NavItems { get; set; } = new()
    {
        new NavItem { Text = "Início", Url = "/", IsActive = true },
        new NavItem { Text = "Menu", Url = "#menu" },
        new NavItem { Text = "Sobre", Url = "#about" },
        new NavItem { Text = "Reservas", Url = "#reservation" },
        new NavItem { Text = "Contacto", Url = "#contact" }
    };

    // Informações de contato
    public string NavTitle { get; set; } = "Visite-nos";
    public string Address { get; set; } = "Talatona, Luanda";
    public string City { get; set; } = "Angola";
    public string OpeningHours { get; set; } = "Aberto: 11:00 - 23:00";
    public string Email { get; set; } = "reservas@lapasta.com";
    public string ContactLabel { get; set; } = "Reservas";
    public string PhoneNumber { get; set; } = "+244900000000";
    public string PhoneNumberFormatted { get; set; } = "+244 900 000 000";

    // Botão
    public string BtnText1 { get; set; } = "Reservar";
    public string BtnText2 { get; set; } = "Reservar";
    public string BtnClass { get; set; } = "btn-secondary";

    // ============================================
    // MÉTODOS
    // ============================================

    public void UpdateHeaderClass(bool isActive, bool isHidden)
    {
        HeaderClass = "";
        if (isActive) HeaderClass += " active";
        if (isHidden) HeaderClass += " hide";
    }

    public void SetActiveNav(string url)
    {
        foreach (var item in NavItems)
        {
            item.IsActive = item.Url == url;
        }
    }
}

public class NavItem
{
    public string Text { get; set; } = "";
    public string Url { get; set; } = "";
    public bool IsActive { get; set; } = false;
}