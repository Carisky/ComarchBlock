using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Odsetki
{
    public short OdsGidtyp { get; set; }

    public int? OdsGidfirma { get; set; }

    public int OdsGidnumer { get; set; }

    public short OdsGidlp { get; set; }

    public int? OdsDataO { get; set; }

    public decimal? OdsProcOds { get; set; }

    public int? OdsTstamp { get; set; }

    public byte OdsTypOdsetek { get; set; }

    public int OdsSlwTypOdsetek { get; set; }
}
