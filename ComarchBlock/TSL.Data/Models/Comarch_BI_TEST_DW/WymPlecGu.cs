using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymPlecGu
{
    public int PlcRowId { get; set; }

    public int PlcId { get; set; }

    public int PlcZrodgid { get; set; }

    public string PlcOrgId { get; set; } = null!;

    public string PlcDirtyOrgId { get; set; } = null!;

    public string PlcNazwa { get; set; } = null!;

    public string? PlcOpis { get; set; }

    public string? PlcParDirtyOrgId { get; set; }

    public string? PlcParOrgId { get; set; }

    public int? PlcParGid { get; set; }

    public DateTime PlcTsinsert { get; set; }

    public DateTime PlcTsupdate { get; set; }

    public DateTime PlcTimeFrom { get; set; }

    public DateTime? PlcTimeTo { get; set; }

    public int PlcChecksumKimball1 { get; set; }

    public int PlcChecksumKimball2 { get; set; }

    public int PlcUpdateTransformationId { get; set; }

    public int? PlcUpdateSubTransformationId { get; set; }

    public int PlcInsertTransformationId { get; set; }

    public int? PlcInsertSubTransformationId { get; set; }

    public byte[] PlcRowVersion { get; set; } = null!;

    public virtual ICollection<FktJgospodarczeGu> FktJgospodarczeGus { get; set; } = new List<FktJgospodarczeGu>();

    public virtual ICollection<FktLudnoscGu> FktLudnoscGus { get; set; } = new List<FktLudnoscGu>();

    public virtual WymZrodloDanych PlcZrodg { get; set; } = null!;
}
