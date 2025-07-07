using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ObiektyLinki
{
    public int OblId { get; set; }

    public short OblLp { get; set; }

    public short? OblGid1typ { get; set; }

    public int? OblGid1firma { get; set; }

    public int? OblGid1numer { get; set; }

    public short? OblGid1lp { get; set; }

    public int? OblGid1subLp { get; set; }

    public short? OblGid2typ { get; set; }

    public int? OblGid2firma { get; set; }

    public int? OblGid2numer { get; set; }

    public short? OblGid2lp { get; set; }

    public int? OblGid2subLp { get; set; }

    public short? OblOpeTyp { get; set; }

    public int? OblOpeFirma { get; set; }

    public int? OblOpeNumer { get; set; }

    public short? OblOpeLp { get; set; }

    public int? OblObltstamp { get; set; }

    public string? OblOpis { get; set; }
}
