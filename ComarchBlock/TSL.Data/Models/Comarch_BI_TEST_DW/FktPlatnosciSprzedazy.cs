using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPlatnosciSprzedazy
{
    /// <summary>
    /// Opis
    /// </summary>
    public string? PlsDescription { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PlsDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PlsId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PlsInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PlsOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PlsTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PlsTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PlsUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PlsUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Kontrahent
    /// </summary>
    public int PlsAkwId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Staz Klienta
    /// </summary>
    public int PlsAkwStazId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int PlsBudzetId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Cechy
    /// </summary>
    public int PlsCechyId { get; set; }

    /// <summary>
    /// Relacja do wymiaru CRM Etap
    /// </summary>
    public int PlsCrmEtapId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Czas Dzien
    /// </summary>
    public int PlsCzdid { get; set; }

    public int PlsCzmid { get; set; }

    public int PlsDokNumerId { get; set; }

    public int PlsDstId { get; set; }

    public int PlsFirmaId { get; set; }

    public int PlsFormPlatId { get; set; }

    public int PlsKatFinId { get; set; }

    public int PlsKndId { get; set; }

    public int PlsKndStazId { get; set; }

    public int PlsKntId { get; set; }

    public int PlsKntStazId { get; set; }

    public int PlsLokId { get; set; }

    public int PlsMagId { get; set; }

    public int PlsMsklId { get; set; }

    public int PlsOpiekunId { get; set; }

    public int PlsPerspektywaId { get; set; }

    public int PlsPlatId { get; set; }

    public int PlsPracownikId { get; set; }

    public int PlsProdId { get; set; }

    public int PlsProdStazId { get; set; }

    public int PlsProjektId { get; set; }

    public int PlsRksId { get; set; }

    public int PlsSpiNumerId { get; set; }

    public int PlsSpZapId { get; set; }

    public int PlsStrFrmId { get; set; }

    public int PlsWalutaId { get; set; }

    public int PlsZapId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PlsZrodgid { get; set; }

    public decimal? PlsMnaleznosc { get; set; }

    public decimal? PlsMplatNaleznosc { get; set; }

    public decimal? PlsMplatZobowiazanie { get; set; }

    public decimal? PlsMspodziewanaZapadalnosc { get; set; }

    public decimal? PlsMzapadalnosc { get; set; }

    public decimal? PlsMzobowiazanie { get; set; }

    public int? PlsAnulowany { get; set; }

    public int? PlsDataSpZapadalnoscId { get; set; }

    public int? PlsDataZapadalnoscId { get; set; }

    public int? PlsDstStazId { get; set; }

    public int? PlsKierunek { get; set; }

    public string? PlsOrgAtrId { get; set; }

    public string? PlsOrgWymId { get; set; }

    public int? PlsPaczka { get; set; }

    public int? PlsPlatStazId { get; set; }

    public int? PlsPozycjaId { get; set; }

    public decimal? PlsPrzelicznikWaluty { get; set; }

    public int? PlsTypKwoty { get; set; }

    public string? PlsWymObjGidLp { get; set; }

    public int? PlsWymTyp { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? PlsRejonId { get; set; }

    public decimal? PlsMnaleznoscWaluta { get; set; }

    public decimal? PlsMzobowiazanieWaluta { get; set; }

    /// <summary>
    /// Relacja do wymiaru Pracownik
    /// </summary>
    public int PlsOpiekunSpinaczId { get; set; }

    /// <summary>
    /// Identyfikator adresu kontrahenta docelowego. Relacja do wymiaru Adres
    /// </summary>
    public int? PlsAdrKndId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Czas Dzien
    /// </summary>
    public int? PlsCzdterminPlatId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Cennik
    /// </summary>
    public int PlsCennikId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int PlsAlokacjaId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Czas Dzien
    /// </summary>
    public int PlsDataDokumentuId { get; set; }

    public string? PlsOrgAtrNagId { get; set; }

    public string? PlsOrgAtrEleId { get; set; }

    public string? PlsOrgAtrSubId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int PlsPrmgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? PlsStrPrwId { get; set; }

    /// <summary>
    /// Relacja do wymiaru RodzajCeny
    /// </summary>
    public int PlsRodzCenId { get; set; }

    public string? PlsDataMod { get; set; }

    public int PlsCzdprzyjeciaWydaniaId { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Atr0213Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public virtual WymAdre? PlsAdrKnd { get; set; }

    public virtual WymKontrahent PlsAkw { get; set; } = null!;

    public virtual WymStazKlientum PlsAkwStaz { get; set; } = null!;

    public virtual WymAlokacja PlsAlokacja { get; set; } = null!;

    public virtual WymBudzet PlsBudzet { get; set; } = null!;

    public virtual WymCechy PlsCechy { get; set; } = null!;

    public virtual WymCennik PlsCennik { get; set; } = null!;

    public virtual WymCrmetapy PlsCrmEtap { get; set; } = null!;

    public virtual WymCzasDzien PlsCzd { get; set; } = null!;

    public virtual WymCzasDzien PlsCzdprzyjeciaWydania { get; set; } = null!;

    public virtual WymCzasDzien? PlsCzdterminPlat { get; set; }

    public virtual WymCzasMiesiac PlsCzm { get; set; } = null!;

    public virtual WymCzasDzien PlsDataDokumentu { get; set; } = null!;

    public virtual WymDokumentNumer PlsDokNumer { get; set; } = null!;

    public virtual WymKontrahent PlsDst { get; set; } = null!;

    public virtual WymFirma PlsFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci PlsFormPlat { get; set; } = null!;

    public virtual WymKategorieFinansowe PlsKatFin { get; set; } = null!;

    public virtual WymKontrahent PlsKnd { get; set; } = null!;

    public virtual WymStazKlientum PlsKndStaz { get; set; } = null!;

    public virtual WymKontrahent PlsKnt { get; set; } = null!;

    public virtual WymStazKlientum PlsKntStaz { get; set; } = null!;

    public virtual WymLokalizacja PlsLok { get; set; } = null!;

    public virtual WymMagazyn PlsMag { get; set; } = null!;

    public virtual WymMiejsceSkladowanium PlsMskl { get; set; } = null!;

    public virtual WymPracownik PlsOpiekun { get; set; } = null!;

    public virtual WymPracownik PlsOpiekunSpinacz { get; set; } = null!;

    public virtual WymPerspektywa PlsPerspektywa { get; set; } = null!;

    public virtual WymKontrahent PlsPlat { get; set; } = null!;

    public virtual WymPracownik PlsPracownik { get; set; } = null!;

    public virtual WymPrecyzjaMiary PlsPrmg { get; set; } = null!;

    public virtual WymProdukt PlsProd { get; set; } = null!;

    public virtual WymStazKlientum PlsProdStaz { get; set; } = null!;

    public virtual WymProjekt PlsProjekt { get; set; } = null!;

    public virtual WymRejon? PlsRejon { get; set; }

    public virtual WymRodzajKosztuSprzedazy PlsRks { get; set; } = null!;

    public virtual WymRodzajCeny PlsRodzCen { get; set; } = null!;

    public virtual WymSpodziewanaZapadalnosc PlsSpZap { get; set; } = null!;

    public virtual WymDokumentNumer PlsSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy PlsStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? PlsStrPrw { get; set; }

    public virtual WymWalutum PlsWaluta { get; set; } = null!;

    public virtual WymZapadalnosc PlsZap { get; set; } = null!;

    public virtual WymZrodloDanych PlsZrodg { get; set; } = null!;
}
