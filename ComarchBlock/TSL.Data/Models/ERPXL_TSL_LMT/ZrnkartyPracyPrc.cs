using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ZrnkartyPracyPrc
{
    public short? ZrpGidtyp { get; set; }

    public int? ZrpGidfirma { get; set; }

    public int ZrpGidnumer { get; set; }

    public short? ZrpGidlp { get; set; }

    public short? ZrpSubGidlp { get; set; }

    public short? ZrpZrntyp { get; set; }

    public int? ZrpZrnfirma { get; set; }

    public int? ZrpZrnnumer { get; set; }

    public short? ZrpZrnlp { get; set; }

    public short? ZrpPozycja { get; set; }

    public short? ZrpPrctyp { get; set; }

    public int? ZrpPrcfirma { get; set; }

    public int? ZrpPrcnumer { get; set; }

    public short? ZrpPrclp { get; set; }

    public decimal? ZrpCalkowityCzasPracy { get; set; }

    public decimal? ZrpZwykleH { get; set; }

    public decimal? ZrpNadgodziny50 { get; set; }

    public decimal? ZrpNadgodziny100 { get; set; }

    public string? ZrpOpis { get; set; }

    public virtual ZrnkartyPracy? ZrpZrnnumerNavigation { get; set; }
}
