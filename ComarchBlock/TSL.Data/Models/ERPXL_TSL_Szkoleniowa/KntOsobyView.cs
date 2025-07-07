using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KntOsobyView
{
    public int? KnSvKntNumer { get; set; }

    public short? KnSvKntLp { get; set; }

    public int? KnSvZewnetrznyId { get; set; }

    public int KnSvZrodlo { get; set; }

    public long? KnSvPozycja { get; set; }

    public string? KnSvNazwa { get; set; }

    public string? KnSvStanowisko { get; set; }

    public string? KnSvEmail { get; set; }

    public string? KnSvTelefon { get; set; }

    public string? KnSvTelefonK { get; set; }

    public byte? KnSvArchiwalny { get; set; }

    public short? KnSvKntTyp { get; set; }

    public int? KnSvAdresId { get; set; }
}
