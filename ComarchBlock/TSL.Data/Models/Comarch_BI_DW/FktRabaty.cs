using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktRabaty
{
    /// <summary>
    /// Identyfikator promocji. Relacja do wymiaru WYM_Promocje
    /// </summary>
    public int? RabatPrmId { get; set; }

    /// <summary>
    /// Identyfikator Daty Dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int? RabatDataDokumentuId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta docelowego. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int? RabatKndId { get; set; }

    /// <summary>
    /// Identyfikator Lokalizacji. Relacja do wymiaru WYM_Lokalizacja
    /// </summary>
    public int? RabatLokId { get; set; }

    /// <summary>
    /// Identyfikator formy płatności. Relacja do wymiaru WYM_FormyPlatnosci
    /// </summary>
    public int? RabatFormaPlatId { get; set; }

    /// <summary>
    /// Identyfikator struktury firmy. Relacja do wymiaru analitycznego WYM_StrukturaFirmy
    /// </summary>
    public int? RabatStrFrmId { get; set; }

    /// <summary>
    /// Identyfikator magazynu. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int? RabatMagId { get; set; }

    /// <summary>
    /// Identyfikator płatnika. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int? RabatPlatId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int? RabatBudzetId { get; set; }

    /// <summary>
    /// Identyfikator etapu kampanii CRM. Relacja do wymiaru WYM_CRMEtapy
    /// </summary>
    public int? RabatCrmetapId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu, do którego został przyznany rabat. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int? RabatDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int? RabatKntId { get; set; }

    /// <summary>
    /// Identyfikator Akwizytora. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int? RabatAkwId { get; set; }

    /// <summary>
    /// Identyfikator firmy. Relacja do wymiaru WYM_Firma
    /// </summary>
    public int? RabatFirmaId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int? RabatProdId { get; set; }

    /// <summary>
    /// Godzina wystawienia dokumentu. Relacja do wymiaru WYM_CzasGodzina
    /// </summary>
    public int? RabatCzgid { get; set; }

    /// <summary>
    /// Identyfikator struktury praw. Relacja do wymiaru analitycznego WYM_StrukturaPraw
    /// </summary>
    public int? RabatStrPrawId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int? RabatJmpId { get; set; }

    /// <summary>
    /// Identyfikator waluty użytej na dokumencie. Relacja do wymiaru WYM_Waluta.
    /// </summary>
    public int? RabatWalutaId { get; set; }

    /// <summary>
    /// Identyfikator dostawcy. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int? RabatDstId { get; set; }

    /// <summary>
    /// Faktyczny czas realizacji zamówienia zakupu. Relacja do wymiaru WYM_CzasDzien 
    /// </summary>
    public int? RabatCzdfaktId { get; set; }

    /// <summary>
    /// Planowany czas realizacji zamówienia zakupu. Relacja do wymiaru WYM_CzasDzien 
    /// </summary>
    public int? RabatCzdplanId { get; set; }

    /// <summary>
    /// Identyfikator spinacza dokumentu. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int? RabatSpiDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int? RabatCechyId { get; set; }

    /// <summary>
    /// Identyfikator opiekuna kontrahenta. Relacja do wymiaru WYM_Pracownik
    /// </summary>
    public int? RabatOpiekunId { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int? RabatCzwid { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int? RabatJmId { get; set; }

    /// <summary>
    /// Identyfikator typu zamówienia. Relacja do wymiaru WYM_TypZamowienia
    /// </summary>
    public int? RabatTypZamId { get; set; }

    /// <summary>
    /// Identyfikator rodzaju zakupu. Relacja do wymiaru WYM_RodzajZakupu.
    /// </summary>
    public int? RabatRdzZakId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long RabatId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int RabatZrodgid { get; set; }

    /// <summary>
    /// Identyfikator daty controllingowej. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int RabatCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RabatOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RabatDirtyOrgId { get; set; } = null!;

    public string? RabatOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int RabatUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RabatUpdateSubTransformationId { get; set; }

    public int RabatInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RabatInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RabatTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RabatTsupdate { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? RabatPaczka { get; set; }

    /// <summary>
    /// Obszar, którego dotyczy rabat. 1 - Sprzedaz, 2 - Zakupy, 3 i 4 - Zamowienia
    /// </summary>
    public int? RabatObszar { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? RabatKierunek { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? RabatWymTyp { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? RabatTypKwoty { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? RabatOrgWymId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? RabatOrgAtrId { get; set; }

    /// <summary>
    /// Wartosc rabatu uzyskana poprzez pomnozenie rabatu przez procent opisu analitycznego
    /// </summary>
    public decimal? RabatMrabat { get; set; }

    /// <summary>
    /// Wartosc rabatu nie podzielona analitycznie
    /// </summary>
    public decimal? RabatMrabatCalosc { get; set; }

    /// <summary>
    /// Wartosc rabatu % dla poszegolnego typu rabatu na pozycji - nie podzielona analitycznie
    /// </summary>
    public decimal? RabatMrabatProcent { get; set; }

    /// <summary>
    /// Wartosc rabatu % dla pozycji - nie podzielona analitycznie
    /// </summary>
    public decimal? RabatMrabatProcentPozycja { get; set; }

    /// <summary>
    /// Identyfikator projektu. Relacja do wymiaru WYM_Projekt
    /// </summary>
    public int? RabatProjektId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? RabatWymObjGidLp { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? RabatRejonId { get; set; }

    /// <summary>
    /// Identyfikator daty sprzedaży/zakupu w zależności od rodzaju dokumentu. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int RabatCzsid { get; set; }

    /// <summary>
    /// Identyfikator adresu Kontrahenta Docelowego. Relacja do wymiaru WYM_Adres
    /// </summary>
    public int? RabatAdrKndId { get; set; }

    /// <summary>
    /// Identyfikator użytego cennika
    /// </summary>
    public int RabatCennikId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int RabatAlokacjaId { get; set; }

    /// <summary>
    /// Informacja czy produkt ma flagę &apos;Gratis&apos; lub &apos;Złom&apos;. Relacja do wymiaru WYM_ProduktPozycjeDok
    /// </summary>
    public int RabatProduktPozycjeDokId { get; set; }

    public string? RabatOrgAtrNagId { get; set; }

    public string? RabatOrgAtrEleId { get; set; }

    public string? RabatOrgAtrSubId { get; set; }

    public bool? RabatIsCorrection { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int RabatPrmgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int RabatOpemgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int RabatOpezgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int RabatOpewgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int RabatOperatorId { get; set; }

    /// <summary>
    /// Relation to dimension RodzajCeny
    /// </summary>
    public int RabatRodzCenId { get; set; }

    public string? RabatDataMod { get; set; }

    public int? RabatGidLp { get; set; }

    public int? RabatGidNumer { get; set; }

    public int? RabatGidPrm { get; set; }

    public int? RabatGidSubLp { get; set; }

    public int? RabatGidTyp { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0213Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public int? Atr0242Id { get; set; }

    public int? Atr0267Id { get; set; }

    public int? Atr027Id { get; set; }

    public int? Atr028Id { get; set; }

    public int? Atr029Id { get; set; }

    public int? Atr0299Id { get; set; }

    public int? Atr02101Id { get; set; }

    public virtual WymAdre? RabatAdrKnd { get; set; }

    public virtual WymKontrahent? RabatAkw { get; set; }

    public virtual WymAlokacja RabatAlokacja { get; set; } = null!;

    public virtual WymBudzet? RabatBudzet { get; set; }

    public virtual WymCechy? RabatCechy { get; set; }

    public virtual WymCennik RabatCennik { get; set; } = null!;

    public virtual WymCrmetapy? RabatCrmetap { get; set; }

    public virtual WymCzasDzien RabatCzd { get; set; } = null!;

    public virtual WymCzasDzien? RabatCzdfakt { get; set; }

    public virtual WymCzasDzien? RabatCzdplan { get; set; }

    public virtual WymCzasGodzina? RabatCzg { get; set; }

    public virtual WymCzasDzien RabatCzs { get; set; } = null!;

    public virtual WymCzasDzien? RabatCzw { get; set; }

    public virtual WymCzasDzien? RabatDataDokumentu { get; set; }

    public virtual WymDokumentNumer? RabatDokNumer { get; set; }

    public virtual WymKontrahent? RabatDst { get; set; }

    public virtual WymFirma? RabatFirma { get; set; }

    public virtual WymFormyPlatnosci? RabatFormaPlat { get; set; }

    public virtual WymJednostka? RabatJm { get; set; }

    public virtual WymJednostka? RabatJmp { get; set; }

    public virtual WymKontrahent? RabatKnd { get; set; }

    public virtual WymKontrahent? RabatKnt { get; set; }

    public virtual WymLokalizacja? RabatLok { get; set; }

    public virtual WymMagazyn? RabatMag { get; set; }

    public virtual WymOperator RabatOpemg { get; set; } = null!;

    public virtual WymOperator RabatOperator { get; set; } = null!;

    public virtual WymOperator RabatOpewg { get; set; } = null!;

    public virtual WymOperator RabatOpezg { get; set; } = null!;

    public virtual WymPracownik? RabatOpiekun { get; set; }

    public virtual WymKontrahent? RabatPlat { get; set; }

    public virtual WymPromocje? RabatPrm { get; set; }

    public virtual WymPrecyzjaMiary RabatPrmg { get; set; } = null!;

    public virtual WymProdukt? RabatProd { get; set; }

    public virtual WymProduktPozycjeDok RabatProduktPozycjeDok { get; set; } = null!;

    public virtual WymProjekt? RabatProjekt { get; set; }

    public virtual WymRodzajZakupu? RabatRdzZak { get; set; }

    public virtual WymRejon? RabatRejon { get; set; }

    public virtual WymRodzajCeny RabatRodzCen { get; set; } = null!;

    public virtual WymDokumentNumer? RabatSpiDokNumer { get; set; }

    public virtual WymStrukturaFirmy? RabatStrFrm { get; set; }

    public virtual WymStrukturaPraw? RabatStrPraw { get; set; }

    public virtual WymTypZamowienium? RabatTypZam { get; set; }

    public virtual WymWalutum? RabatWaluta { get; set; }

    public virtual WymZrodloDanych RabatZrodg { get; set; } = null!;
}
