using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class FormBanElem
{
    public int FbeId { get; set; }

    public int? FbeFbnid { get; set; }

    public byte? FbeRecNag { get; set; }

    public int? FbeNumer { get; set; }

    public int? FbeRodzaj { get; set; }

    public string? FbeWartosc { get; set; }

    public short? FbeTyp { get; set; }

    public byte? FbeLaczZpoprzednim { get; set; }

    public short? FbeSzerokosc { get; set; }

    public byte? FbeFormatRachunku { get; set; }

    public byte? FbeUzupelnijZnakiem { get; set; }

    public string? FbeZnakUzup { get; set; }

    public virtual FormBanNag? FbeFbn { get; set; }

    public virtual ICollection<FormBanKryt> FormBanKryts { get; set; } = new List<FormBanKryt>();
}
