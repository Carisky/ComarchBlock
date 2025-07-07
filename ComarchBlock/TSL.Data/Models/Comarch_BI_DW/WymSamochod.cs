using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Tabela zawiera dane dotyczące samochodów
/// </summary>
public partial class WymSamochod
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int SamRowId { get; set; }

    public int SamId { get; set; }

    /// <summary>
    /// Identyfikator źródła XL. Relacja do wymiaru WYM_ZrodloDanych.
    /// </summary>
    public int SamZrodgid { get; set; }

    public string SamOrgId { get; set; } = null!;

    public string SamDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Nazwa samochodu
    /// </summary>
    public string SamNazwa { get; set; } = null!;

    /// <summary>
    /// Opis samochodu
    /// </summary>
    public string? SamOpis { get; set; }

    public string? SamParDirtyOrgId { get; set; }

    public string? SamParCleanOrgId { get; set; }

    public int? SamParGid { get; set; }

    public DateTime SamTsinsert { get; set; }

    public DateTime SamTsupdate { get; set; }

    public DateTime SamTimeFrom { get; set; }

    public DateTime? SamTimeTo { get; set; }

    public int SamChecksumKimball1 { get; set; }

    public int SamChecksumKimball2 { get; set; }

    public int SamUpdateTransformationId { get; set; }

    public int? SamUpdateSubTransformationId { get; set; }

    public int SamInsertTransformationId { get; set; }

    public int? SamInsertSubTransformationId { get; set; }

    public byte[] SamRowVersion { get; set; } = null!;

    /// <summary>
    /// Numer rejestracyjny samochodu.
    /// </summary>
    public string? SamNrRejestracyjny { get; set; }

    /// <summary>
    /// Marka samochodu
    /// </summary>
    public string? SamMarka { get; set; }

    /// <summary>
    /// Ładowność samochodu określona w tonach [t].
    /// </summary>
    public string? SamLadownosc { get; set; }

    /// <summary>
    /// Rok produkcji samochodu
    /// </summary>
    public int? SamRokProdukcji { get; set; }

    /// <summary>
    /// Polisa wykupiona na dany samochód
    /// </summary>
    public string? SamPolisa { get; set; }

    /// <summary>
    /// Data ważności wykupionej polisy
    /// </summary>
    public string? SamPolisaDataWaznosci { get; set; }

    /// <summary>
    /// Data ważności badań technicznych samochodu
    /// </summary>
    public string? SamBadaniaDataWaznosci { get; set; }

    public string? SamOrgAtrId { get; set; }

    public virtual ICollection<FktTransport> FktTransports { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual WymZrodloDanych SamZrodg { get; set; } = null!;
}
