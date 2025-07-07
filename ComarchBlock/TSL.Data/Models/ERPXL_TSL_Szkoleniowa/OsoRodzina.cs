using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OsoRodzina
{
    public int OsRId { get; set; }

    public int? OsROsoNumer { get; set; }

    public int? OsRDataOd { get; set; }

    public int? OsRDataDo { get; set; }

    public string? OsRImie { get; set; }

    public string? OsRNazwisko { get; set; }

    public int? OsRDataUrodzenia { get; set; }

    public string? OsRMiejsceUrodzenia { get; set; }

    public string? OsRPesel { get; set; }

    public string? OsRNip { get; set; }

    public byte? OsRDokTozsamosci { get; set; }

    public string? OsRDokNumer { get; set; }

    public string? OsRUlica { get; set; }

    public string? OsRNrDom { get; set; }

    public string? OsRNrLokal { get; set; }

    public string? OsRKodP { get; set; }

    public string? OsRMiasto { get; set; }

    public string? OsRPoczta { get; set; }

    public string? OsRGmina { get; set; }

    public string? OsRWojewodztwo { get; set; }

    public string? OsRPowiat { get; set; }

    public string? OsRKraj { get; set; }

    public int? OsROkresUprOd { get; set; }

    public int? OsROkresUprDo { get; set; }

    public byte? OsRPozostaje { get; set; }

    public int? OsRKodPokrewienstwa { get; set; }

    public int? OsRKodNiepelnosprawnosci { get; set; }

    public int? OsROpeWnumer { get; set; }

    public int? OsRCzasWprowadzenia { get; set; }

    public int? OsROpeMnumer { get; set; }

    public int? OsRCzasModyfikacji { get; set; }

    public virtual PrcKarty? OsROsoNumerNavigation { get; set; }
}
