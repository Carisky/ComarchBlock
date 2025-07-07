using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPlatnosciRozrachunki
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long RzrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RzrOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RzrDirtyOrgId { get; set; } = null!;

    public string? RzrDescription { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int RzrUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RzrUpdateSubTransformationId { get; set; }

    public int RzrInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RzrInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RzrTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RzrTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int RzrZrodgid { get; set; }

    public int RzrCzdid { get; set; }

    public int? RzrCzmid { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int? RzrBudzetId { get; set; }

    public int? RzrDokNumerId { get; set; }

    public int? RzrSpiNumerId { get; set; }

    public int? RzrFirmaId { get; set; }

    public int? RzrFormPlatId { get; set; }

    public int? RzrKntId { get; set; }

    public int? RzrPlatId { get; set; }

    public int? RzrOpiekunId { get; set; }

    public int? RzrPerspektywaId { get; set; }

    public int? RzrProdId { get; set; }

    public int? RzrWalutaId { get; set; }

    public decimal? RzrMprzelicznikWaluty { get; set; }

    public decimal? RzrMnaleznoscWaluta { get; set; }

    public decimal? RzrMzobowiazanieWaluta { get; set; }

    public decimal? RzrMnaleznosc { get; set; }

    public decimal? RzrMzobowiazanie { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? RzrRejonId { get; set; }

    public int RzrKndId { get; set; }

    public int? RzrCzdterminPlatId { get; set; }

    public int? RzrWymTyp { get; set; }

    public int? RzrKierunek { get; set; }

    public int? RzrTypKwoty { get; set; }

    public string? RzrOrgAtrId { get; set; }

    public string? RzrOrgWymId { get; set; }

    public string? RzrWymObjGidLp { get; set; }

    public int? RzrAkwId { get; set; }

    public int RzrRejestryId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int RzrAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int RzrDataWystawieniaId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int RzrStrFrmId { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int RzrProjektId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int RzrLokId { get; set; }

    public string? RzrOrgAtrNagId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? RzrStrPrwId { get; set; }

    /// <summary>
    /// Relation to dimension Wniosek
    /// </summary>
    public int RzrWnogid { get; set; }

    /// <summary>
    /// Relation to dimension Delegacja
    /// </summary>
    public int RzrDlggid { get; set; }

    public int RzrDokPlaId { get; set; }

    public int RzrPrlvid { get; set; }

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

    public virtual WymKontrahent? RzrAkw { get; set; }

    public virtual WymAlokacja RzrAlokacja { get; set; } = null!;

    public virtual WymBudzet? RzrBudzet { get; set; }

    public virtual WymCzasDzien RzrCzd { get; set; } = null!;

    public virtual WymCzasDzien? RzrCzdterminPlat { get; set; }

    public virtual WymCzasMiesiac? RzrCzm { get; set; }

    public virtual WymCzasDzien RzrDataWystawienia { get; set; } = null!;

    public virtual WymDelegacja RzrDlgg { get; set; } = null!;

    public virtual WymDokumentNumer? RzrDokNumer { get; set; }

    public virtual WymDokumentPlatnosc RzrDokPla { get; set; } = null!;

    public virtual WymFirma? RzrFirma { get; set; }

    public virtual WymFormyPlatnosci? RzrFormPlat { get; set; }

    public virtual WymKontrahent RzrKnd { get; set; } = null!;

    public virtual WymKontrahent? RzrKnt { get; set; }

    public virtual WymLokalizacja RzrLok { get; set; } = null!;

    public virtual WymPracownik? RzrOpiekun { get; set; }

    public virtual WymPerspektywa? RzrPerspektywa { get; set; }

    public virtual WymKontrahent? RzrPlat { get; set; }

    public virtual WymPreliminarz RzrPrlv { get; set; } = null!;

    public virtual WymProdukt? RzrProd { get; set; }

    public virtual WymProjekt RzrProjekt { get; set; } = null!;

    public virtual WymRejestr RzrRejestry { get; set; } = null!;

    public virtual WymRejon? RzrRejon { get; set; }

    public virtual WymDokumentNumer? RzrSpiNumer { get; set; }

    public virtual WymStrukturaFirmy RzrStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? RzrStrPrw { get; set; }

    public virtual WymWalutum? RzrWaluta { get; set; }

    public virtual WymWniosek RzrWnog { get; set; } = null!;

    public virtual WymZrodloDanych RzrZrodg { get; set; } = null!;
}
