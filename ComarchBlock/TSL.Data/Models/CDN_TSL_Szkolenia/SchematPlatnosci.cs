using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class SchematPlatnosci
{
    public int SplSplId { get; set; }

    public short? SplPodmiotTyp { get; set; }

    public int SplPodmiotId { get; set; }

    public short? SplOdbPodmiotTyp { get; set; }

    public int? SplOdbPodmiotId { get; set; }

    public int? SplFplId { get; set; }

    public int? SplBnaId { get; set; }

    public short SplRodzaj { get; set; }

    public decimal SplKwota { get; set; }

    public decimal SplProcent { get; set; }

    public string SplRachunekNr { get; set; } = null!;

    public string? SplRachunekNr0 { get; set; }

    public byte SplIban { get; set; }

    public int SplLiczbaPorz { get; set; }

    public byte SplReszta { get; set; }

    public string SplWaluta { get; set; } = null!;

    public byte SplPpk { get; set; }

    public string? SplOpis { get; set; }

    public int? SplOpeZalId { get; set; }

    public int? SplStaZalId { get; set; }

    public DateTime SplTsZal { get; set; }

    public int? SplOpeModId { get; set; }

    public int? SplStaModId { get; set; }

    public DateTime SplTsMod { get; set; }

    public string SplOpeModKod { get; set; } = null!;

    public string SplOpeModNazwisko { get; set; } = null!;

    public string SplOpeZalKod { get; set; } = null!;

    public string SplOpeZalNazwisko { get; set; } = null!;

    public string? SplImportRowId { get; set; }

    public virtual BnkNazwy? SplBna { get; set; }

    public virtual FormyPlatnosci? SplFpl { get; set; }
}
