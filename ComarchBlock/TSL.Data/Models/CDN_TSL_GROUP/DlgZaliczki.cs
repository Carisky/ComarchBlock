using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DlgZaliczki
{
    public int DlzDlzid { get; set; }

    public int DlzDleid { get; set; }

    public int? DlzTyp { get; set; }

    public int? DlzBzpId { get; set; }

    public int? DlzFplId { get; set; }

    public string? DlzDokument { get; set; }

    public DateTime? DlzDataDok { get; set; }

    public DateTime? DlzDataKur { get; set; }

    public DateTime? DlzData { get; set; }

    public string? DlzWaluta { get; set; }

    public int? DlzKursNumer { get; set; }

    public decimal? DlzKursL { get; set; }

    public decimal? DlzKursM { get; set; }

    public decimal? DlzKwotaSys { get; set; }

    public decimal? DlzKwotaWal { get; set; }

    public decimal? DlzKwotaRozliczenia { get; set; }

    public int DlzZrodlo { get; set; }

    public virtual DlgElem DlzDle { get; set; } = null!;
}
