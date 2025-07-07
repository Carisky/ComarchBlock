using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DodatkiHist
{
    public int DohDohId { get; set; }

    public int DohDodId { get; set; }

    public int DohTwpId { get; set; }

    public int? DohListaPlacSymbol { get; set; }

    public string? DohNazwa { get; set; }

    public DateTime DohOkresOd { get; set; }

    public DateTime DohOkresDo { get; set; }

    public DateTime DohWaznyOd { get; set; }

    public DateTime DohWaznyDo { get; set; }

    public decimal DohWartosc1 { get; set; }

    public decimal DohWartosc2 { get; set; }

    public string DohPozyczkaNr { get; set; } = null!;

    public string DohOpis { get; set; } = null!;

    public string DohOddelegowanyWaluta { get; set; } = null!;

    public int? DohOpeZalId { get; set; }

    public int? DohStaZalId { get; set; }

    public DateTime DohTsZal { get; set; }

    public int? DohOpeModId { get; set; }

    public int? DohStaModId { get; set; }

    public DateTime DohTsMod { get; set; }

    public string DohOpeModKod { get; set; } = null!;

    public string DohOpeModNazwisko { get; set; } = null!;

    public string DohOpeZalKod { get; set; } = null!;

    public string DohOpeZalNazwisko { get; set; } = null!;

    public string? DohImportRowId { get; set; }

    public virtual Dodatki DohDod { get; set; } = null!;

    public virtual TypWyplatum DohTwp { get; set; } = null!;
}
