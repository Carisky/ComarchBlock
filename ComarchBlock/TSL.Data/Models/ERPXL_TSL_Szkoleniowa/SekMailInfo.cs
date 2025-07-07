using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SekMailInfo
{
    public int SdsId { get; set; }

    public string? SerwerSmtp { get; set; }

    public string? Port { get; set; }

    public string? AdresPotwierdzajacy { get; set; }

    public string? MailOdNazwa { get; set; }

    public string? Uzytkownik { get; set; }

    public string? Haslo { get; set; }

    public string? MailOd { get; set; }

    public string? SdsEmailTemat { get; set; }

    public string? SdsEmailTresc { get; set; }

    public string? SdsNazwa { get; set; }

    public string? Url { get; set; }

    public string? CzyWysylac { get; set; }
}
