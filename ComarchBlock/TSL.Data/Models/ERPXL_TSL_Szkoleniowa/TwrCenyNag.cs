using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TwrCenyNag
{
    public int TcnId { get; set; }

    public int? TcnRodzajCeny { get; set; }

    public string? TcnNazwa { get; set; }

    public int? TcnDataOd { get; set; }

    public byte? TcnStan { get; set; }

    public int? TcnAktywny { get; set; }

    public int? TcnDataUtworzenia { get; set; }

    public short? TcnOpeWtyp { get; set; }

    public int? TcnOpeWnumer { get; set; }

    public short? TcnOpeMtyp { get; set; }

    public int? TcnOpeMnumer { get; set; }

    public short? TcnOpeZtyp { get; set; }

    public int? TcnOpeZnumer { get; set; }

    public int? TcnTcnid { get; set; }

    public string? TcnWalutaCenySprzedazy { get; set; }

    public short? TcnNrKursu { get; set; }

    public decimal? TcnMarza { get; set; }

    public decimal? TcnZaok { get; set; }

    public decimal? TcnOffset { get; set; }

    public byte? TcnRodzajPodstawy { get; set; }

    public byte? TcnMarzaNarzutOpcja { get; set; }

    public byte? TcnAktualizacja { get; set; }

    public short? TcnKntTyp { get; set; }

    public int? TcnKntFirma { get; set; }

    public int? TcnKntNumer { get; set; }

    public short? TcnKntLp { get; set; }

    public decimal? TcnZmianaProc { get; set; }

    public string? TcnOpis { get; set; }

    public int? TcnCzasModyfikacji { get; set; }

    public byte? TcnWsk { get; set; }
}
