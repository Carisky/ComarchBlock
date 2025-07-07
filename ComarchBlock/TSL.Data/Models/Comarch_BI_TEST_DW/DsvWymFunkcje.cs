using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymFunkcje
{
    public int? PfuRowId { get; set; }

    public int PfuId { get; set; }

    public int PfuZrodgid { get; set; }

    public string PfuOrgId { get; set; } = null!;

    public string PfuDirtyOrgId { get; set; } = null!;

    public string PfuNazwa { get; set; } = null!;

    public string? PfuOpis { get; set; }

    public string? PfuParDirtyOrgId { get; set; }

    public string? PfuParCleanOrgId { get; set; }

    public int? PfuParGid { get; set; }

    public DateTime PfuTsinsert { get; set; }

    public DateTime PfuTsupdate { get; set; }

    public DateTime PfuTimeFrom { get; set; }

    public DateTime? PfuTimeTo { get; set; }

    public int PfuChecksumKimball1 { get; set; }

    public int PfuChecksumKimball2 { get; set; }

    public int PfuUpdateSubTransformationId { get; set; }

    public int? PfuUpdateTransformationId { get; set; }

    public int PfuInsertSubTransformationId { get; set; }

    public int? PfuInsertTransformationId { get; set; }

    public byte[] PfuRowVersion { get; set; } = null!;
}
