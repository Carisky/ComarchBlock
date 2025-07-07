using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WalKursy
{
    public int WkuWkuId { get; set; }

    public string WkuSymbol { get; set; } = null!;

    public string WkuNazwa { get; set; } = null!;

    public string WkuUrl { get; set; } = null!;

    public short WkuNieAktywny { get; set; }

    public DateTime? WkuTsExport { get; set; }

    public int? WkuOpeZalId { get; set; }

    public int? WkuStaZalId { get; set; }

    public DateTime WkuTsZal { get; set; }

    public int? WkuOpeModId { get; set; }

    public int? WkuStaModId { get; set; }

    public DateTime WkuTsMod { get; set; }

    public string WkuOpeModKod { get; set; } = null!;

    public string WkuOpeModNazwisko { get; set; } = null!;

    public string WkuOpeZalKod { get; set; } = null!;

    public string WkuOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<WalNotowanium> WalNotowania { get; set; } = new List<WalNotowanium>();
}
