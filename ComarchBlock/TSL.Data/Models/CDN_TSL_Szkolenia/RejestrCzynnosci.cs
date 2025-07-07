using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class RejestrCzynnosci
{
    public int RucRucid { get; set; }

    public string RucNazwa { get; set; } = null!;

    public string RucCelPrzetwarzania { get; set; } = null!;

    public string RucKategorieOsob { get; set; } = null!;

    public string RucKategorieDanychOs { get; set; } = null!;

    public string RucKategorieOdbiorcow { get; set; } = null!;

    public string RucPlanowanyTermin { get; set; } = null!;

    public string RucInformacjeDodatkowe { get; set; } = null!;

    public int? RucOpeZalId { get; set; }

    public int? RucOpeModId { get; set; }

    public int? RucStaZalId { get; set; }

    public int? RucStaModId { get; set; }

    public DateTime RucTsZal { get; set; }

    public DateTime RucTsMod { get; set; }

    public string RucOpeModKod { get; set; } = null!;

    public string RucOpeZalKod { get; set; } = null!;

    public string RucOpeModNazwisko { get; set; } = null!;

    public string RucOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<PanstwaTrzecie> PanstwaTrzecies { get; set; } = new List<PanstwaTrzecie>();
}
