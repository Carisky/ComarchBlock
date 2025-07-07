using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class FrmObiekty
{
    public int FroFrmid { get; set; }

    public short FroGidtyp { get; set; }

    public int? FroGidfirma { get; set; }

    public int FroGidnumer { get; set; }

    public short FroGidlp { get; set; }

    public short? FroGid2typ { get; set; }

    public int? FroGid2firma { get; set; }

    public int? FroGid2numer { get; set; }

    public short? FroGid2lp { get; set; }

    public int? FroMagProdId { get; set; }

    public short? FroKnPtyp { get; set; }

    public int? FroKnPnumer { get; set; }

    public byte? FroDlaDetalu { get; set; }

    public short? FroGid3typ { get; set; }

    public int? FroGid3numer { get; set; }

    public byte? FroAutonomiczna { get; set; }

    public byte? FroNiedostepnaNaDok { get; set; }

    public virtual FrmStruktura FroFrm { get; set; } = null!;
}
