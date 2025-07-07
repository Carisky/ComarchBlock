using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SzDekElem
{
    public int SdeSdeid { get; set; }

    public int SdeSzDid { get; set; }

    public short SdeLp { get; set; }

    public int? SdeKatId { get; set; }

    public string SdeOpis { get; set; } = null!;

    public int? SdeKat2Id { get; set; }

    public string? SdeOpis2 { get; set; }

    public byte SdeKategoria { get; set; }

    public string SdeKontoWn { get; set; } = null!;

    public string SdeKontoMa { get; set; } = null!;

    public int? SdeRozrachunki { get; set; }

    public virtual SzDekNag SdeSzD { get; set; } = null!;
}
