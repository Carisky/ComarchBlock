using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class WysPaczki
{
    public int WyPIdPaczki { get; set; }

    public short? WyPStan { get; set; }

    public short? WyPWysTyp { get; set; }

    public int? WyPWysFirma { get; set; }

    public int? WyPWysNumer { get; set; }

    public short? WyPWysLp { get; set; }

    public short? WyPOpeTyp { get; set; }

    public int? WyPOpeFirma { get; set; }

    public int? WyPOpeNumer { get; set; }

    public short? WyPOpeLp { get; set; }

    public short? WyPRok { get; set; }

    public byte? WyPMiesiac { get; set; }

    public string? WyPSeria { get; set; }

    public int? WyPNumer { get; set; }

    public short? WyPLp { get; set; }

    public decimal? WyPObjetosc { get; set; }

    public decimal? WyPWagaNetto { get; set; }

    public decimal? WyPWagaBrutto { get; set; }

    public string? WyPWjm { get; set; }

    public string? WyPOpis { get; set; }

    public decimal? WyPNetto { get; set; }

    public decimal? WyPVat { get; set; }

    public byte? WyPZgodnoscAdresu { get; set; }

    public short? WyPKntTyp { get; set; }

    public int? WyPKntFirma { get; set; }

    public int? WyPKntNumer { get; set; }

    public short? WyPKntLp { get; set; }

    public short? WyPKnAtyp { get; set; }

    public int? WyPKnAfirma { get; set; }

    public int? WyPKnAnumer { get; set; }

    public short? WyPKnAlp { get; set; }

    public int? WyPDataUtw { get; set; }

    public short? WyPNaKoszt { get; set; }

    public decimal? WyPKosztTr { get; set; }

    public int? WyPAktywny { get; set; }

    public int? WyPTrasaId { get; set; }

    public byte? WyPWsk { get; set; }

    public int? WyPFrsId { get; set; }

    public string? WyPCechaOpis { get; set; }

    public int? WyPFrmNumer { get; set; }

    public int? WyPWysPozycja { get; set; }

    public byte? WyPRodzaj { get; set; }

    public byte? WyPSposobLaczenia { get; set; }

    public int? WyPKurier { get; set; }

    public int? WyPRodzajPrzesylki { get; set; }

    public int? WyPDlugosc { get; set; }

    public int? WyPSzerokosc { get; set; }

    public int? WyPWysokosc { get; set; }

    public short? WyPKnStyp { get; set; }

    public int? WyPKnSfirma { get; set; }

    public int? WyPKnSnumer { get; set; }

    public short? WyPKnSlp { get; set; }

    public string? WyPKnStelefon { get; set; }

    public string? WyPKnSemail { get; set; }

    public int? WyPZnppaczkaId { get; set; }

    public string? WyPNumerListu { get; set; }

    public string? WyPLinkPrzesylki { get; set; }

    public byte? WyPZnpstatusPaczki { get; set; }

    public virtual ICollection<WysRelacje> WysRelacjes { get; set; } = new List<WysRelacje>();
}
