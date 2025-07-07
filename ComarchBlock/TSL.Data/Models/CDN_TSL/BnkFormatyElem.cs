using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class BnkFormatyElem
{
    public int BfeBfeid { get; set; }

    public int? BfeBfnid { get; set; }

    public short BfePoziom { get; set; }

    public short BfeLp { get; set; }

    public short? BfeRodzaj { get; set; }

    public short? BfeTyp { get; set; }

    public string? BfeWartosc { get; set; }

    public short? BfeLaczZpoprzednim { get; set; }

    public short? BfeSzerokosc { get; set; }

    public short? BfeFormatRachunku { get; set; }

    public short? BfeWymagane { get; set; }

    public virtual BnkFormatyNag? BfeBfn { get; set; }
}
