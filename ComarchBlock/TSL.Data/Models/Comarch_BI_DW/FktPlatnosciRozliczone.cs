using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPlatnosciRozliczone
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZapDirtyOrgId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ZapId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapInsertSubTransformationId { get; set; }

    public string? ZapOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZapOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZapTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZapTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapUpdateTransformationId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int ZapBudzetId { get; set; }

    public int ZapCzdid { get; set; }

    public int ZapCzmid { get; set; }

    public int ZapDokNumerId { get; set; }

    public int ZapFirmaId { get; set; }

    public int ZapKazNumerId { get; set; }

    public int ZapKntId { get; set; }

    public int ZapKntPlaskiId { get; set; }

    public int ZapPerspektywaId { get; set; }

    public int ZapPlatId { get; set; }

    public int ZapPlatNumerId { get; set; }

    public int ZapSpiNumerId { get; set; }

    public int ZapWalutaId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZapZrodgid { get; set; }

    public decimal? ZapMwplata { get; set; }

    public decimal? ZapMwyplata { get; set; }

    public int? ZapKazDataDokumentu { get; set; }

    public int? ZapKazDataZapisu { get; set; }

    public int? ZapKierunek { get; set; }

    public string? ZapOrgAtrId { get; set; }

    public string? ZapOrgWymId { get; set; }

    public int? ZapPaczka { get; set; }

    public int? ZapPoDacieSprzedazy { get; set; }

    public int? ZapPoTerminiePlatnosci { get; set; }

    public int? ZapPrlvData { get; set; }

    public decimal? ZapPrzelicznikWaluty { get; set; }

    public int? ZapRozDataRozliczenia { get; set; }

    public int? ZapRozDataRozrachunku { get; set; }

    public int? ZapTrpTermin { get; set; }

    public int? ZapTypKwoty { get; set; }

    public string? ZapWymObjGidLp { get; set; }

    public int? ZapWymTyp { get; set; }

    public int ZapFormPlatId { get; set; }

    public int ZapOpiekunId { get; set; }

    public int ZapProdId { get; set; }

    public decimal? ZapMwplataWaluta { get; set; }

    public decimal? ZapMwyplataWaluta { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? ZapRejonId { get; set; }

    public int ZapKndId { get; set; }

    public int? ZapCzdterminPlatId { get; set; }

    public int ZapStrFrmId { get; set; }

    public int ZapProjektId { get; set; }

    public int ZapLokId { get; set; }

    public int? ZapCzdterminId { get; set; }

    public int ZapDokNumerLokataId { get; set; }

    public int? ZapLokata { get; set; }

    public int ZapLokataId { get; set; }

    public int ZapLokStId { get; set; }

    public int? ZapCzddataOtwarciaId { get; set; }

    public decimal? ZapMoprocentowanie { get; set; }

    public int ZapZapId { get; set; }

    public decimal? ZapMzapadalnosc { get; set; }

    public int ZapZap2Id { get; set; }

    public int? ZapAkwId { get; set; }

    public decimal? ZapMkompensacjaNaleznosciSys { get; set; }

    public decimal? ZapMkompensacjaNaleznosciWaluta { get; set; }

    public decimal? ZapMkompensacjaZobowiazanSys { get; set; }

    public decimal? ZapMkompensacjaZobowiazanWaluta { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZapAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int ZapDataWystawieniaId { get; set; }

    public string? ZapOrgAtrNagId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? ZapStrPrwId { get; set; }

    public int ZapRejestryId { get; set; }

    public int ZapDokPlaId { get; set; }

    public int ZapPrlvid { get; set; }

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

    public virtual WymKontrahent? ZapAkw { get; set; }

    public virtual WymAlokacja ZapAlokacja { get; set; } = null!;

    public virtual WymBudzet ZapBudzet { get; set; } = null!;

    public virtual WymCzasDzien ZapCzd { get; set; } = null!;

    public virtual WymCzasDzien? ZapCzddataOtwarcia { get; set; }

    public virtual WymCzasDzien? ZapCzdtermin { get; set; }

    public virtual WymCzasDzien? ZapCzdterminPlat { get; set; }

    public virtual WymCzasMiesiac ZapCzm { get; set; } = null!;

    public virtual WymCzasDzien ZapDataWystawienia { get; set; } = null!;

    public virtual WymDokumentNumer ZapDokNumer { get; set; } = null!;

    public virtual WymDokumentNumer ZapDokNumerLokata { get; set; } = null!;

    public virtual WymDokumentPlatnosc ZapDokPla { get; set; } = null!;

    public virtual WymFirma ZapFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci ZapFormPlat { get; set; } = null!;

    public virtual WymDokumentNumer ZapKazNumer { get; set; } = null!;

    public virtual WymKontrahent ZapKnd { get; set; } = null!;

    public virtual WymKontrahent ZapKnt { get; set; } = null!;

    public virtual WymKontrahent ZapKntPlaski { get; set; } = null!;

    public virtual WymLokalizacja ZapLok { get; set; } = null!;

    public virtual WymLokataStatus ZapLokSt { get; set; } = null!;

    public virtual WymLokatum ZapLokataNavigation { get; set; } = null!;

    public virtual WymPracownik ZapOpiekun { get; set; } = null!;

    public virtual WymPerspektywa ZapPerspektywa { get; set; } = null!;

    public virtual WymKontrahent ZapPlat { get; set; } = null!;

    public virtual WymDokumentNumer ZapPlatNumer { get; set; } = null!;

    public virtual WymPreliminarz ZapPrlv { get; set; } = null!;

    public virtual WymProdukt ZapProd { get; set; } = null!;

    public virtual WymProjekt ZapProjekt { get; set; } = null!;

    public virtual WymRejestr ZapRejestry { get; set; } = null!;

    public virtual WymRejon? ZapRejon { get; set; }

    public virtual WymDokumentNumer ZapSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy ZapStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? ZapStrPrw { get; set; }

    public virtual WymWalutum ZapWaluta { get; set; } = null!;

    public virtual WymZapadalnosc ZapZap { get; set; } = null!;

    public virtual WymZapadalnosc2 ZapZap2 { get; set; } = null!;

    public virtual WymZrodloDanych ZapZrodg { get; set; } = null!;
}
