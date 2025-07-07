using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class CfgWartosci
{
    public int CfwCfwId { get; set; }

    public int CfwCfkId { get; set; }

    public string CfwNazwa { get; set; } = null!;

    public byte CfwTyp { get; set; }

    public string CfwWartosc { get; set; } = null!;

    public int? CfwOpeZalId { get; set; }

    public int? CfwStaZalId { get; set; }

    public DateTime? CfwTsZal { get; set; }

    public int? CfwOpeModId { get; set; }

    public int? CfwStaModId { get; set; }

    public DateTime? CfwTsMod { get; set; }

    public string CfwOpeModKod { get; set; } = null!;

    public string CfwOpeModNazwisko { get; set; } = null!;

    public string CfwOpeZalKod { get; set; } = null!;

    public string CfwOpeZalNazwisko { get; set; } = null!;

    public virtual CfgKlucze CfwCfk { get; set; } = null!;
}
