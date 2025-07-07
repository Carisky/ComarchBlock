using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KntOsoby
{
    public short KnSKntTyp { get; set; }

    public int? KnSKntFirma { get; set; }

    public int KnSKntNumer { get; set; }

    public short KnSKntLp { get; set; }

    public byte? KnSUpowazniona { get; set; }

    public byte? KnSUpowaznionaZam { get; set; }

    public string? KnSDzial { get; set; }

    public string? KnSStanowisko { get; set; }

    public string? KnSTytul { get; set; }

    public string? KnSNazwa { get; set; }

    public string? KnSTelefon { get; set; }

    public string? KnSEmail { get; set; }

    public string? KnSHasloChk { get; set; }

    public string? KnSHasloOsoby { get; set; }

    public string? KnSNotatki { get; set; }

    public int? KnSRolaDecyzyjna { get; set; }

    public string? KnSFax { get; set; }

    public string? KnSTelefonK { get; set; }

    public short? KnSUpoDoK { get; set; }

    public byte? KnSArchiwalny { get; set; }

    public short? KnSPozycja { get; set; }

    public int? KnSCzasModyfikacji { get; set; }

    public int? KnSAdresId { get; set; }

    public byte? KnSOdpWindykacja { get; set; }

    public byte? KnSAnonim { get; set; }

    public int KnSSyncId { get; set; }

    public byte? KnSEsklep { get; set; }

    public byte? KnSAdminEsklep { get; set; }

    public int? KnSPreferowanyJezyk { get; set; }

    public string? KnSGuid { get; set; }

    public string? KnSGuid2 { get; set; }

    public byte? KnSCzyEmailUpom { get; set; }
}
