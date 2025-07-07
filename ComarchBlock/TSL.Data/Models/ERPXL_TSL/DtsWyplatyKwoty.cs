using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DtsWyplatyKwoty
{
    public int DwkId { get; set; }

    public int? DwkDwpId { get; set; }

    public short? DwkRodzaj { get; set; }

    public short? DwkKategoria { get; set; }

    public short? DwkRodzajFis { get; set; }

    public short? DwkKosztFirma { get; set; }

    public int? DwkUbztyuId { get; set; }

    public decimal? DwkKwota { get; set; }

    public virtual DtsWyplaty? DwkDwp { get; set; }
}
