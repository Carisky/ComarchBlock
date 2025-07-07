using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class BilansOtwarciaSelem
{
    public short BosGidtyp { get; set; }

    public int? BosGidfirma { get; set; }

    public int BosGidnumer { get; set; }

    public short BosGidlp { get; set; }

    public short BosSubGidlp { get; set; }

    public int? BosData { get; set; }

    public int? BosTermin { get; set; }

    public string? BosNumerDokumentu { get; set; }

    public byte? BosDc { get; set; }

    public decimal? BosKwota { get; set; }

    public decimal? BosKwotaBo { get; set; }

    public string? BosWaluta { get; set; }

    public short? BosNrKursu { get; set; }

    public decimal? BosKursL { get; set; }

    public decimal? BosKursM { get; set; }

    public decimal? BosKwotaWal { get; set; }

    public decimal? BosKwotaBowal { get; set; }

    public short? BosTrptyp { get; set; }

    public int? BosTrpfirma { get; set; }

    public int? BosTrpnumer { get; set; }

    public short? BosTrplp { get; set; }

    public short? BosDzktyp { get; set; }

    public int? BosDzkfirma { get; set; }

    public int? BosDzknumer { get; set; }

    public short? BosDzklp { get; set; }

    public virtual BilansOtwarciaElem BilansOtwarciaElem { get; set; } = null!;
}
