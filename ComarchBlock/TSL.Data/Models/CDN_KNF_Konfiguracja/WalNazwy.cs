using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WalNazwy
{
    public int WnaWnaId { get; set; }

    public string WnaSymbol { get; set; } = null!;

    public string WnaNazwa { get; set; } = null!;

    public string WnaKraj { get; set; } = null!;

    public string WnaSlownie1 { get; set; } = null!;

    public string WnaSlownie2 { get; set; } = null!;

    public decimal WnaParytet { get; set; }

    public string WnaKontoWn { get; set; } = null!;

    public string WnaKontoMa { get; set; } = null!;

    public short WnaNieaktualizowana { get; set; }

    public DateTime? WnaTsExport { get; set; }

    public int? WnaOpeZalId { get; set; }

    public int? WnaStaZalId { get; set; }

    public DateTime WnaTsZal { get; set; }

    public int? WnaOpeModId { get; set; }

    public int? WnaStaModId { get; set; }

    public DateTime WnaTsMod { get; set; }

    public string WnaOpeModKod { get; set; } = null!;

    public string WnaOpeModNazwisko { get; set; } = null!;

    public string WnaOpeZalKod { get; set; } = null!;

    public string WnaOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<WalNotowanium> WalNotowania { get; set; } = new List<WalNotowanium>();
}
