using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PrcKarty
{
    public short? PrcGidtyp { get; set; }

    public int? PrcGidfirma { get; set; }

    public int PrcGidnumer { get; set; }

    public short? PrcGidlp { get; set; }

    public short? PrcOpeTyp { get; set; }

    public int? PrcOpeFirma { get; set; }

    public int? PrcOpeNumer { get; set; }

    public short? PrcOpeLp { get; set; }

    public short? PrcBnkTyp { get; set; }

    public int? PrcBnkFirma { get; set; }

    public int? PrcBnkNumer { get; set; }

    public short? PrcBnkLp { get; set; }

    public short? PrcZakTyp { get; set; }

    public int? PrcZakFirma { get; set; }

    public int? PrcZakNumer { get; set; }

    public short? PrcZakLp { get; set; }

    public string? PrcAkronim { get; set; }

    public string? PrcImie1 { get; set; }

    public string? PrcImie2 { get; set; }

    public string? PrcNazwisko { get; set; }

    public string? PrcKodP { get; set; }

    public string? PrcMiasto { get; set; }

    public string? PrcPoczta { get; set; }

    public string? PrcUlica { get; set; }

    public string? PrcNrDomu { get; set; }

    public string? PrcNrLokalu { get; set; }

    public string? PrcNipE { get; set; }

    public string? PrcNip { get; set; }

    public string? PrcPesel { get; set; }

    public string? PrcEmail { get; set; }

    public string? PrcEmail2 { get; set; }

    public string? PrcTelefon1 { get; set; }

    public string? PrcTelefonWew1 { get; set; }

    public string? PrcTelefon2 { get; set; }

    public string? PrcTelefon3 { get; set; }

    public string? PrcTelefon4 { get; set; }

    public string? PrcUrl { get; set; }

    public string? PrcUrl2 { get; set; }

    public string? PrcNrRachunku { get; set; }

    public byte? PrcNrb { get; set; }

    public string? PrcKontoKs1 { get; set; }

    public string? PrcKontoKs2 { get; set; }

    public string? PrcKontoKs3 { get; set; }

    public string? PrcKontoKs4 { get; set; }

    public string? PrcKontoKs5 { get; set; }

    public byte? PrcFormaNr { get; set; }

    public byte? PrcKsiegowany { get; set; }

    public short? PrcArchiwalny { get; set; }

    public int? PrcArchiwalnyData { get; set; }

    public int? PrcWmrId { get; set; }

    public byte? PrcTypWymiaru { get; set; }

    public byte? PrcWyrazenie { get; set; }

    public string? PrcInbox { get; set; }

    public int? PrcFrSid { get; set; }

    public int? PrcOptimaId { get; set; }

    public string? PrcNtsid { get; set; }

    public string? PrcNtkonto { get; set; }

    public byte[]? PrcHaslo { get; set; }

    public byte? PrcSerwisant { get; set; }

    public int? PrcPkaid { get; set; }

    public int? PrcRodzaj { get; set; }

    public byte? PrcWojStosunek { get; set; }

    public string? PrcWojWku { get; set; }

    public string? PrcWojNumer { get; set; }

    public string? PrcWojPrzydzial { get; set; }

    public string? PrcWojStopien { get; set; }

    public string? PrcWojSpec { get; set; }

    public byte? PrcKarany { get; set; }

    public string? PrcKaranyOpis { get; set; }

    public byte? PrcZgodaNaPrzetwarzanie { get; set; }

    public string? PrcWypadekOsoba { get; set; }

    public string? PrcWypadekTelefon { get; set; }

    public string? PrcWypadekAdres { get; set; }

    public string? PrcOpis { get; set; }

    public string? PrcOmnie { get; set; }

    public string? PrcMiejscePracy { get; set; }

    public string? PrcNrPokoju { get; set; }

    public byte? PrcPoziomWyksztalcenia { get; set; }

    public int? PrcOpeWnumer { get; set; }

    public int? PrcCzasWprowadzenia { get; set; }

    public int? PrcOpeMnumer { get; set; }

    public int? PrcCzasModyfikacji { get; set; }

    public int? PrcZewnetrznySys { get; set; }

    public int? PrcDomyslneCentrumKosztId { get; set; }

    public string? PrcKraj { get; set; }

    public byte? PrcEsklep { get; set; }

    public virtual ICollection<OsoAdresy> OsoAdresies { get; set; } = new List<OsoAdresy>();

    public virtual ICollection<OsoCzasPracy> OsoCzasPracies { get; set; } = new List<OsoCzasPracy>();

    public virtual ICollection<OsoCzasRazem> OsoCzasRazems { get; set; } = new List<OsoCzasRazem>();

    public virtual ICollection<OsoHistZatrudnienium> OsoHistZatrudnienia { get; set; } = new List<OsoHistZatrudnienium>();

    public virtual ICollection<OsoKompetencje> OsoKompetencjes { get; set; } = new List<OsoKompetencje>();

    public virtual ICollection<OsoNieobecnosci> OsoNieobecnoscis { get; set; } = new List<OsoNieobecnosci>();

    public virtual ICollection<OsoPlatNag> OsoPlatNags { get; set; } = new List<OsoPlatNag>();

    public virtual ICollection<OsoPrzekPodstawy> OsoPrzekPodstawies { get; set; } = new List<OsoPrzekPodstawy>();

    public virtual ICollection<OsoRodzina> OsoRodzinas { get; set; } = new List<OsoRodzina>();

    public virtual ICollection<OsoUbezpieczenium> OsoUbezpieczenia { get; set; } = new List<OsoUbezpieczenium>();

    public virtual ICollection<OsoWyksztalcenie> OsoWyksztalcenies { get; set; } = new List<OsoWyksztalcenie>();

    public virtual ICollection<PodzielnikPrac> PodzielnikPracs { get; set; } = new List<PodzielnikPrac>();

    public virtual ICollection<PrcAdresyEmail> PrcAdresyEmails { get; set; } = new List<PrcAdresyEmail>();

    public virtual ICollection<PrcWarunki> PrcWarunkis { get; set; } = new List<PrcWarunki>();

    public virtual ICollection<Rcpzapisy> Rcpzapisies { get; set; } = new List<Rcpzapisy>();

    public virtual ICollection<RcpzatwElem> RcpzatwElems { get; set; } = new List<RcpzatwElem>();
}
