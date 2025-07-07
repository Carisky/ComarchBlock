using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class RezerwacjeWprzyszlosc
{
    public int RezPId { get; set; }

    public string? RezPGuid { get; set; }

    public short? RezPTwrTyp { get; set; }

    public int? RezPTwrFirma { get; set; }

    public int? RezPTwrNumer { get; set; }

    public short? RezPTwrLp { get; set; }

    public short? RezPZrdTyp { get; set; }

    public int? RezPZrdFirma { get; set; }

    public int? RezPZrdNumer { get; set; }

    public short? RezPZrdLp { get; set; }

    public short? RezPZrdSubLp { get; set; }

    public short? RezPMagTyp { get; set; }

    public int? RezPMagFirma { get; set; }

    public int? RezPMagNumer { get; set; }

    public short? RezPMagLp { get; set; }

    public int? RezPTpaId { get; set; }

    public decimal? RezPIlosc { get; set; }

    public int? RezPTstamp { get; set; }
}
