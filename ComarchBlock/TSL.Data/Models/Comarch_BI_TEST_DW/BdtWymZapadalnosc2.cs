using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymZapadalnosc2
{
    public int Zap2Id { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? Zap2RowId { get; set; }

    public string? Zap2TypOrgId { get; set; }

    public int? Zap2Do { get; set; }

    public int? Zap2Od { get; set; }

    public byte[] Zap2RowVersion { get; set; } = null!;

    public int? Zap2InsertSubTransformationId { get; set; }

    public int? Zap2InsertTransformationId { get; set; }

    public int? Zap2UpdateSubTransformationId { get; set; }

    public int? Zap2UpdateTransformationId { get; set; }

    public int? Zap2ChecksumKimball2 { get; set; }

    public int? Zap2ChecksumKimball1 { get; set; }

    public DateTime? Zap2TimeTo { get; set; }

    public DateTime Zap2TimeFrom { get; set; }

    public DateTime Zap2Tsupdate { get; set; }

    public DateTime Zap2Tsinsert { get; set; }

    public int? Zap2ParGid { get; set; }

    public string? Zap2ParCleanOrgId { get; set; }

    public string? Zap2ParDirtyOrgId { get; set; }

    public string? Zap2Opis { get; set; }

    public string Zap2Nazwa { get; set; } = null!;

    public string Zap2DirtyOrgId { get; set; } = null!;

    public string Zap2OrgId { get; set; } = null!;

    public int Zap2Zrodgid { get; set; }

    public int? Zap2TypId { get; set; }
}
