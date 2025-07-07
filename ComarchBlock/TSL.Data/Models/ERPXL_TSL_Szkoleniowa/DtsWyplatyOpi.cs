using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class DtsWyplatyOpi
{
    public int DwoId { get; set; }

    public int? DwoDwpId { get; set; }

    public int? DwoLokId { get; set; }

    public string? DwoLokKod { get; set; }

    public int? DwoDzlId { get; set; }

    public string? DwoDzlKod { get; set; }

    public int? DwoPrjId { get; set; }

    public string? DwoPrjKod { get; set; }

    public decimal? DwoProcent { get; set; }

    public decimal? DwoBrutto { get; set; }

    public decimal? DwoZusf { get; set; }

    public decimal? DwoZusp { get; set; }

    public decimal? DwoZdrow { get; set; }

    public decimal? DwoZalFis { get; set; }

    public decimal? DwoNetto { get; set; }

    public decimal? DwoPpkp { get; set; }

    public decimal? DwoPpkf { get; set; }

    public virtual DtsWyplaty? DwoDwp { get; set; }
}
