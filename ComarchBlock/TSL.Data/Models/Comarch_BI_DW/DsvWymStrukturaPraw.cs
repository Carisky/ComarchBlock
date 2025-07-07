using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymStrukturaPraw
{
    public int? Hierarchy6Level1Id { get; set; }

    public string? Hierarchy6Level1Name { get; set; }

    public string? Hierarchy6Level1OrgId { get; set; }

    public int? Hierarchy6Level2Id { get; set; }

    public string? Hierarchy6Level2Name { get; set; }

    public string? Hierarchy6Level2OrgId { get; set; }

    public int? Hierarchy6Level3Id { get; set; }

    public string? Hierarchy6Level3Name { get; set; }

    public string? Hierarchy6Level3OrgId { get; set; }

    public int? Hierarchy6Level4Id { get; set; }

    public string? Hierarchy6Level4Name { get; set; }

    public string? Hierarchy6Level4OrgId { get; set; }

    public int? StrFrmParId { get; set; }

    public string? StrPrwAktualneOrgId { get; set; }

    public string? StrPrwAktywny { get; set; }

    public int StrPrwChecksumKimball1 { get; set; }

    public int StrPrwChecksumKimball2 { get; set; }

    public string StrPrwDirtyOrgId { get; set; } = null!;

    public int StrPrwId { get; set; }

    public int? StrPrwInsertSubTransformationId { get; set; }

    public int StrPrwInsertTransformationId { get; set; }

    public string? StrPrwKonto { get; set; }

    public string StrPrwNazwa { get; set; } = null!;

    public string? StrPrwOlapSecurity { get; set; }

    public string? StrPrwOpis { get; set; }

    public string? StrPrwOrgAtrId { get; set; }

    public string StrPrwOrgId { get; set; } = null!;

    public string? StrPrwOrgParId { get; set; }

    public string? StrPrwParDirtyOrgId { get; set; }

    public int? StrPrwRowId { get; set; }

    public byte[] StrPrwRowVersion { get; set; } = null!;

    public string? StrPrwStrPrwTrnOrgId { get; set; }

    public DateTime StrPrwTimeFrom { get; set; }

    public DateTime? StrPrwTimeTo { get; set; }

    public DateTime StrPrwTsinsert { get; set; }

    public DateTime StrPrwTsupdate { get; set; }

    public string? StrPrwTyp { get; set; }

    public int? StrPrwUpdateSubTransformationId { get; set; }

    public int StrPrwUpdateTransformationId { get; set; }

    public string? StrPrwUrl { get; set; }

    public int StrPrwZrodgid { get; set; }
}
