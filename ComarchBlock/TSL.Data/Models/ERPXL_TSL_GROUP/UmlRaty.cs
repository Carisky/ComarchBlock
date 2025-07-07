using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class UmlRaty
{
    public int UlrId { get; set; }

    public int? UlrUlnid { get; set; }

    public short? UlrUlplp { get; set; }

    public short? UlrNumer { get; set; }

    public int? UlrTermin { get; set; }

    public decimal? UlrNetto { get; set; }

    public decimal? UlrKapital { get; set; }

    public decimal? UlrOdsetki { get; set; }

    public byte? UlrAneks { get; set; }

    public string? UlrWaluta { get; set; }

    public short? UlrNrKursu { get; set; }

    public decimal? UlrKursM { get; set; }

    public decimal? UlrKursL { get; set; }

    public decimal? UlrNettoSys { get; set; }

    public decimal? UlrKapitalSys { get; set; }

    public decimal? UlrOdsetkiSys { get; set; }

    public decimal? UlrIrr { get; set; }

    public virtual UmlNag? UlrUln { get; set; }
}
