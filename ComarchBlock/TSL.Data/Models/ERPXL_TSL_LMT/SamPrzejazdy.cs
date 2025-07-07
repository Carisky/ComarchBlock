using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SamPrzejazdy
{
    public int SaPId { get; set; }

    public int? SaPPrzejazdNumer { get; set; }

    public short? SaPPrzejazdRok { get; set; }

    public int? SaPDataWyjazdu { get; set; }

    public int? SaPDataPrzyjazdu { get; set; }

    public decimal? SaPOdleglosc { get; set; }

    public int? SaPSamId { get; set; }

    public string? SaPNrRej { get; set; }

    public short? SaPKierTyp { get; set; }

    public int? SaPKierNumer { get; set; }

    public int? SaPRodzajPrzejazdu { get; set; }

    public int? SaPSrodekTransportu { get; set; }

    public int? SaPTypWydatku { get; set; }

    public decimal? SaPKwota { get; set; }

    public int? SaPOpeNumer { get; set; }

    public int? SaPPrcNumer { get; set; }

    public int? SaPDataZapisu { get; set; }

    public byte? SaPPotwierdzony { get; set; }

    public int? SaPOpeNumerZ { get; set; }

    public int? SaPDataPotwierdzenia { get; set; }

    public short? SaPZrdTyp { get; set; }

    public int? SaPZrdNumer { get; set; }

    public short? SaPZrdLp { get; set; }

    public string? SaPWyjazdZ { get; set; }

    public string? SaPPrzyjazdDo { get; set; }

    public decimal? SaPLicznikPocz { get; set; }

    public decimal? SaPLicznikKon { get; set; }

    public string? SaPOpis { get; set; }

    public decimal? SaPPrzyjazdGpssz { get; set; }

    public decimal? SaPPrzyjazdGpsdl { get; set; }

    public int? SaPPrzyjazdGpsdataPobrania { get; set; }

    public int? SaPPrzyjazdGpsgodzinaPobrania { get; set; }

    public int? SaPDgenumer { get; set; }

    public short? SaPDgelp { get; set; }
}
