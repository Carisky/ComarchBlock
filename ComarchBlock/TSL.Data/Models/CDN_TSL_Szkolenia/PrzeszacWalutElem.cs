using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PrzeszacWalutElem
{
    public int PwePweid { get; set; }

    public int PwePwnid { get; set; }

    public int? PweAccWnId { get; set; }

    public int? PweAccMaId { get; set; }

    public string? PweKontoWn { get; set; }

    public string? PweKontoMa { get; set; }

    public decimal PweKwota { get; set; }

    public decimal PweSaldoWal { get; set; }

    public decimal PweSaldoSys { get; set; }

    public virtual Kontum? PweAccMa { get; set; }

    public virtual Kontum? PweAccWn { get; set; }

    public virtual PrzeszacWalutNag PwePwn { get; set; } = null!;
}
