using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class HistoriaZmian
{
    public int HisId { get; set; }

    public short? HisObiTyp { get; set; }

    public int? HisObiNumer { get; set; }

    public int? HisObiLp1 { get; set; }

    public int? HisObiLp2 { get; set; }

    public int? HisObiLp3 { get; set; }

    public string? HisObiNazwa { get; set; }

    public int? HisCzasZmian { get; set; }

    public short? HisTabelaId { get; set; }

    public int? HisCzasZmianDb { get; set; }

    public string? HisOpeIdent { get; set; }

    public byte? HisTypZmiany { get; set; }

    public string? HisKolumna { get; set; }

    public string? HisStaraWartosc { get; set; }

    public string? HisNowaWartosc { get; set; }
}
