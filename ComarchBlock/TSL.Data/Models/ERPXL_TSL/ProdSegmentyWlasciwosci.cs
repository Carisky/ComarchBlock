using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdSegmentyWlasciwosci
{
    public int PsgwId { get; set; }

    public int? PsgwPsgid { get; set; }

    public byte? PsgwObiTyp { get; set; }

    public int? PsgwObiNumer { get; set; }

    public int? PsgwSeparatorPo { get; set; }

    public int? PsgwSeparatorW { get; set; }

    public byte? PsgwIloscZnakow { get; set; }

    public byte? PsgwWspolnySeparatorDlaElem { get; set; }

    public int? PsgwSeparatorDlaElem { get; set; }

    public int? PsgwDataWaznosci { get; set; }

    public byte? PsgwDataWaznosciJedn { get; set; }

    public string? PsgwSql { get; set; }

    public int? PsgwLp { get; set; }
}
