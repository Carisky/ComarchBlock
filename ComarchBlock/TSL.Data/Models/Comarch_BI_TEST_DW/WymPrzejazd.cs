using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymPrzejazd
{
    public int PrzRowId { get; set; }

    public int PrzId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PrzZrodgid { get; set; }

    public string PrzOrgId { get; set; } = null!;

    public string PrzDirtyOrgId { get; set; } = null!;

    public string? PrzNazwa { get; set; }

    public string? PrzOpis { get; set; }

    public string? PrzParDirtyOrgId { get; set; }

    public string? PrzParCleanOrgId { get; set; }

    public int? PrzParGid { get; set; }

    public DateTime PrzTsinsert { get; set; }

    public DateTime PrzTsupdate { get; set; }

    public DateTime PrzTimeFrom { get; set; }

    public DateTime? PrzTimeTo { get; set; }

    public int PrzChecksumKimball1 { get; set; }

    public int PrzChecksumKimball2 { get; set; }

    public int PrzUpdateSubTransformationId { get; set; }

    public int? PrzUpdateTransformationId { get; set; }

    public int PrzInsertSubTransformationId { get; set; }

    public int? PrzInsertTransformationId { get; set; }

    public byte[] PrzRowVersion { get; set; } = null!;

    public string? PrzRodzaj { get; set; }

    public string? PrzTyp { get; set; }

    public string? PrzWyjazdZ { get; set; }

    public string? PrzDojazdDo { get; set; }

    public virtual ICollection<FktWizytyElement> FktWizytyElements { get; set; } = new List<FktWizytyElement>();

    public virtual WymZrodloDanych PrzZrodg { get; set; } = null!;
}
