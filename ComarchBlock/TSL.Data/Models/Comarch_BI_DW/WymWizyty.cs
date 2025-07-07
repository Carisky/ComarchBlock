using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymWizyty
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int WzwRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int WzwId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int WzwZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WzwOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WzwDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Nazwa wizyty handlowej
    /// </summary>
    public string WzwNazwa { get; set; } = null!;

    /// <summary>
    /// Opis wizyty handlowej
    /// </summary>
    public string? WzwOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WzwParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WzwParCleanOrgId { get; set; }

    public int? WzwParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WzwTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WzwTsupdate { get; set; }

    public DateTime WzwTimeFrom { get; set; }

    public DateTime? WzwTimeTo { get; set; }

    public int WzwChecksumKimball1 { get; set; }

    public int WzwChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int WzwUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WzwUpdateSubTransformationId { get; set; }

    public int WzwInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WzwInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] WzwRowVersion { get; set; } = null!;

    /// <summary>
    /// Relacja do wymiaru CechaTransakcji
    /// </summary>
    public int? WzwCechaTransakcjiId { get; set; }

    /// <summary>
    /// Relacja do wymiaru KodFiaska
    /// </summary>
    public int? WzwKodFiaskaId { get; set; }

    /// <summary>
    /// Relacja do wymiaru SposobDostawy
    /// </summary>
    public int? WzwSposobDostawyId { get; set; }

    /// <summary>
    /// Relacja do wymiaru DokumentStatus
    /// </summary>
    public int? WzwDokStatusId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Operator
    /// </summary>
    public int? WzwOperatorId { get; set; }

    /// <summary>
    /// Relacja do wymiaru DokumentTyp
    /// </summary>
    public int? WzwDokTypId { get; set; }

    /// <summary>
    /// Relacja do wymiaru DokumentSeria
    /// </summary>
    public int? WzwDokSeriaId { get; set; }

    /// <summary>
    /// Typ wizyty handlowej
    /// </summary>
    public string? WzwTyp { get; set; }

    /// <summary>
    /// Pole techniczne.
    /// </summary>
    public string? WzwOrgAtrId { get; set; }

    /// <summary>
    /// Pełny numer dokumentu wizyty
    /// </summary>
    public string? WzwPelnyNumer { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? WzwSpiOrgId { get; set; }

    public string? WzwGrupowanie { get; set; }

    public int? WzwAktywny { get; set; }

    public string? WzwKosztUstalono { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu wizyty handlowej
    /// </summary>
    public string? WzwDataDokumentu { get; set; }

    public string? WzwGodzRozpPlan { get; set; }

    public string? WzwGodzRozpRzecz { get; set; }

    public string? WzwGodzZakPlan { get; set; }

    public string? WzwGodzZakRzecz { get; set; }

    public string? WzwWzorzec { get; set; }

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual WymCechaTransakcji? WzwCechaTransakcji { get; set; }

    public virtual WymDokumentSerium? WzwDokSeria { get; set; }

    public virtual WymDokumentStatus? WzwDokStatus { get; set; }

    public virtual WymDokumentTyp? WzwDokTyp { get; set; }

    public virtual WymKodFiaska? WzwKodFiaska { get; set; }

    public virtual WymOperator? WzwOperator { get; set; }

    public virtual WymSposobDostawy? WzwSposobDostawy { get; set; }

    public virtual WymZrodloDanych WzwZrodg { get; set; } = null!;
}
