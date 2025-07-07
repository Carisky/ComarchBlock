using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ZestKsnag
{
    public short? ZknGidtyp { get; set; }

    public int? ZknGidfirma { get; set; }

    public int ZknGidnumer { get; set; }

    public short? ZknGidlp { get; set; }

    public string? ZknNazwa { get; set; }

    public string? ZknOpis { get; set; }

    public string? ZknNumeracja { get; set; }

    public byte? ZknJednostka { get; set; }

    public short? ZknCoile { get; set; }

    public byte? ZknAuto { get; set; }

    public byte? ZknBufor { get; set; }

    public short? ZknRodzaj { get; set; }

    public byte? ZknControlling { get; set; }

    public byte? ZknArchiwalny { get; set; }

    public byte? ZknPominKksarchiwalne { get; set; }

    public int? ZknDfnid { get; set; }

    public byte? ZknDfnkwotaWmr { get; set; }

    public byte? ZknSfeksport { get; set; }

    public byte? ZknSfnjednostka { get; set; }

    public byte? ZknSfnzestawienie { get; set; }

    public int? ZknSfnid { get; set; }

    public virtual ICollection<ZestKselem> ZestKselems { get; set; } = new List<ZestKselem>();
}
