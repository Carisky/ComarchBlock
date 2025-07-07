using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class CrmraportyKolumny
{
    public int CrkId { get; set; }

    public int? CrkCrdid { get; set; }

    public int? CrkAtKid { get; set; }

    public short? CrkPozycja { get; set; }

    public byte? CrkWymagana { get; set; }

    public virtual AtrybutyKlasy? CrkAtK { get; set; }

    public virtual CrmraportyDef? CrkCrd { get; set; }
}
