using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktZamowieniaZakupu
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZazDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ZazId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZazInsertSubTransformationId { get; set; }

    public int ZazInsertTransformationId { get; set; }

    public string? ZazOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZazOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZazTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZazTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZazUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZazUpdateTransformationId { get; set; }

    /// <summary>
    /// Identyfikator akwizytora. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZazAkwId { get; set; }

    /// <summary>
    /// Data wystawienia ostatniego dokumentu handlowego z zamówienia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZazCzdfaktId { get; set; }

    /// <summary>
    /// Data wystawienia zamówienia. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int ZazCzdid { get; set; }

    /// <summary>
    /// Data planowanej realizacji zamówienia. Relacja do wymiaru WYM_Czasdzien
    /// </summary>
    public int ZazCzdplanId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu zamówienia. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int ZazDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator formy płatności. Relacja do wymiaru WYM_FormyPlatnosci
    /// </summary>
    public int ZazFormPlatId { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int ZazJmId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int ZazJmPid { get; set; }

    /// <summary>
    /// Identyfikator odbiorcy (kontrahenta docelowego). Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZazKnDid { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Relacja do wymiaru WYM_Kontrahent.
    /// </summary>
    public int ZazKntId { get; set; }

    /// <summary>
    /// Identyfikator magazynu domyślnego. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int ZazMagId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int ZazOpiekunId { get; set; }

    /// <summary>
    /// Identyfikator płatnika. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int ZazPlatId { get; set; }

    /// <summary>
    /// Identyfikator operatora wystawiającego. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int ZazPrcId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int ZazProdId { get; set; }

    /// <summary>
    /// Identyfikator struktury firmy. Relacja do wymiaru WYM_StrukturaFirmy
    /// </summary>
    public int ZazStrFrmId { get; set; }

    /// <summary>
    /// Identyfikator waluty, w której wystawione jest zamówienie. Relacja do wymiaru WYM_Waluta
    /// </summary>
    public int ZazWalutaId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZazZrodgid { get; set; }

    /// <summary>
    /// Ilość towaru w jednostce podstawowej
    /// </summary>
    public decimal? ZazMilosc { get; set; }

    /// <summary>
    /// Ilość towaru w jednostce pomocniczej.
    /// </summary>
    public decimal? ZazMiloscJmP { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? ZazMiloscRealizacji { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? ZazMiloscRealizacjiJmP { get; set; }

    /// <summary>
    /// Różnica pomiędzy datą wystawienia ostatniego dokumentu handlowego do danego zamówienia a przewidywaną datą realizacji zamówienia
    /// </summary>
    public decimal? ZazModchylenieRealizacji { get; set; }

    /// <summary>
    /// Wartość pozycji po rabacie wyrażona w walucie dokumentu
    /// </summary>
    public decimal? ZazMwartosc { get; set; }

    /// <summary>
    /// Wartość pozycji po rabacie wyrażona w walucie systemowej
    /// </summary>
    public decimal? ZazMwartoscPln { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? ZazMwartoscZakup { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public decimal? ZazMwartoscZakupPln { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZazOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? ZazOrgWymId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int ZazBudzetId { get; set; }

    /// <summary>
    /// Wartość KGO dla elementu wyrażona w walucie dokumentu
    /// </summary>
    public decimal? ZazMkgo { get; set; }

    /// <summary>
    /// Stawka VAT
    /// </summary>
    public decimal? ZazMvat { get; set; }

    /// <summary>
    /// Flaga informująca czy wartości na dokumencie są liczone od netto czy od brutto
    /// </summary>
    public string? ZazFlagaNb { get; set; }

    /// <summary>
    /// Pozycja elementu na zamówieniu
    /// </summary>
    public int? ZazPozycjaId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int ZazRejonId { get; set; }

    /// <summary>
    /// Różnica w dniach między datą wystawienia ostatniego dokumentu handlowego a przewidywaną datą zrealizowania zamówienia. Relacja do wymiaru WYM_ZamowieniaStan
    /// </summary>
    public int ZazZamStanId { get; set; }

    /// <summary>
    /// Różnica w dniach między datą wystawienia ostatniego dokumentu handlowego a przewidywaną datą zrealizowania zamówienia
    /// </summary>
    public decimal? ZazMdni { get; set; }

    /// <summary>
    /// Ilość dni od daty wystawienia do realizacji zamówienia pobrana z elementu zamówienia, wyrażona w formacie Clarion
    /// </summary>
    public decimal? ZazMczasRealizacji { get; set; }

    /// <summary>
    /// Informacja, czy został udzielony rabat
    /// </summary>
    public decimal ZazCzyRabat { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Geografia
    /// </summary>
    public int ZazGeoid { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int ZazCechyId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZazAlokacjaId { get; set; }

    /// <summary>
    /// Informacja czy produkt ma flagę &apos;Gratis&apos; lub &apos;Złom&apos;. Relacja do wymiaru WYM_ProduktPozycjeDok
    /// </summary>
    public int ZazProduktPozycjeDokId { get; set; }

    /// <summary>
    /// Identyfikator kategorii ABC\XYZ przypisanej towarowi. Relacja do wymiaru WYM_KategoriaABCXYZ
    /// </summary>
    public int ZazAbcgid { get; set; }

    public string? ZazOrgAtrEleId { get; set; }

    public string? ZazOrgAtrNagId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int ZazPrmgid { get; set; }

    public decimal? ZamZakupuRhWartoscBdtcalc { get; set; }

    public decimal? ZamZakupuRhIloscBdtcalc { get; set; }

    public decimal? ZamZakupuRhIloscJPomBdtcalc { get; set; }

    public int? ZazTypKwoty { get; set; }

    public int? ZazKierunek { get; set; }

    public int? ZazWymTyp { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int ZazProjektGid { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int ZazLokGid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? ZazStrPrwId { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZazOpezgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZazOpewgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZazOpegid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ZazOpemgid { get; set; }

    public decimal? ZazMwaga { get; set; }

    public int ZazDokElemId { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0213Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public virtual WymKategoriaAbcxyz ZazAbcg { get; set; } = null!;

    public virtual WymKontrahent ZazAkw { get; set; } = null!;

    public virtual WymAlokacja ZazAlokacja { get; set; } = null!;

    public virtual WymBudzet ZazBudzet { get; set; } = null!;

    public virtual WymCechy ZazCechy { get; set; } = null!;

    public virtual WymCzasDzien ZazCzd { get; set; } = null!;

    public virtual WymCzasDzien ZazCzdfakt { get; set; } = null!;

    public virtual WymCzasDzien ZazCzdplan { get; set; } = null!;

    public virtual WymDokumentElement ZazDokElem { get; set; } = null!;

    public virtual WymDokumentNumer ZazDokNumer { get; set; } = null!;

    public virtual WymFormyPlatnosci ZazFormPlat { get; set; } = null!;

    public virtual WymGeografium ZazGeo { get; set; } = null!;

    public virtual WymJednostka ZazJm { get; set; } = null!;

    public virtual WymJednostka ZazJmP { get; set; } = null!;

    public virtual WymKontrahent ZazKnD { get; set; } = null!;

    public virtual WymKontrahent ZazKnt { get; set; } = null!;

    public virtual WymLokalizacja ZazLokG { get; set; } = null!;

    public virtual WymMagazyn ZazMag { get; set; } = null!;

    public virtual WymOperator ZazOpeg { get; set; } = null!;

    public virtual WymOperator ZazOpemg { get; set; } = null!;

    public virtual WymOperator ZazOpewg { get; set; } = null!;

    public virtual WymOperator ZazOpezg { get; set; } = null!;

    public virtual WymPracownik ZazOpiekun { get; set; } = null!;

    public virtual WymKontrahent ZazPlat { get; set; } = null!;

    public virtual WymPracownik ZazPrc { get; set; } = null!;

    public virtual WymPrecyzjaMiary ZazPrmg { get; set; } = null!;

    public virtual WymProdukt ZazProd { get; set; } = null!;

    public virtual WymProduktPozycjeDok ZazProduktPozycjeDok { get; set; } = null!;

    public virtual WymProjekt ZazProjektG { get; set; } = null!;

    public virtual WymRejon ZazRejon { get; set; } = null!;

    public virtual WymStrukturaFirmy ZazStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? ZazStrPrw { get; set; }

    public virtual WymWalutum ZazWaluta { get; set; } = null!;

    public virtual WymZamowieniaStan ZazZamStan { get; set; } = null!;

    public virtual WymZrodloDanych ZazZrodg { get; set; } = null!;
}
