using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Atrybuty
{
    public long AtrId { get; set; }

    public short? AtrObiTyp { get; set; }

    public int? AtrObiFirma { get; set; }

    public int? AtrObiNumer { get; set; }

    public short? AtrObiLp { get; set; }

    public short? AtrObiSubLp { get; set; }

    public int? AtrAtkId { get; set; }

    public string? AtrWartosc { get; set; }

    public short? AtrAtrTyp { get; set; }

    public int? AtrAtrFirma { get; set; }

    public int? AtrAtrNumer { get; set; }

    public short? AtrAtrLp { get; set; }

    public short? AtrAtrSubLp { get; set; }

    public int? AtrOptimaId { get; set; }

    public byte? AtrGrupujacy { get; set; }

    public int? AtrPozycja { get; set; }

    public string? AtrGuid { get; set; }

    public int? AtrLastMod { get; set; }

    public virtual AtrybutyKlasy? AtrAtk { get; set; }
}
