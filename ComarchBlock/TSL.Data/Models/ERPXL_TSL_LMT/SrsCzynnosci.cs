using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrsCzynnosci
{
    public short SsCGidtyp { get; set; }

    public int? SsCGidfirma { get; set; }

    public int SsCGidnumer { get; set; }

    public short? SsCGidlp { get; set; }

    public short SsCGrotyp { get; set; }

    public int? SsCGrofirma { get; set; }

    public int SsCGronumer { get; set; }

    public short? SsCGrolp { get; set; }

    public int? SsCId { get; set; }

    public string? SsCKod { get; set; }

    public short? SsCTwrTyp { get; set; }

    public int? SsCTwrFirma { get; set; }

    public int? SsCTwrNumer { get; set; }

    public short? SsCTwrLp { get; set; }

    public virtual ICollection<SrsCennikCzynnosci> SrsCennikCzynnoscis { get; set; } = new List<SrsCennikCzynnosci>();
}
