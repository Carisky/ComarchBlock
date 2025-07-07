using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymPlecGu
{
    public int PlcChecksumKimball1 { get; set; }

    public int PlcChecksumKimball2 { get; set; }

    public string PlcDirtyOrgId { get; set; } = null!;

    public int PlcId { get; set; }

    public int? PlcInsertSubTransformationId { get; set; }

    public int PlcInsertTransformationId { get; set; }

    public string PlcNazwa { get; set; } = null!;

    public string? PlcOpis { get; set; }

    public string PlcOrgId { get; set; } = null!;

    public string? PlcParDirtyOrgId { get; set; }

    public int? PlcParGid { get; set; }

    public string? PlcParOrgId { get; set; }

    public int? PlcRowId { get; set; }

    public byte[] PlcRowVersion { get; set; } = null!;

    public DateTime PlcTimeFrom { get; set; }

    public DateTime? PlcTimeTo { get; set; }

    public DateTime PlcTsinsert { get; set; }

    public DateTime PlcTsupdate { get; set; }

    public int? PlcUpdateSubTransformationId { get; set; }

    public int PlcUpdateTransformationId { get; set; }

    public int PlcZrodgid { get; set; }
}
