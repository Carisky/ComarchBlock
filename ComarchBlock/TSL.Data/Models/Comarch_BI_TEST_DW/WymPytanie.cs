using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymPytanie
{
    public int PytRowId { get; set; }

    public int PytId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PytZrodgid { get; set; }

    public string PytOrgId { get; set; } = null!;

    public string PytDirtyOrgId { get; set; } = null!;

    public string? PytNazwa { get; set; }

    public string? PytOpis { get; set; }

    public string? PytParDirtyOrgId { get; set; }

    public string? PytParCleanOrgId { get; set; }

    public int? PytParGid { get; set; }

    public DateTime PytTsinsert { get; set; }

    public DateTime PytTsupdate { get; set; }

    public DateTime PytTimeFrom { get; set; }

    public DateTime? PytTimeTo { get; set; }

    public int PytChecksumKimball1 { get; set; }

    public int PytChecksumKimball2 { get; set; }

    public int PytUpdateSubTransformationId { get; set; }

    public int? PytUpdateTransformationId { get; set; }

    public int PytInsertSubTransformationId { get; set; }

    public int? PytInsertTransformationId { get; set; }

    public byte[] PytRowVersion { get; set; } = null!;

    public decimal? PytPunkty { get; set; }

    public decimal? PytGrupaPunkty { get; set; }

    public string? PytGrupa { get; set; }

    public string? PytTresc { get; set; }

    public string? PytOtwarte { get; set; }

    public virtual ICollection<FktAnkiety> FktAnkieties { get; set; } = new List<FktAnkiety>();

    public virtual WymZrodloDanych PytZrodg { get; set; } = null!;

    public virtual ICollection<WymOdpowiedz> WymOdpowiedzs { get; set; } = new List<WymOdpowiedz>();
}
