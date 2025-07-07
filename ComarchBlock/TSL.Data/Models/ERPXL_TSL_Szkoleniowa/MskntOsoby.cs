using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class MskntOsoby
{
    public int MsknSId { get; set; }

    public short? MsknSKntTyp { get; set; }

    public int? MsknSKntFirma { get; set; }

    public int? MsknSKntNumer { get; set; }

    public short? MsknSKntLp { get; set; }

    public byte? MsknSUpowazniona { get; set; }

    public byte? MsknSUpowaznionaZam { get; set; }

    public string? MsknSDzial { get; set; }

    public string? MsknSStanowisko { get; set; }

    public string? MsknSTytul { get; set; }

    public string? MsknSNazwa { get; set; }

    public string? MsknSTelefon { get; set; }

    public string? MsknSEmail { get; set; }

    public string? MsknSHasloChk { get; set; }

    public string? MsknSHasloOsoby { get; set; }

    public string? MsknSNotatki { get; set; }

    public int? MsknSRolaDecyzyjna { get; set; }

    public string? MsknSFax { get; set; }

    public string? MsknSTelefonK { get; set; }

    public short? MsknSUpoDoK { get; set; }

    public byte? MsknSArchiwalny { get; set; }

    public short? MsknSPozycja { get; set; }

    public int? MsknSCzasModyfikacji { get; set; }

    public byte? MsknSCzyDomyslna { get; set; }

    public int? MsknSZewnetrznyId { get; set; }

    public int? MsknSOddzialId { get; set; }

    public int? MsknSAdresId { get; set; }
}
