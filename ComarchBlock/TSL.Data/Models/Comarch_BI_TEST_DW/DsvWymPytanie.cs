using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymPytanie
{
    public int PytChecksumKimball1 { get; set; }

    public int PytChecksumKimball2 { get; set; }

    public string PytDirtyOrgId { get; set; } = null!;

    public string? PytGrupa { get; set; }

    public decimal? PytGrupaPunkty { get; set; }

    public int PytId { get; set; }

    public int PytInsertSubTransformationId { get; set; }

    public int? PytInsertTransformationId { get; set; }

    public string? PytNazwa { get; set; }

    public string? PytOpis { get; set; }

    public string PytOrgId { get; set; } = null!;

    public string? PytOtwarte { get; set; }

    public string? PytParCleanOrgId { get; set; }

    public string? PytParDirtyOrgId { get; set; }

    public int? PytParGid { get; set; }

    public decimal? PytPunkty { get; set; }

    public int? PytRowId { get; set; }

    public byte[] PytRowVersion { get; set; } = null!;

    public DateTime PytTimeFrom { get; set; }

    public DateTime? PytTimeTo { get; set; }

    public string? PytTresc { get; set; }

    public DateTime PytTsinsert { get; set; }

    public DateTime PytTsupdate { get; set; }

    public int PytUpdateSubTransformationId { get; set; }

    public int? PytUpdateTransformationId { get; set; }

    public int PytZrodgid { get; set; }
}
