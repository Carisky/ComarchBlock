using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Wysylki
{
    public short? WysGidtyp { get; set; }

    public int? WysGidfirma { get; set; }

    public int WysGidnumer { get; set; }

    public short? WysGidlp { get; set; }

    public short? WysSpeTyp { get; set; }

    public int? WysSpeFirma { get; set; }

    public int? WysSpeNumer { get; set; }

    public short? WysSpeLp { get; set; }

    public short? WysOpeTyp { get; set; }

    public int? WysOpeFirma { get; set; }

    public int? WysOpeNumer { get; set; }

    public short? WysOpeLp { get; set; }

    public short? WysRok { get; set; }

    public byte? WysMiesiac { get; set; }

    public string? WysSeria { get; set; }

    public int? WysNumer { get; set; }

    public short? WysLp { get; set; }

    public string? WysNumerObcy { get; set; }

    public short? WysStan { get; set; }

    public decimal? WysUbezpieczenie { get; set; }

    public decimal? WysPobranie { get; set; }

    public short? WysIlePaczek { get; set; }

    public int? WysTswysylki { get; set; }

    public int? WysTsdostarczeniaOd { get; set; }

    public int? WysTsdostarczeniaDo { get; set; }

    public decimal? WysObjetosc { get; set; }

    public decimal? WysWagaNetto { get; set; }

    public decimal? WysWagaBrutto { get; set; }

    public string? WysWjm { get; set; }

    public string? WysOpis { get; set; }

    public decimal? WysNetto { get; set; }

    public decimal? WysVat { get; set; }

    public decimal? WysDlugoscTrasy { get; set; }

    public int? WysRozliczenieKosztow { get; set; }

    public int? WysAktywny { get; set; }

    public short? WysKierTyp { get; set; }

    public int? WysKierNumer { get; set; }

    public short? WysKierLp { get; set; }

    public int? WysTrasaId { get; set; }

    public int? WysSamId { get; set; }

    public byte? WysWsk { get; set; }

    public int? WysFrsId { get; set; }

    public string? WysCechaOpis { get; set; }

    public int? WysFrmNumer { get; set; }

    public int? WysLastMod { get; set; }

    public int? WysKurier { get; set; }

    public string? WysLinkPrzesylki { get; set; }

    public int? WysStanPrzesylki { get; set; }

    public string? WysZnpnr { get; set; }

    public int? WysZnpid { get; set; }

    public string? WysPunktOdb { get; set; }

    public int? WysDataNadania { get; set; }

    public byte? WysZnpstatusPaczki { get; set; }

    public virtual ICollection<WysKoszty> WysKoszties { get; set; } = new List<WysKoszty>();
}
