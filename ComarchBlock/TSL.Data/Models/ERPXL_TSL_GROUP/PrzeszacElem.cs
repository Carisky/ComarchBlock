using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PrzeszacElem
{
    public short PseGidtyp { get; set; }

    public int? PseGidfirma { get; set; }

    public int PseGidnumer { get; set; }

    public short PseGidlp { get; set; }

    public int? PseOkres { get; set; }

    public string? PseKontoZrd { get; set; }

    public short? PseDzktyp { get; set; }

    public int? PseDzkfirma { get; set; }

    public int? PseDzknumer { get; set; }

    public short? PseDzklp { get; set; }

    public string? PseKontoDebet { get; set; }

    public string? PseKontoCredit { get; set; }

    public decimal? PseKwota { get; set; }

    public string? PseDokumentZrodlowy { get; set; }

    public virtual PrzeszacNag PseGidnumerNavigation { get; set; } = null!;
}
