using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktReklamacje
{
    public int? ReklKntId { get; set; }

    public int? ReklKndId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int? ReklBudzetId { get; set; }

    public int? ReklCechaId { get; set; }

    public int? ReklOpiekunId { get; set; }

    public int? ReklZrdDokNumerId { get; set; }

    public int? ReklProdId { get; set; }

    public int? ReklAkwId { get; set; }

    public int? ReklDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ReklId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ReklZrodgid { get; set; }

    public int ReklCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ReklOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ReklDirtyOrgId { get; set; } = null!;

    public string? ReklOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ReklUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ReklUpdateSubTransformationId { get; set; }

    public int ReklInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ReklInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ReklTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ReklTsupdate { get; set; }

    public string? ReklOrgAtrId { get; set; }

    public int? ReklNagStatus { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ReklElemOrgId { get; set; }

    public decimal? ReklMilosc { get; set; }

    public decimal? ReklMwartosc { get; set; }

    public int? ReklZadanieId { get; set; }

    public int? ReklPerspektywaId { get; set; }

    public int? ReklStrFrmGid { get; set; }

    public int? ReklCzzgid { get; set; }

    public int? ReklReklEid { get; set; }

    public decimal? ReklMczasZamkniecia { get; set; }

    public int? ReklTyp { get; set; }

    public decimal? ReklMczasRozpatrzenia { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int ReklAlokacjaId { get; set; }

    public string? ReklOrgAtrNagId { get; set; }

    public string? ReklOrgAtrEleId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? ReklStrPrwId { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int ReklOpeId { get; set; }

    /// <summary>
    /// Relation to dimension PrzyczynaReklamacji
    /// </summary>
    public int ReklPreklgid { get; set; }

    public int ReklRkreid { get; set; }

    public string? ReklZrdDokNumer { get; set; }

    public virtual WymCzasDzien ReklCzd { get; set; } = null!;

    public virtual WymCzasDzien? ReklCzzg { get; set; }
}
