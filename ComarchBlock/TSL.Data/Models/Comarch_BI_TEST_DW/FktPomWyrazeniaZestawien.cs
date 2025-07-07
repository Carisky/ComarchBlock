using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPomWyrazeniaZestawien
{
    public long ZstwId { get; set; }

    public string ZstwOrgId { get; set; } = null!;

    public string? ZstwDirtyOrgId { get; set; }

    public string? ZstwParOrgId { get; set; }

    public string? ZstwDirtyParOrgId { get; set; }

    public int ZstwZrodgid { get; set; }

    public int ZstwZstId { get; set; }

    public string ZstwZstOrgId { get; set; } = null!;

    public int? ZstwTyp { get; set; }

    public int ZstwPoziom { get; set; }

    public string? ZstwWyrazenie { get; set; }

    public decimal ZstwMnoznik { get; set; }

    public decimal ZstwDodajnik { get; set; }

    public string ZstwOperator { get; set; } = null!;

    public int ZstwZnak { get; set; }

    public string? ZstwLisc { get; set; }

    public int ZstwKolejnosc { get; set; }

    public string? ZstwCustomRollup { get; set; }
}
