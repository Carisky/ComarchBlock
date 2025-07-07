using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktZakupyPlatnosci
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZptDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ZptId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZptInsertSubTransformationId { get; set; }

    public int ZptInsertTransformationId { get; set; }

    public string? ZptOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZptOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZptTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZptTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZptUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZptUpdateTransformationId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int ZptBudzetId { get; set; }

    public int ZptCechyId { get; set; }

    public int ZptCzdid { get; set; }

    public int ZptCzdterminPlatId { get; set; }

    public int ZptDataDokumentuId { get; set; }

    public int ZptDokNumerId { get; set; }

    public int ZptDstId { get; set; }

    public int ZptFirmaId { get; set; }

    public int ZptFormPlatId { get; set; }

    public int ZptKndId { get; set; }

    public int ZptKntId { get; set; }

    public int ZptLokId { get; set; }

    public int ZptMagId { get; set; }

    public int ZptOpiekunId { get; set; }

    public int ZptPlatnikId { get; set; }

    public int ZptProdId { get; set; }

    public int ZptRdzId { get; set; }

    public int ZptSpiNumerId { get; set; }

    public int ZptStrFrmId { get; set; }

    public int ZptZapId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZptZrodgid { get; set; }

    public decimal? ZptMnaleznosc { get; set; }

    public decimal? ZptMzapadalnosc { get; set; }

    public decimal? ZptMzobowiazanie { get; set; }

    public string? ZptOrgAtrId { get; set; }

    public string? ZptOrgWymId { get; set; }

    public int? ZptPaczka { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? ZptRejonId { get; set; }

    public decimal? ZptMnaleznoscWaluta { get; set; }

    public decimal? ZptMzobowiazanieWaluta { get; set; }

    /// <summary>
    /// Relacja do wymiaru Waluta
    /// </summary>
    public int ZptWalutaId { get; set; }

    public string? ZptWymObjGidLp { get; set; }

    public string? ZptWymTyp { get; set; }

    public string? ZptKierunek { get; set; }

    public string? ZptTypKwoty { get; set; }

    public int ZptProjektId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ZptAlokacjaId { get; set; }

    public string? ZptOrgAtrNagId { get; set; }

    public string? ZptOrgAtrEleId { get; set; }

    public string? ZptOrgAtrSubId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int ZptPrmgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? ZptStrPrwId { get; set; }

    public string? ZptDataMod { get; set; }

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

    public int? Atr028Id { get; set; }

    public int? Atr029Id { get; set; }

    public int? Atr0299Id { get; set; }

    public int? Atr02101Id { get; set; }

    public virtual WymAlokacja ZptAlokacja { get; set; } = null!;

    public virtual WymBudzet ZptBudzet { get; set; } = null!;

    public virtual WymCechy ZptCechy { get; set; } = null!;

    public virtual WymCzasDzien ZptCzd { get; set; } = null!;

    public virtual WymCzasDzien ZptCzdterminPlat { get; set; } = null!;

    public virtual WymCzasDzien ZptDataDokumentu { get; set; } = null!;

    public virtual WymDokumentNumer ZptDokNumer { get; set; } = null!;

    public virtual WymKontrahent ZptDst { get; set; } = null!;

    public virtual WymFirma ZptFirma { get; set; } = null!;

    public virtual WymFormyPlatnosci ZptFormPlat { get; set; } = null!;

    public virtual WymKontrahent ZptKnd { get; set; } = null!;

    public virtual WymKontrahent ZptKnt { get; set; } = null!;

    public virtual WymLokalizacja ZptLok { get; set; } = null!;

    public virtual WymMagazyn ZptMag { get; set; } = null!;

    public virtual WymPracownik ZptOpiekun { get; set; } = null!;

    public virtual WymKontrahent ZptPlatnik { get; set; } = null!;

    public virtual WymPrecyzjaMiary ZptPrmg { get; set; } = null!;

    public virtual WymProdukt ZptProd { get; set; } = null!;

    public virtual WymProjekt ZptProjekt { get; set; } = null!;

    public virtual WymRodzajZakupu ZptRdz { get; set; } = null!;

    public virtual WymRejon? ZptRejon { get; set; }

    public virtual WymDokumentNumer ZptSpiNumer { get; set; } = null!;

    public virtual WymStrukturaFirmy ZptStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? ZptStrPrw { get; set; }

    public virtual WymWalutum ZptWaluta { get; set; } = null!;

    public virtual WymZapadalnosc ZptZap { get; set; } = null!;

    public virtual WymZrodloDanych ZptZrodg { get; set; } = null!;
}
