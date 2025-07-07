using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

/// <summary>
/// Lista zlecen kompletacji i dekompletacji
/// </summary>
public partial class FktKompletacjaDekompletacja
{
    /// <summary>
    /// Relation to dimension Czas Dzien. Data realizacji pozycji zlecenia.
    /// </summary>
    public int ZkdCzdprgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien. Data wystawienia dokumentu realizacji (RW/PW/RWK/PWK).
    /// </summary>
    public int ZkdCzdrelGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien. Data potwierdzenia zlecenia.
    /// </summary>
    public int ZkdCzdpgid { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int ZkdAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int ZkdBudzetGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien. Data realizacji zlecenia.
    /// </summary>
    public int ZkdCzdrgid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer. Dokument realizacji PW/PWK
    /// </summary>
    public int ZkdDokNumerGidpw { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer. Dokument realizacji RW/RWK
    /// </summary>
    public int ZkdDokNumerGidrw { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer. Dokument realizacji (RW/PW/RWK/PWK)
    /// </summary>
    public int ZkdDokNumerGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien. Data rozliczenia zlecenia.
    /// </summary>
    public int ZkdCzdrzgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien. Data ważności zlecenia.
    /// </summary>
    public int ZkdCzdwgid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer. Dokument zlecenia kompletacji lub dekompletacji
    /// </summary>
    public int ZkdDokNumerZk { get; set; }

    /// <summary>
    /// Relation to dimension Produkt. Kartoteka towarowa produktu zlecenia.
    /// </summary>
    public int ZkdProdGid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn. Magazyn każdej pozycji realizującej zlecenie.
    /// </summary>
    public int ZkdMagRelGid { get; set; }

    /// <summary>
    /// Relation to dimension Receptury
    /// </summary>
    public int ZkdRecgid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn. Magazyn pozycji realizacji PW/PWK.
    /// </summary>
    public int ZkdMagPwgid { get; set; }

    /// <summary>
    /// Relation to dimension Produkt. Kartoteka towarowa składnika na zleceniu.
    /// </summary>
    public int ZkdSklGid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn. Magazyn pozycji innych niż produkt na zleceniu.
    /// </summary>
    public int ZkdMagSklGid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn. Magazyn na dowolnym elemencie zlecenia.
    /// </summary>
    public int ZkdMagGid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent. Kontrahent na zleceniu.
    /// </summary>
    public int ZkdKntGid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn. Magazyn produktu na zleceniu.
    /// </summary>
    public int ZkdMagProdGid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn. Magazyn pozycji realizacji RW/RWK.
    /// </summary>
    public int ZkdMagRwgid { get; set; }

    public int ZkdId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension. Data wystawienia zlecenia.
    /// </summary>
    public int ZkdCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int ZkdZrodgid { get; set; }

    public string ZkdOrgId { get; set; } = null!;

    public string ZkdDirtyOrgId { get; set; } = null!;

    public string? ZkdOpis { get; set; }

    public DateTime ZkdTsinsert { get; set; }

    public DateTime ZkdTsupdate { get; set; }

    public int ZkdUpdateSubTransformationId { get; set; }

    public int? ZkdUpdateTransformationId { get; set; }

    public int ZkdInsertSubTransformationId { get; set; }

    public int? ZkdInsertTransformationId { get; set; }

    /// <summary>
    /// Wartość dokumentu realizującego zlecenie RW/PW/RWK/PWK.
    /// </summary>
    public decimal? ZkdMdokumentWartosc { get; set; }

    /// <summary>
    /// Ilość subelementu realizacji
    /// </summary>
    public decimal? ZkdMrealizacjaIlosc { get; set; }

    /// <summary>
    /// Koszt subelementu realizacji
    /// </summary>
    public decimal? ZkdMrealizacjaKoszt { get; set; }

    /// <summary>
    /// Koszt dokumentów PW/PWK
    /// </summary>
    public decimal? ZkdMrealizacjaKosztDokPw { get; set; }

    /// <summary>
    /// Koszt dokumentów RW
    /// </summary>
    public decimal? ZkdMrealizacjaKosztDokRw { get; set; }

    /// <summary>
    /// Koszt subelementu dokumentów PW/PWK
    /// </summary>
    public decimal? ZkdMrealizacjaKosztPw { get; set; }

    /// <summary>
    /// Koszt subelementu dokumentów RW/RWK
    /// </summary>
    public decimal? ZkdMrealizacjaKosztRw { get; set; }

    /// <summary>
    /// Ilość subelementu dokumentów PW/PWK
    /// </summary>
    public decimal? ZkdMrealizacjaPwilosc { get; set; }

    /// <summary>
    /// Ilość subelementu dokumentów RW/RWK
    /// </summary>
    public decimal? ZkdMrealizacjaRwilosc { get; set; }

    /// <summary>
    /// Koszt ewidencyjny nagłówka receptury
    /// </summary>
    public decimal? ZkdMrecNagKosztEwidencyjny { get; set; }

    /// <summary>
    /// Ilość produktu wg nagłówka receptury
    /// </summary>
    public decimal? ZkdMrecProdIlosc { get; set; }

    /// <summary>
    /// Ilość składnika wg receptury
    /// </summary>
    public decimal? ZkdMrecSklIlosc { get; set; }

    /// <summary>
    /// Koszt ewidencyjny składnika receptury
    /// </summary>
    public decimal? ZkdMrecSklKosztEwidencyjny { get; set; }

    /// <summary>
    /// Ilość dla pozycji na zleceniu
    /// </summary>
    public decimal? ZkdMzcEsklIlosc { get; set; }

    /// <summary>
    /// Koszt ewidencyjny nagłówka zlecenia
    /// </summary>
    public decimal? ZkdMzlcNagKosztEwidencyjny { get; set; }

    /// <summary>
    /// Koszt rzeczywisty nagłówka zlecenia
    /// </summary>
    public decimal? ZkdMzlcNagKosztRzeczywisty { get; set; }

    /// <summary>
    /// Ilość produktu na zleceniu
    /// </summary>
    public string? ZkdMzlcProdIlosc { get; set; }

    /// <summary>
    /// Ilość składnika na zleceniu.
    /// </summary>
    public decimal? ZkdMzlcSklIlosc { get; set; }

    /// <summary>
    /// Koszt ewidencyjny pozycji zlecenia
    /// </summary>
    public decimal? ZkdMzlcSklKosztEwidencyjny { get; set; }

    /// <summary>
    /// Koszt rzeczywisty pozycji zlecenia
    /// </summary>
    public decimal? ZkdMzlcSklKosztRzeczywisty { get; set; }

    /// <summary>
    /// Rodzaj pozycji na zleceniu - ID
    /// </summary>
    public int? ZkdTyp { get; set; }

    /// <summary>
    /// Rodzaj pozycji na zleceniu - opis
    /// </summary>
    public string? ZkdTypPozycji { get; set; }

    public virtual WymAlokacja ZkdAlokacjaG { get; set; } = null!;

    public virtual WymBudzet ZkdBudzetG { get; set; } = null!;

    public virtual WymCzasDzien ZkdCzdg { get; set; } = null!;

    public virtual WymCzasDzien ZkdCzdpg { get; set; } = null!;

    public virtual WymCzasDzien ZkdCzdprg { get; set; } = null!;

    public virtual WymCzasDzien ZkdCzdrelG { get; set; } = null!;

    public virtual WymCzasDzien ZkdCzdrg { get; set; } = null!;

    public virtual WymCzasDzien ZkdCzdrzg { get; set; } = null!;

    public virtual WymCzasDzien ZkdCzdwg { get; set; } = null!;

    public virtual WymDokumentNumer ZkdDokNumerG { get; set; } = null!;

    public virtual WymDokumentNumer ZkdDokNumerGidpwNavigation { get; set; } = null!;

    public virtual WymDokumentNumer ZkdDokNumerGidrwNavigation { get; set; } = null!;

    public virtual WymDokumentNumer ZkdDokNumerZkNavigation { get; set; } = null!;

    public virtual WymKontrahent ZkdKntG { get; set; } = null!;

    public virtual WymMagazyn ZkdMagG { get; set; } = null!;

    public virtual WymMagazyn ZkdMagProdG { get; set; } = null!;

    public virtual WymMagazyn ZkdMagPwg { get; set; } = null!;

    public virtual WymMagazyn ZkdMagRelG { get; set; } = null!;

    public virtual WymMagazyn ZkdMagRwg { get; set; } = null!;

    public virtual WymMagazyn ZkdMagSklG { get; set; } = null!;

    public virtual WymProdukt ZkdProdG { get; set; } = null!;

    public virtual WymReceptury ZkdRecg { get; set; } = null!;

    public virtual WymProdukt ZkdSklG { get; set; } = null!;

    public virtual WymZrodloDanych ZkdZrodg { get; set; } = null!;
}
