using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktDodatkoweKosztyZakupu
{
    /// <summary>
    /// Relation to dimension Rejon
    /// </summary>
    public int KdzRejonid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int KdzKntId { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int KdzAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int KdzKndId { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int KdzDokNumerId { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer dokument zrodlowy
    /// </summary>
    public int KdzDokZrnumerId { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int KdzDokKnumerId { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int KdzCzdwystawieniaId { get; set; }

    /// <summary>
    /// Relation to dimension StazKlienta
    /// </summary>
    public int KdzKndStazId { get; set; }

    /// <summary>
    /// Relation to dimension Perspektywa
    /// </summary>
    public int KdzPerspektywaId { get; set; }

    /// <summary>
    /// Relation to dimension FIRMA
    /// </summary>
    public int KdzFirmaId { get; set; }

    /// <summary>
    /// Relation to dimension StazKlienta
    /// </summary>
    public int KdzKntStazId { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int KdzCzdzakupuId { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int KdzCzdprzyjeciaId { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int KdzBudzetId { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int KdzProjektId { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int KdzLokId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int KdzStrFrmId { get; set; }

    /// <summary>
    /// Relation to dimension Waluta
    /// </summary>
    public int KdzWalutaId { get; set; }

    /// <summary>
    /// Relation to dimension StazKlienta
    /// </summary>
    public int KdzProdStazId { get; set; }

    /// <summary>
    /// Relation to dimension Jednostka
    /// </summary>
    public int KdzJmId { get; set; }

    /// <summary>
    /// Relation to dimension Zapadalnosc
    /// </summary>
    public int KdzZapId { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn
    /// </summary>
    public int KdzMagId { get; set; }

    /// <summary>
    /// Relation to dimension RodzKosztuDod
    /// </summary>
    public int KdzRkdid { get; set; }

    /// <summary>
    /// Relation to dimension Dostawa
    /// </summary>
    public int KdzDstId { get; set; }

    /// <summary>
    /// Relation to dimension Pracownik
    /// </summary>
    public int KdzPracownikId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int KdzPrmid { get; set; }

    /// <summary>
    /// Relation to dimension Cechy
    /// </summary>
    public int KdzCechyId { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int KdzProdId { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int KdzPlatId { get; set; }

    public int KdzId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int KdzCzdid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int KdzZrodgid { get; set; }

    public string KdzOrgId { get; set; } = null!;

    public string KdzDirtyOrgId { get; set; } = null!;

    public string? KdzOpis { get; set; }

    public DateTime KdzTsinsert { get; set; }

    public DateTime KdzTsupdate { get; set; }

    public int KdzUpdateSubTransformationId { get; set; }

    public int? KdzUpdateTransformationId { get; set; }

    public int KdzInsertSubTransformationId { get; set; }

    public int? KdzInsertTransformationId { get; set; }

    public int? KdzKierunek { get; set; }

    public int? KdzTypKwoty { get; set; }

    /// <summary>
    /// kolumna pomocnicza
    /// </summary>
    public string? KdzOrgWymId { get; set; }

    public int? KdzPozycjaId { get; set; }

    public int? KdzSubPozycjaId { get; set; }

    public string? KdzOrgAtrId { get; set; }

    /// <summary>
    /// Wartosc kosztu dodatkowego
    /// </summary>
    public decimal? KdzMkosztDodatkowy { get; set; }

    /// <summary>
    /// ilosc w jednostce pomocniczej
    /// </summary>
    public decimal? KdzMiloscJpom { get; set; }

    /// <summary>
    /// ilosc
    /// </summary>
    public decimal? KdzMilosc { get; set; }

    /// <summary>
    /// punkty bonusowe
    /// </summary>
    public decimal? KdzMpunkty { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? KdzStrPrwId { get; set; }

    public string? KdzDataMod { get; set; }

    public virtual WymAlokacja KdzAlokacja { get; set; } = null!;

    public virtual WymBudzet KdzBudzet { get; set; } = null!;

    public virtual WymCechy KdzCechy { get; set; } = null!;

    public virtual WymCzasDzien KdzCzd { get; set; } = null!;

    public virtual WymCzasDzien KdzCzdprzyjecia { get; set; } = null!;

    public virtual WymCzasDzien KdzCzdwystawienia { get; set; } = null!;

    public virtual WymCzasDzien KdzCzdzakupu { get; set; } = null!;

    public virtual WymDokumentNumer KdzDokKnumer { get; set; } = null!;

    public virtual WymDokumentNumer KdzDokNumer { get; set; } = null!;

    public virtual WymDokumentNumer KdzDokZrnumer { get; set; } = null!;

    public virtual WymDostawa KdzDst { get; set; } = null!;

    public virtual WymFirma KdzFirma { get; set; } = null!;

    public virtual WymJednostka KdzJm { get; set; } = null!;

    public virtual WymKontrahent KdzKnd { get; set; } = null!;

    public virtual WymStazKlientum KdzKndStaz { get; set; } = null!;

    public virtual WymKontrahent KdzKnt { get; set; } = null!;

    public virtual WymStazKlientum KdzKntStaz { get; set; } = null!;

    public virtual WymLokalizacja KdzLok { get; set; } = null!;

    public virtual WymMagazyn KdzMag { get; set; } = null!;

    public virtual WymPerspektywa KdzPerspektywa { get; set; } = null!;

    public virtual WymKontrahent KdzPlat { get; set; } = null!;

    public virtual WymPracownik KdzPracownik { get; set; } = null!;

    public virtual WymPrecyzjaMiary KdzPrm { get; set; } = null!;

    public virtual WymProdukt KdzProd { get; set; } = null!;

    public virtual WymStazKlientum KdzProdStaz { get; set; } = null!;

    public virtual WymProjekt KdzProjekt { get; set; } = null!;

    public virtual WymRejon KdzRejon { get; set; } = null!;

    public virtual WymRodzKosztuDod KdzRkd { get; set; } = null!;

    public virtual WymStrukturaFirmy KdzStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? KdzStrPrw { get; set; }

    public virtual WymWalutum KdzWaluta { get; set; } = null!;

    public virtual WymZapadalnosc KdzZap { get; set; } = null!;

    public virtual WymZrodloDanych KdzZrodg { get; set; } = null!;
}
