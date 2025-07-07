using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymZamowieniaStan
{
    public int ZamStanId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ZamStanRowId { get; set; }

    public string? ZamStanTypOrgId { get; set; }

    public int? ZamStanDo { get; set; }

    public int? ZamStanOd { get; set; }

    public byte[] ZamStanRowVersion { get; set; } = null!;

    public int? ZamStanInsertSubTransformationId { get; set; }

    public int? ZamStanInsertTransformationId { get; set; }

    public int? ZamStanUpdateSubTransformationId { get; set; }

    public int? ZamStanUpdateTransformationId { get; set; }

    public int? ZamStanChecksumKimball2 { get; set; }

    public int? ZamStanChecksumKimball1 { get; set; }

    public DateTime? ZamStanTimeTo { get; set; }

    public DateTime ZamStanTimeFrom { get; set; }

    public DateTime ZamStanTsupdate { get; set; }

    public DateTime ZamStanTsinsert { get; set; }

    public int? ZamStanParGid { get; set; }

    public string? ZamStanParCleanOrgId { get; set; }

    public string? ZamStanParDirtyOrgId { get; set; }

    public string? ZamStanOpis { get; set; }

    public string ZamStanNazwa { get; set; } = null!;

    public string ZamStanDirtyOrgId { get; set; } = null!;

    public string ZamStanOrgId { get; set; } = null!;

    public int ZamStanZrodgid { get; set; }

    public int ZamStanZamTypId { get; set; }
}
