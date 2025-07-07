using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ReklElem
{
    public int RleId { get; set; }

    public int? RleRlnid { get; set; }

    public short? RlePozycja { get; set; }

    public short? RleZrdTyp { get; set; }

    public int? RleZrdNumer { get; set; }

    public short? RleZrdLp { get; set; }

    public string? RleDokNumer { get; set; }

    public string? RleZrdDokumentObcy { get; set; }

    public short? RleTwrTyp { get; set; }

    public int? RleTwrNumer { get; set; }

    public string? RleTwrNazwa { get; set; }

    public string? RleTwrKod { get; set; }

    public short? RleTypTwr { get; set; }

    public decimal? RleIlosc { get; set; }

    public byte? RleJmFormat { get; set; }

    public int? RleZadanie { get; set; }

    public byte? RleStatus { get; set; }

    public string? RleOpis { get; set; }

    public string? RlePrzyczyna { get; set; }

    public string? RleRozpatrzenie { get; set; }

    public int? RleMagNumer { get; set; }

    public int? RleOddElemId { get; set; }

    public int? RlePobid { get; set; }

    public int? RleSrtId { get; set; }

    public virtual ICollection<ReklRealizacja> ReklRealizacjas { get; set; } = new List<ReklRealizacja>();

    public virtual ICollection<ReklSelem> ReklSelems { get; set; } = new List<ReklSelem>();

    public virtual ReklNag? RleRln { get; set; }
}
