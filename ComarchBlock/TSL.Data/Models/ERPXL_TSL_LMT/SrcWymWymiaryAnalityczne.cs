using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrcWymWymiaryAnalityczne
{
    public string? WymOrgAtkId { get; set; }

    public string? WymOrgId { get; set; }

    public string? WymOrgParId { get; set; }

    public string? WymOrgAtrId { get; set; }

    public string? WymNazwa { get; set; }

    public string? WymOpis { get; set; }

    public string? WymNazwaPoziomu { get; set; }

    public int? WymTyp { get; set; }

    public string? WymKonto { get; set; }

    public int? WymTypWymiaru { get; set; }

    public int? WymAktywny { get; set; }
}
