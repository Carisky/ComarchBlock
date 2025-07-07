using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktKonwersacje
{
    public int? KamDataDoId { get; set; }

    public int? KamDataOdId { get; set; }

    public int KamCrmetapId { get; set; }

    public int KamDokNumerId { get; set; }

    public int KamCrmkampId { get; set; }

    public int KamKntId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long KamId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KamZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KamCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KamDirtyOrgId { get; set; } = null!;

    public string? KamOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KamUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KamUpdateSubTransformationId { get; set; }

    public int KamInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KamInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KamTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KamTsupdate { get; set; }

    public decimal? KamMprzychodP { get; set; }

    public decimal? KamMprzychodR { get; set; }

    public decimal? KamMkosztP { get; set; }

    public decimal? KamMkosztR { get; set; }

    public decimal? KamMiloscP { get; set; }

    public decimal? KamMiloscR { get; set; }

    public decimal? KamMszansaP { get; set; }

    public int KamAkwId { get; set; }

    public int KamOsoId { get; set; }

    public int KamOpeId { get; set; }

    public int KamKtkId { get; set; }

    public int KamSktId { get; set; }

    public decimal? KamMliczbaInKampAkt { get; set; }

    public decimal? KamMliczbaInKampNakt { get; set; }

    public decimal? KamMsprzedaz { get; set; }

    public decimal? KamMczasPodjecia { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KamKnwOrgId { get; set; }

    public int KamCzdid { get; set; }

    public int? KamDataZakonczeniaKntId { get; set; }

    public int? KamDataRozpoczeciaKntId { get; set; }

    public int KamTyp { get; set; }

    public int KamObkId { get; set; }

    public int KamOpeDid { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int KamBudzetId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int KamRejonId { get; set; }

    public string? KamOrgAtrId { get; set; }

    public decimal? KamMprzychodO { get; set; }

    public int? KamKdzId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int KamAlokacjaId { get; set; }

    public int KamTypKntEtapId { get; set; }

    public int KamCrmkampZrdId { get; set; }

    public int KamCrmetapZrdId { get; set; }

    public virtual WymKontrahent KamAkw { get; set; } = null!;

    public virtual WymAlokacja KamAlokacja { get; set; } = null!;

    public virtual WymBudzet KamBudzet { get; set; } = null!;

    public virtual WymCrmetapy KamCrmetap { get; set; } = null!;

    public virtual WymCrmetapy KamCrmetapZrd { get; set; } = null!;

    public virtual WymCrmkampanium KamCrmkamp { get; set; } = null!;

    public virtual WymCrmkampanium KamCrmkampZrd { get; set; } = null!;

    public virtual WymCzasDzien KamCzd { get; set; } = null!;

    public virtual WymCzasDzien? KamDataDo { get; set; }

    public virtual WymCzasDzien? KamDataOd { get; set; }

    public virtual WymCzasDzien? KamDataRozpoczeciaKnt { get; set; }

    public virtual WymCzasDzien? KamDataZakonczeniaKnt { get; set; }

    public virtual WymDokumentNumer KamDokNumer { get; set; } = null!;

    public virtual WymKodZakonczenium? KamKdz { get; set; }

    public virtual WymKontrahent KamKnt { get; set; } = null!;

    public virtual WymKontakt KamKtk { get; set; } = null!;

    public virtual WymObszarKonwersacji KamObk { get; set; } = null!;

    public virtual WymOperator KamOpe { get; set; } = null!;

    public virtual WymOperator KamOpeD { get; set; } = null!;

    public virtual WymOsoba KamOso { get; set; } = null!;

    public virtual WymRejon KamRejon { get; set; } = null!;

    public virtual WymStanKontrahentum KamSkt { get; set; } = null!;

    public virtual WymTypKontrahentaEtap KamTypKntEtap { get; set; } = null!;

    public virtual WymZrodloDanych KamZrodg { get; set; } = null!;
}
