using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraFakZaliczkowe
{
    public int TrZTrZid { get; set; }

    public int TrZTrNid { get; set; }

    public int TrZFzid { get; set; }

    public decimal TrZStawka { get; set; }

    public short TrZFlaga { get; set; }

    public decimal TrZZrodlowa { get; set; }

    public decimal TrZKwotaBrutto { get; set; }

    public decimal TrZKwotaBruttoSys { get; set; }

    public decimal TrZKwotaBruttoMax { get; set; }

    public decimal TrZKwotaBruttoSysMax { get; set; }

    public decimal TrZKwotaNetto { get; set; }

    public decimal TrZKwotaNettoSys { get; set; }

    public decimal TrZKwotaNettoMax { get; set; }

    public decimal TrZKwotaNettoSysMax { get; set; }

    public decimal TrZKwotaVat { get; set; }

    public decimal TrZKwotaVatsys { get; set; }

    public decimal TrZKwotaVatmax { get; set; }

    public decimal TrZKwotaVatsysMax { get; set; }

    public byte TrZTyp { get; set; }

    public string TrZWaluta { get; set; } = null!;

    public string TrZNumerPelny { get; set; } = null!;

    public byte TrZUwzgledniac { get; set; }

    public virtual TraNag TrZTrN { get; set; } = null!;
}
