using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwUrzadzenium
{
    public int SrUId { get; set; }

    public int? SrUSurid { get; set; }

    public short? SrUObiTyp { get; set; }

    public int? SrUObiNumer { get; set; }

    public string? SrUKod { get; set; }

    public string? SrUNazwa { get; set; }

    public short? SrUDokTyp { get; set; }

    public int? SrUDokNumer { get; set; }

    public short? SrUDokLp { get; set; }

    public string? SrUOpis { get; set; }

    public byte? SrUArchiwalne { get; set; }

    public decimal? SrUPrzebieg { get; set; }

    public int? SrUJednostkaPrzebiegu { get; set; }

    public byte? SrUDostepnyWmobile { get; set; }

    public int? SrUZewnetrznySys { get; set; }

    public int? SrUZewnetrznyId { get; set; }

    public int? SrUNadrzedny { get; set; }

    public string? SrUNumer { get; set; }

    public virtual ICollection<SrwCzesciZamienne> SrwCzesciZamiennes { get; set; } = new List<SrwCzesciZamienne>();

    public virtual ICollection<SrwUrzTypyP> SrwUrzTypyPs { get; set; } = new List<SrwUrzTypyP>();

    public virtual ICollection<SrwUrzWlasc> SrwUrzWlascs { get; set; } = new List<SrwUrzWlasc>();
}
