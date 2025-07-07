using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class EwidDodElem
{
    public int EdeEdeid { get; set; }

    public int EdeEdnid { get; set; }

    public int? EdeKatId { get; set; }

    public decimal EdeKwota { get; set; }

    public byte EdeKolumnaKpr { get; set; }

    public byte EdeKolumnaRyc { get; set; }

    public string? EdeKontoWn { get; set; }

    public string? EdeKontoMa { get; set; }

    public virtual EwidDodNag EdeEdn { get; set; } = null!;

    public virtual Kategorie? EdeKat { get; set; }
}
