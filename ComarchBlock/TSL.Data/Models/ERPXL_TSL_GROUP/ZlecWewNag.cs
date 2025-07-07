using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ZlecWewNag
{
    public int ZwnId { get; set; }

    public short? ZwnGidtyp { get; set; }

    public int? ZwnGidfirma { get; set; }

    public int? ZwnGidnumer { get; set; }

    public short? ZwnGidlp { get; set; }

    public int? ZwnMpkzlecId { get; set; }

    public int? ZwnMpkwykId { get; set; }

    public int? ZwnNumer { get; set; }

    public short? ZwnRok { get; set; }

    public string? ZwnTresc { get; set; }

    public decimal? ZwnKoszt { get; set; }

    public int? ZwnStanId { get; set; }

    public int? ZwnDataWyst { get; set; }

    public int? ZwnDataRealizacji { get; set; }

    public int? ZwnDataZamk { get; set; }

    public int? ZwnRokMiesiac { get; set; }

    public string? ZwnCechaOpis { get; set; }

    public virtual ICollection<ZlecWewElem> ZlecWewElems { get; set; } = new List<ZlecWewElem>();
}
