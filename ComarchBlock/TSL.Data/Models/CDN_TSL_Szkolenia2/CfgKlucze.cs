using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class CfgKlucze
{
    public int CfkCfkId { get; set; }

    public int CfkParentId { get; set; }

    public string CfkNazwa { get; set; } = null!;

    public DateTime CfkOkresOd { get; set; }

    public DateTime CfkOkresDo { get; set; }

    public int? CfkOpeZalId { get; set; }

    public int? CfkStaZalId { get; set; }

    public DateTime? CfkTsZal { get; set; }

    public int? CfkOpeModId { get; set; }

    public int? CfkStaModId { get; set; }

    public DateTime? CfkTsMod { get; set; }

    public string CfkOpeModKod { get; set; } = null!;

    public string CfkOpeModNazwisko { get; set; } = null!;

    public string CfkOpeZalKod { get; set; } = null!;

    public string CfkOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<CfgWartosci> CfgWartoscis { get; set; } = new List<CfgWartosci>();

    public virtual CfgKlucze CfkParent { get; set; } = null!;

    public virtual ICollection<CfgKlucze> InverseCfkParent { get; set; } = new List<CfgKlucze>();
}
