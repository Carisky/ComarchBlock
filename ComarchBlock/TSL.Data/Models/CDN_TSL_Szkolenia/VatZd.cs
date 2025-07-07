using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class VatZd
{
    public int VaZVaZid { get; set; }

    public int VaZBufor { get; set; }

    public int? VaZBzdId { get; set; }

    public int VaZVaNid { get; set; }

    public int? VaZVaNidZk { get; set; }

    public int? VaZTrNid { get; set; }

    public int VaZTyp { get; set; }

    public int VaZDkNid { get; set; }

    public decimal VaZSumaKwotZdarzen { get; set; }

    public decimal VaZSumaKwotRozliczen { get; set; }

    public string VaZKntNazwa1 { get; set; } = null!;

    public string VaZKntNazwa2 { get; set; } = null!;

    public string VaZKntNazwa3 { get; set; } = null!;

    public string? VaZKntNipE { get; set; }

    public string VaZDokument { get; set; } = null!;

    public DateTime VaZDataWys { get; set; }

    public DateTime VaZTermin { get; set; }

    public DateTime? VaZTerminPlatnosci { get; set; }

    public decimal VaZRazemNetto { get; set; }

    public decimal VaZRazemVat { get; set; }

    public decimal VaZRazemBrutto { get; set; }

    public int? VaZRodzajZakupu { get; set; }

    public int? VaZOdliczenia { get; set; }

    public int VaZFlaga { get; set; }

    public decimal VaZStawka { get; set; }

    public decimal VaZNetto { get; set; }

    public decimal VaZVat { get; set; }

    public decimal VaZBrutto { get; set; }

    public decimal VaZKorektaNetto { get; set; }

    public decimal VaZKorektaVat { get; set; }

    public decimal? VaZPoprzednioDoRoliczenia { get; set; }

    public decimal? VaZPoprzednioRozliczono { get; set; }

    public decimal? VaZDoRoliczeniaNaDzienObliczenia { get; set; }

    public decimal? VaZRoliczonoNaDzienObliczenia { get; set; }

    public virtual DeklNag VaZDkN { get; set; } = null!;
}
