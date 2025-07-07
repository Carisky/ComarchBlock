using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymTrasa
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int TraRowId { get; set; }

    public int TraId { get; set; }

    /// <summary>
    /// Identyfikator źródła XL. Relacja do wymiaru WYM_ZrodloDanych.
    /// </summary>
    public int TraZrodgid { get; set; }

    public string TraOrgId { get; set; } = null!;

    public string TraDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Nazwa trasy
    /// </summary>
    public string? TraNazwa { get; set; }

    /// <summary>
    /// Opis trasy
    /// </summary>
    public string? TraOpis { get; set; }

    public string? TraParDirtyOrgId { get; set; }

    public string? TraParCleanOrgId { get; set; }

    public int? TraParGid { get; set; }

    public DateTime TraTsinsert { get; set; }

    public DateTime TraTsupdate { get; set; }

    public DateTime TraTimeFrom { get; set; }

    public DateTime? TraTimeTo { get; set; }

    public int TraChecksumKimball1 { get; set; }

    public int TraChecksumKimball2 { get; set; }

    public int TraUpdateTransformationId { get; set; }

    public int? TraUpdateSubTransformationId { get; set; }

    public int TraInsertTransformationId { get; set; }

    public int? TraInsertSubTransformationId { get; set; }

    public byte[] TraRowVersion { get; set; } = null!;

    /// <summary>
    /// Lokalizacja związana z centrum struktury praw. W centrum, w którym będzie generowana paczka, będzie można wybrać taką trasę, która ma lokalizację zgodną z lokalizacją wskazaną dla tego centrum
    /// </summary>
    public string? TraLokalizacja { get; set; }

    /// <summary>
    /// Kod przypisany do trasy
    /// </summary>
    public string? TraKod { get; set; }

    public virtual ICollection<FktTransport> FktTransports { get; set; } = new List<FktTransport>();

    public virtual WymZrodloDanych TraZrodg { get; set; } = null!;
}
