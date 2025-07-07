using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ObiektyDomyslne
{
    public short ObDObiTyp { get; set; }

    public int? ObDObiFirma { get; set; }

    public int ObDObiNumer { get; set; }

    public short ObDObiLp { get; set; }

    public byte ObDKontekstDomyslnego { get; set; }

    public int? ObDCzasModyfikacji { get; set; }

    public int? ObDOpeModyfikujacy { get; set; }

    public int? ObDCzasDodania { get; set; }

    public int? ObDOpeDodajacy { get; set; }

    public short? ObDDomTyp { get; set; }

    public int? ObDDomFirma { get; set; }

    public int? ObDDomNumer { get; set; }

    public short? ObDDomLp { get; set; }
}
