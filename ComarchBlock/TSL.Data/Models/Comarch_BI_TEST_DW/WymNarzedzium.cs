using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymNarzedzium
{
    public int NdzRowId { get; set; }

    public int NdzId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int NdzZrodgid { get; set; }

    public string NdzOrgId { get; set; } = null!;

    public string NdzDirtyOrgId { get; set; } = null!;

    public string NdzNazwa { get; set; } = null!;

    public string? NdzOpis { get; set; }

    public string? NdzParDirtyOrgId { get; set; }

    public string? NdzParCleanOrgId { get; set; }

    public int? NdzParGid { get; set; }

    public DateTime NdzTsinsert { get; set; }

    public DateTime NdzTsupdate { get; set; }

    public DateTime NdzTimeFrom { get; set; }

    public DateTime? NdzTimeTo { get; set; }

    public int NdzChecksumKimball1 { get; set; }

    public int NdzChecksumKimball2 { get; set; }

    public int NdzUpdateSubTransformationId { get; set; }

    public int? NdzUpdateTransformationId { get; set; }

    public int NdzInsertSubTransformationId { get; set; }

    public int? NdzInsertTransformationId { get; set; }

    public byte[] NdzRowVersion { get; set; } = null!;

    /// <summary>
    /// Relation to dimension Zasob
    /// </summary>
    public int NdzZasgid { get; set; }

    /// <summary>
    /// Relation to dimension Zasob
    /// </summary>
    public string NdzZasdirtyOrgId { get; set; } = null!;

    public string? NdzRodzajZasobu { get; set; }

    public string? NdzStatus { get; set; }

    public string? NdzPrzyczynaLikwidacji { get; set; }

    public string? NdzNumerNdz { get; set; }

    public virtual ICollection<FktNarzedziownium> FktNarzedziownia { get; set; } = new List<FktNarzedziownium>();

    public virtual ICollection<FktNarzedziowniaZuzyciaRuchy> FktNarzedziowniaZuzyciaRuchies { get; set; } = new List<FktNarzedziowniaZuzyciaRuchy>();

    public virtual ICollection<FktNarzedziowniaZuzyciaStany> FktNarzedziowniaZuzyciaStanies { get; set; } = new List<FktNarzedziowniaZuzyciaStany>();

    public virtual WymZasob NdzZasg { get; set; } = null!;

    public virtual WymZrodloDanych NdzZrodg { get; set; } = null!;
}
