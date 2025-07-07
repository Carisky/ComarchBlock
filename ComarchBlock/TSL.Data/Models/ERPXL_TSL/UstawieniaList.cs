using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class UstawieniaList
{
    public int UltProcedura { get; set; }

    public int UltIdkontrolki { get; set; }

    public int UltIdoperatora { get; set; }

    public byte? UltAktywna { get; set; }

    public byte? UltWysWierszy { get; set; }

    public string? UltKrojCzcionki { get; set; }

    public byte? UltRozmiarCzcionki { get; set; }

    public int? UltKolor1 { get; set; }

    public int? UltKolor2 { get; set; }

    public byte? UltPominDodatkoweKol { get; set; }

    public virtual OpeKarty UltIdoperatoraNavigation { get; set; } = null!;
}
