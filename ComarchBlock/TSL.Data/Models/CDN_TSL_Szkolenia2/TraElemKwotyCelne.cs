using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraElemKwotyCelne
{
    public int TkcTkcid { get; set; }

    public int TkcKceId { get; set; }

    public int TkcTrEid { get; set; }

    public string TkcNazwa { get; set; } = null!;

    public decimal TkcWartosc { get; set; }

    public decimal TkcWartoscPln { get; set; }

    public short TkcWplywNaWartoscVat { get; set; }

    public short TkcWplywNaPlatnosc { get; set; }

    public virtual TraElem TkcTrE { get; set; } = null!;
}
