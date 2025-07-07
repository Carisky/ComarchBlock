using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class BankiDefinicjeOperacje
{
    public int BdoId { get; set; }

    public int? BdoFirmaId { get; set; }

    public int? BdoLp { get; set; }

    public int? BdoBankDefId { get; set; }

    public int? BdoKaonumer { get; set; }

    public string? BdoNazwa { get; set; }

    public string? BdoFiltrSql { get; set; }

    public string? BdoFiltrSym { get; set; }

    public virtual BankiDefinicje? BdoBankDef { get; set; }
}
