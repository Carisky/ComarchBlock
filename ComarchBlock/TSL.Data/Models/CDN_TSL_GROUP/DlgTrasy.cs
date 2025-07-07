using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DlgTrasy
{
    public int DltDltid { get; set; }

    public int DltDleid { get; set; }

    public int? DltDldid { get; set; }

    public string? DltMiejsceOdjazdu { get; set; }

    public DateTime? DltDataOdjazdu { get; set; }

    public DateTime? DltGodzinaOdjazdu { get; set; }

    public string? DltMiejscePrzyjazdu { get; set; }

    public DateTime? DltDataPrzyjazdu { get; set; }

    public DateTime? DltGodzinaPrzyjazdu { get; set; }

    public string? DltSrodekLokomocji { get; set; }

    public decimal? DltKwotaSys { get; set; }

    public decimal? DltKwotaWal { get; set; }

    public short DltWyjazd { get; set; }

    public int DltZrodlo { get; set; }

    public virtual DlgElem DltDle { get; set; } = null!;
}
