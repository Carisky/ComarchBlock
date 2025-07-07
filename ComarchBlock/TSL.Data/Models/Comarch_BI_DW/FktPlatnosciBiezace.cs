using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPlatnosciBiezace
{
    public string? PlbDescription { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PlbDirtyOrgId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long PlbId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PlbInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PlbOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PlbTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PlbTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PlbUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PlbUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int PlbBudzetId { get; set; }

    public int PlbCrmEtapId { get; set; }

    public int PlbCzdid { get; set; }

    public int PlbCzmid { get; set; }

    public int PlbDokNumerId { get; set; }

    public int PlbFirmaId { get; set; }

    public int PlbFormPlatId { get; set; }

    public int PlbKntId { get; set; }

    public int PlbOpiekunId { get; set; }

    public int PlbPerspektywaId { get; set; }

    public int PlbPlatId { get; set; }

    public int PlbSpiNumerId { get; set; }

    public int PlbSpZapId { get; set; }

    public int PlbWalutaId { get; set; }

    public int PlbZapId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PlbZrodgid { get; set; }

    public decimal? PlbMnaleznosc { get; set; }

    public decimal? PlbMspodziewanaZapadalnosc { get; set; }

    public decimal? PlbMzapadalnosc { get; set; }

    public decimal? PlbMzobowiazanie { get; set; }

    public int? PlbDataSpZapadalnoscId { get; set; }

    public int? PlbDataZapadalnoscId { get; set; }

    public int? PlbKierunek { get; set; }

    public string? PlbOrgAtrId { get; set; }

    public string? PlbOrgWymId { get; set; }

    public int? PlbPaczka { get; set; }

    public decimal? PlbPrzelicznikWaluty { get; set; }

    public int? PlbTypKwoty { get; set; }

    public string? PlbWymObjGidLp { get; set; }

    public int? PlbWymTyp { get; set; }

    public int? PlbProdId { get; set; }

    public decimal? PlbMnaleznoscWaluta { get; set; }

    public decimal? PlbMzobowiazanieWaluta { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? PlbRejonId { get; set; }

    public int PlbKndId { get; set; }

    public int PlbCzdterminPlatId { get; set; }

    public int PlbZap2Id { get; set; }

    public int PlbSpZap2Id { get; set; }

    public int? PlbAkwId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int PlbAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int PlbProjektId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PlbStrFrmId { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int PlbLokId { get; set; }

    public string? PlbOrgAtrNagId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? PlbStrPrwId { get; set; }

    /// <summary>
    /// Relation to dimension Delegacja
    /// </summary>
    public int PlbDlggid { get; set; }

    /// <summary>
    /// Relation to dimension Wniosek
    /// </summary>
    public int PlbWnogid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PlbDataWystawienia { get; set; }

    public int PlbPrlvid { get; set; }

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

    public virtual WymKontrahent? PlbAkw { get; set; }

    public virtual WymAlokacja PlbAlokacja { get; set; } = null!;

    public virtual WymBudzet PlbBudzet { get; set; } = null!;

    public virtual WymCrmetapy PlbCrmEtap { get; set; } = null!;

    public virtual WymCzasDzien PlbCzd { get; set; } = null!;

    public virtual WymCzasDzien PlbCzdterminPlat { get; set; } = null!;

    public virtual WymCzasMiesiac PlbCzm { get; set; } = null!;

    public virtual WymCzasDzien PlbDataWystawieniaNavigation { get; set; } = null!;

    public virtual WymDelegacja PlbDlgg { get; set; } = null!;

    public virtual WymDokumentNumer PlbDokNumer { get; set; } = null!;

    public virtual WymFirma PlbFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci PlbFormPlat { get; set; } = null!;

    public virtual WymKontrahent PlbKnd { get; set; } = null!;

    public virtual WymKontrahent PlbKnt { get; set; } = null!;

    public virtual WymLokalizacja PlbLok { get; set; } = null!;

    public virtual WymPracownik PlbOpiekun { get; set; } = null!;

    public virtual WymPerspektywa PlbPerspektywa { get; set; } = null!;

    public virtual WymKontrahent PlbPlat { get; set; } = null!;

    public virtual WymPreliminarz PlbPrlv { get; set; } = null!;

    public virtual WymProdukt? PlbProd { get; set; }

    public virtual WymProjekt PlbProjekt { get; set; } = null!;

    public virtual WymRejon? PlbRejon { get; set; }

    public virtual WymSpodziewanaZapadalnosc PlbSpZap { get; set; } = null!;

    public virtual WymSpodziewanaZapadalnosc2 PlbSpZap2 { get; set; } = null!;

    public virtual WymDokumentNumer PlbSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy PlbStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? PlbStrPrw { get; set; }

    public virtual WymWalutum PlbWaluta { get; set; } = null!;

    public virtual WymWniosek PlbWnog { get; set; } = null!;

    public virtual WymZapadalnosc PlbZap { get; set; } = null!;

    public virtual WymZapadalnosc2 PlbZap2 { get; set; } = null!;

    public virtual WymZrodloDanych PlbZrodg { get; set; } = null!;
}
