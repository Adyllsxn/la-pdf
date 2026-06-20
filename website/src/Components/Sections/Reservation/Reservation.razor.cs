using Microsoft.AspNetCore.Components;

namespace LaPasta.src.Components.Sections.Reservation;

public partial class Reservation : ComponentBase
{
    public string Title { get; set; } = "Reserva Online";
    public string FormText { get; set; } = "Reservas";
    public string FormText2 { get; set; } = "ou preencha o formulário";
    public string PhoneNumber { get; set; } = "+244900000000";
    public string PhoneNumberFormatted { get; set; } = "+244 900 000 000";

    public string NamePlaceholder { get; set; } = "Seu Nome";
    public string PhonePlaceholder { get; set; } = "Telefone";
    public string MessagePlaceholder { get; set; } = "Mensagem";
    public string SubmitText { get; set; } = "Reservar Mesa";

    public string FormPatternImage { get; set; } = "images/form-pattern.png";
    public string ContactTitle { get; set; } = "Contacte-nos";
    public string ContactLabel { get; set; } = "Reservas";
    public string LocationLabel { get; set; } = "Localização";
    public string Address { get; set; } = "Talatona, Luanda - Angola";
    public string LunchLabel { get; set; } = "Almoço";
    public string LunchHours { get; set; } = "Segunda a Domingo<br>11:00 - 14:30";
    public string DinnerLabel { get; set; } = "Jantar";
    public string DinnerHours { get; set; } = "Segunda a Domingo<br>18:00 - 23:00";

    public List<SelectOption> PersonOptions { get; set; } = new()
    {
        new SelectOption { Value = "1", Text = "1 Pessoa" },
        new SelectOption { Value = "2", Text = "2 Pessoas" },
        new SelectOption { Value = "3", Text = "3 Pessoas" },
        new SelectOption { Value = "4", Text = "4 Pessoas" },
        new SelectOption { Value = "5", Text = "5 Pessoas" },
        new SelectOption { Value = "6", Text = "6 Pessoas" },
        new SelectOption { Value = "7", Text = "7 Pessoas" }
    };

    public List<SelectOption> TimeOptions { get; set; } = new()
    {
        new SelectOption { Value = "11:00", Text = "11:00" },
        new SelectOption { Value = "12:00", Text = "12:00" },
        new SelectOption { Value = "13:00", Text = "13:00" },
        new SelectOption { Value = "14:00", Text = "14:00" },
        new SelectOption { Value = "18:00", Text = "18:00" },
        new SelectOption { Value = "19:00", Text = "19:00" },
        new SelectOption { Value = "20:00", Text = "20:00" },
        new SelectOption { Value = "21:00", Text = "21:00" },
        new SelectOption { Value = "22:00", Text = "22:00" }
    };
}

public class SelectOption
{
    public string Value { get; set; } = "";
    public string Text { get; set; } = "";
}