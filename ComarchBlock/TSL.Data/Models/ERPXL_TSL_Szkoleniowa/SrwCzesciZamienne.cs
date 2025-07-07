using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SrwCzesciZamienne
{
    public int SczId { get; set; }

    public int? SczTwrId { get; set; }

    public short? SczTwrTyp { get; set; }

    public int? SczSruId { get; set; }

    public string? SczOpis { get; set; }

    public virtual SrwUrzadzenium? SczSru { get; set; }

    public virtual TwrKarty? SczTwr { get; set; }
}
