using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WalNotowanium
{
    public int WnoWnoId { get; set; }

    public int? WnoWnaId { get; set; }

    public int? WnoWkuId { get; set; }

    public DateTime WnoTstamp { get; set; }

    public decimal WnoKursL { get; set; }

    public decimal WnoKursM { get; set; }

    public DateTime? WnoTsExport { get; set; }

    public byte WnoAutomatycznie { get; set; }

    public string WnoNrTabeli { get; set; } = null!;

    public DateTime? WnoPublikacja { get; set; }

    public int? WnoOpeZalId { get; set; }

    public int? WnoStaZalId { get; set; }

    public DateTime WnoTsZal { get; set; }

    public int? WnoOpeModId { get; set; }

    public int? WnoStaModId { get; set; }

    public DateTime WnoTsMod { get; set; }

    public string WnoOpeModKod { get; set; } = null!;

    public string WnoOpeModNazwisko { get; set; } = null!;

    public string WnoOpeZalKod { get; set; } = null!;

    public string WnoOpeZalNazwisko { get; set; } = null!;

    public virtual WalKursy? WnoWku { get; set; }

    public virtual WalNazwy? WnoWna { get; set; }
}
