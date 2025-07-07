using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class DefPodElem
{
    public int DpeDpnid { get; set; }

    public int? DpeId { get; set; }

    public int DpeLp { get; set; }

    public int? DpeNumer { get; set; }

    public byte? DpeTyp { get; set; }

    public string? DpeNazwa { get; set; }

    public short? DpeStrona { get; set; }

    public int? DpeWspX { get; set; }

    public int? DpeWspXpoleNumer { get; set; }

    public int? DpeWspY { get; set; }

    public int? DpeSzerokosc { get; set; }

    public int? DpeWysokosc { get; set; }

    public int? DpeOpisWspX { get; set; }

    public int? DpeOpisWspXpoleNumer { get; set; }

    public int? DpeOpisWspY { get; set; }

    public int? DpeOpisSzerokosc { get; set; }

    public int? DpeOpisWysokosc { get; set; }

    public byte? DpeBezwzgledne { get; set; }

    public string? DpeWyrazenie { get; set; }

    public byte? DpeDefiniowalne { get; set; }

    public byte? DpeOblicz { get; set; }

    public string? DpeNieaktywne { get; set; }

    public byte? DpePlatnosc { get; set; }

    public string? DpeWymagane { get; set; }

    public byte? DpePusteGdy0 { get; set; }

    public string? DpeCzcionka { get; set; }

    public int? DpeRozmiar { get; set; }

    public int? DpeKolor { get; set; }

    public int? DpeStyl { get; set; }

    public string? DpeOpisCzcionka { get; set; }

    public int? DpeOpisRozmiar { get; set; }

    public int? DpeOpisKolor { get; set; }

    public int? DpeOpisStyl { get; set; }

    public string? DpeOgraniczenie { get; set; }

    public string? DpeOgraniczenieDolne { get; set; }

    public byte? DpeTypOgraniczenia { get; set; }

    public string? DpeUkryte { get; set; }

    public int? DpeDfnid { get; set; }

    public byte? DpeDfnkwotaWmr { get; set; }

    public byte? DpeOpisNrPodpoziomu { get; set; }

    public byte? DpePrecyzja { get; set; }

    public string? DpePrecyzjaWyrazenie { get; set; }

    public byte? DpeNieLiczGdyNieaktywne { get; set; }

    public byte? DpeAgreguj { get; set; }

    public string? DpeNieZapisuj { get; set; }

    public int? DpeKolejnoscWyliczen { get; set; }

    public byte? DpePoleNaSchemacieKsiegowym { get; set; }

    public string? DpeXmltagNazwa { get; set; }

    public string? DpeXmltagAtrybuty { get; set; }

    public string? DpeXmlparTagNazwa { get; set; }

    public string? DpeXmlrekordTagNazwa { get; set; }

    public string? DpeXmlrekordTagAtrybuty { get; set; }

    public byte? DpeXmllp { get; set; }

    public byte? DpeXmlpominGdyPuste { get; set; }

    public byte? DpeXmlpusteGdyBrakRownoleglychElem { get; set; }

    public string? DpeXmlnieDodawajGalezi { get; set; }

    public string? DpeXmlwarunekRekordu { get; set; }

    public virtual ICollection<DefPodElemKolumny> DefPodElemKolumnies { get; set; } = new List<DefPodElemKolumny>();

    public virtual ICollection<DefPodElemWyrazenium> DefPodElemWyrazenia { get; set; } = new List<DefPodElemWyrazenium>();

    public virtual DefPodNag DpeDpn { get; set; } = null!;
}
