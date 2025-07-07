using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ZlecWewElem
{
    public int ZweId { get; set; }

    public int? ZweZwnid { get; set; }

    public int? ZweTimeStamp { get; set; }

    public int? ZweStanId { get; set; }

    public short? ZweOpeTyp { get; set; }

    public int? ZweOpeFirma { get; set; }

    public int? ZweOpeNumer { get; set; }

    public short? ZweOpeLp { get; set; }

    public string? ZwePowod { get; set; }

    public virtual OpeKarty? ZweOpeNumerNavigation { get; set; }

    public virtual ZlecWewNag? ZweZwn { get; set; }
}
