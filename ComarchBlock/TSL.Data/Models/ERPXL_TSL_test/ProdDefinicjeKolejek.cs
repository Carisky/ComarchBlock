using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdDefinicjeKolejek
{
    public int PdkId { get; set; }

    public string? PdkKod { get; set; }

    public string? PdkNazwa { get; set; }

    public string? PdkSql { get; set; }

    public byte? PdkArchiwalny { get; set; }

    public int? PdkOpDnumer { get; set; }

    public int? PdkDataDodania { get; set; }

    public int? PdkOpmnumer { get; set; }

    public int? PdkDataModyfikacji { get; set; }

    public byte? PdkDomyslna { get; set; }

    public byte? PdkDefinicjaDla { get; set; }
}
