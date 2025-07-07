using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DokumentyKseF
{
    public int DkfDkfid { get; set; }

    public int? DkfPodmiotTyp { get; set; }

    public int? DkfPodmiotId { get; set; }

    public int? DkfKatId { get; set; }

    public string? DkfKategoria { get; set; }

    public string? DkfOpis { get; set; }

    public DateTime DkfDataWystawienia { get; set; }

    public DateTime DkfDataPozyskania { get; set; }

    public DateTime DkfDataDostawy { get; set; }

    public DateTime? DkfTerminPlatnosci { get; set; }

    public DateTime? DkfTerminPlatnosciE { get; set; }

    public string DkfNumerDokumentu { get; set; } = null!;

    public string DkfNumerKseF { get; set; } = null!;

    public string DkfNip { get; set; } = null!;

    public string? DkfNipkraj { get; set; }

    public string DkfPelnaNazwa { get; set; } = null!;

    public string? DkfAdres { get; set; }

    public string DkfKodKraju { get; set; } = null!;

    public string DkfWojewodztwo { get; set; } = null!;

    public string DkfPowiat { get; set; } = null!;

    public string DkfGmina { get; set; } = null!;

    public string DkfUlica { get; set; } = null!;

    public string DkfNrDomu { get; set; } = null!;

    public string DkfNrLokalu { get; set; } = null!;

    public string DkfMiejscowosc { get; set; } = null!;

    public string DkfKodPocztowy { get; set; } = null!;

    public string DkfPoczta { get; set; } = null!;

    public string DkfGln { get; set; } = null!;

    public string? DkfEmail { get; set; }

    public string? DkfTelefon { get; set; }

    public decimal DkfNetto { get; set; }

    public decimal DkfVat { get; set; }

    public decimal DkfBrutto { get; set; }

    public string DkfWaluta { get; set; } = null!;

    public int DkfStatus { get; set; }

    public int DkfEwidencja { get; set; }

    public int? DkfTyp { get; set; }

    public int? DkfVaNid { get; set; }

    public int? DkfTrNid { get; set; }

    public string? DkfRejestrDocelowy { get; set; }

    public int? DkfFplId { get; set; }

    public int? DkfFplEid { get; set; }

    public byte[]? DkfWartosc { get; set; }

    public int? DkfRozmiar { get; set; }

    public byte[]? DkfWartoscXml { get; set; }

    public int? DkfRozmiarXml { get; set; }

    public byte[]? DkfHtml { get; set; }

    public int? DkfRozmiarHtml { get; set; }

    public int DkfServer { get; set; }

    public int? DkfPodmiotMode { get; set; }

    public int? DkfZrodlo { get; set; }

    public string? DkfFormaPlatnosciKseF { get; set; }

    public virtual ICollection<DokAtrybuty> DokAtrybuties { get; set; } = new List<DokAtrybuty>();
}
