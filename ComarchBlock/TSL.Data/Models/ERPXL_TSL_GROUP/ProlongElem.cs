using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProlongElem
{
    public int PrlePrlnId { get; set; }

    public int PrleLp { get; set; }

    public decimal? PrleKwota { get; set; }

    public string? PrleWaluta { get; set; }

    public short? PrleZrdTyp { get; set; }

    public int? PrleZrdFirma { get; set; }

    public int? PrleZrdNumer { get; set; }

    public short? PrleZrdLp { get; set; }

    public int? PrleTermin { get; set; }

    public int? PrleTerminNowy { get; set; }

    public int? PrleTerminSpodziewalny { get; set; }

    public int? PrleTerminMaksymalny { get; set; }

    public byte? PrleFormaNr { get; set; }

    public string? PrleFormaNazwa { get; set; }

    public string? PrleNotatka { get; set; }

    public decimal? PrleKwotaOdsetki { get; set; }

    public decimal? PrleStopaProcentowa { get; set; }

    public int? PrleDniZwloki { get; set; }

    public short? PrleKartyp { get; set; }

    public int? PrleKarfirma { get; set; }

    public int? PrleKarnumer { get; set; }

    public short? PrleKarlp { get; set; }

    public string? PrleWalutaOdsetki { get; set; }

    public short? PrleNrKursuOdsetki { get; set; }

    public decimal? PrleKursModsetki { get; set; }

    public decimal? PrleKursLodsetki { get; set; }

    public virtual ProlongNag PrlePrln { get; set; } = null!;
}
