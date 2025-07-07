using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class TypSchemat
{
    public short SctTrntyp { get; set; }

    public short SctPozycja { get; set; }

    public short? SctSchtyp { get; set; }

    public int? SctSchfirma { get; set; }

    public int? SctSchnumer { get; set; }

    public short? SctSchlp { get; set; }

    public virtual Schematy? Schematy { get; set; }
}
