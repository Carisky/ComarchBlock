using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

/// <summary>
/// Fakt ze środkami trwałymi. Dane zagregowane. Dane prezentowane na koniec miesiąca.
/// </summary>
public partial class FktSrodkiTrwale
{
    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int SrTrCzdgidlikw { get; set; }

    /// <summary>
    /// Relation to dimension Waluta
    /// </summary>
    public int SrTrWalutaGid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int SrTrDokNumerGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int SrTrCzdgiddok { get; set; }

    /// <summary>
    /// Relation to dimension Pracownik
    /// </summary>
    public int SrTrPrcGid { get; set; }

    /// <summary>
    /// Relation to dimension SrodekTrwaly
    /// </summary>
    public int SrTrSrtGid { get; set; }

    /// <summary>
    /// Relation to dimension Samochod
    /// </summary>
    public int SrTrSamgid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int SrTrKntGid { get; set; }

    public int SrTrId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int SrTrZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int SrTrCzdgid { get; set; }

    public string SrTrOrgId { get; set; } = null!;

    public string SrTrDirtyOrgId { get; set; } = null!;

    public string? SrTrOpis { get; set; }

    public DateTime SrTrTsinsert { get; set; }

    public DateTime SrTrTsupdate { get; set; }

    public int SrTrUpdateSubTransformationId { get; set; }

    public int? SrTrUpdateTransformationId { get; set; }

    public int SrTrInsertSubTransformationId { get; set; }

    public int? SrTrInsertTransformationId { get; set; }

    public decimal? SrTrPodstawaPodatkowaSys { get; set; }

    public decimal? SrTrPodstawaBilansowa { get; set; }

    public decimal? SrTrPodstawaBilansowaSys { get; set; }

    public decimal? SrTrAmBilansowa { get; set; }

    public decimal? SrTrAmPodatkowa { get; set; }

    public decimal? SrTrAmBilansowaSys { get; set; }

    public decimal? SrTrAmPodatkowaSys { get; set; }

    public decimal? SrTrPodstawaPodatkowa { get; set; }

    public virtual WymCzasDzien SrTrCzdg { get; set; } = null!;

    public virtual WymCzasDzien SrTrCzdgiddokNavigation { get; set; } = null!;

    public virtual WymCzasDzien SrTrCzdgidlikwNavigation { get; set; } = null!;

    public virtual WymDokumentNumer SrTrDokNumerG { get; set; } = null!;

    public virtual WymKontrahent SrTrKntG { get; set; } = null!;

    public virtual WymPracownik SrTrPrcG { get; set; } = null!;

    public virtual WymSamochod SrTrSamg { get; set; } = null!;

    public virtual WymSrodekTrwaly SrTrSrtG { get; set; } = null!;

    public virtual WymWalutum SrTrWalutaG { get; set; } = null!;

    public virtual WymZrodloDanych SrTrZrodg { get; set; } = null!;
}
