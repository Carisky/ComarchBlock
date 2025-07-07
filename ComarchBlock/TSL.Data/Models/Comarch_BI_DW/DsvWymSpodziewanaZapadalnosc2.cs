using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymSpodziewanaZapadalnosc2
{
    public int? SpZap2ChecksumKimball1 { get; set; }

    public int? SpZap2ChecksumKimball2 { get; set; }

    public string SpZap2DirtyOrgId { get; set; } = null!;

    public int? SpZap2Do { get; set; }

    public int SpZap2Id { get; set; }

    public int? SpZap2InsertSubTransformationId { get; set; }

    public int? SpZap2InsertTransformationId { get; set; }

    public string SpZap2Nazwa { get; set; } = null!;

    public int? SpZap2Od { get; set; }

    public string? SpZap2Opis { get; set; }

    public string SpZap2OrgId { get; set; } = null!;

    public string? SpZap2ParCleanOrgId { get; set; }

    public string? SpZap2ParDirtyOrgId { get; set; }

    public int? SpZap2ParGid { get; set; }

    public int? SpZap2RowId { get; set; }

    public byte[] SpZap2RowVersion { get; set; } = null!;

    public DateTime SpZap2TimeFrom { get; set; }

    public DateTime? SpZap2TimeTo { get; set; }

    public DateTime SpZap2Tsinsert { get; set; }

    public DateTime SpZap2Tsupdate { get; set; }

    public int? SpZap2TypId { get; set; }

    public string? SpZap2TypOrgId { get; set; }

    public int? SpZap2UpdateSubTransformationId { get; set; }

    public int? SpZap2UpdateTransformationId { get; set; }

    public int SpZap2Zrodgid { get; set; }
}
