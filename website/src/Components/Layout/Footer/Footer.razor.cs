using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Layout.Footer;

public partial class Footer : ComponentBase
{
    // Ano atual
    public int CurrentYear => DateTime.Now.Year;

    // Informações de contato
    public string Address { get; set; } = "Talatona, Luanda - Angola";
    public string Email { get; set; } = "reservas@lapasta.com";
    public string PhoneNumber { get; set; } = "+244900000000";
    public string PhoneNumberFormatted { get; set; } = "+244 900 000 000";
    public string PhoneLabel { get; set; } = "Reservas";
    public string OpeningHours { get; set; } = "Aberto: 11:00 - 23:00";

    // Newsletter
    public string NewsTitle { get; set; } = "Receba Novidades";
    public string NewsText { get; set; } = "Inscreva-se e ganhe";
    public string Discount { get; set; } = "25% Off";
    public string EmailPlaceholder { get; set; } = "Seu email";
    public string SubscribeText { get; set; } = "Inscrever";

    // Navegação
    public string NavHome { get; set; } = "Início";
    public string NavMenu { get; set; } = "Menu";
    public string NavAbout { get; set; } = "Sobre";
    public string NavReservation { get; set; } = "Reservas";
    public string NavContact { get; set; } = "Contacto";

    // Copyright
    public string RightsText { get; set; } = "Todos os direitos reservados";
}