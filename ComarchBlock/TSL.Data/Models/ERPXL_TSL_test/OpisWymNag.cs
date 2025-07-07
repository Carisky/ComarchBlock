using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class OpisWymNag
{
    public short OwnGidtyp { get; set; }

    public int? OwnGidfirma { get; set; }

    public int OwnGidnumer { get; set; }

    public short? OwnGidlp { get; set; }

    public string? OwnOpis { get; set; }

    public byte? OwnZatwierdzono { get; set; }

    public int? OwnTstampAkt { get; set; }

    public short? OwnOpeTypA { get; set; }

    public int? OwnOpeFirmaA { get; set; }

    public int? OwnOpeNumerA { get; set; }

    public short? OwnOpeLpA { get; set; }

    public int? OwnTstampZatw { get; set; }

    public short? OwnOpeTypZ { get; set; }

    public int? OwnOpeFirmaZ { get; set; }

    public int? OwnOpeNumerZ { get; set; }

    public short? OwnOpeLpZ { get; set; }

    public byte? OwnKategoria { get; set; }

    public short? OwnDataControllingowa { get; set; }

    public byte? OwnDataKsiegowania { get; set; }

    public int? OwnIloscElementow { get; set; }

    public int? OwnOwWid { get; set; }

    public virtual ICollection<OpisWymElem> OpisWymElems { get; set; } = new List<OpisWymElem>();
}
