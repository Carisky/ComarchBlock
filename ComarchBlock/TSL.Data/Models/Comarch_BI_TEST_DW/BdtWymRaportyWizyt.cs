using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymRaportyWizyt
{
    public int RawId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RawRowId { get; set; }

    public string? RawRodzaj { get; set; }

    public int? RawAktywny { get; set; }

    public string? RawKod { get; set; }

    public string? RawStatus { get; set; }

    public byte[] RawRowVersion { get; set; } = null!;

    public int? RawInsertSubTransformationId { get; set; }

    public int RawInsertTransformationId { get; set; }

    public int? RawUpdateSubTransformationId { get; set; }

    public int RawUpdateTransformationId { get; set; }

    public int RawChecksumKimball2 { get; set; }

    public int RawChecksumKimball1 { get; set; }

    public DateTime? RawTimeTo { get; set; }

    public DateTime RawTimeFrom { get; set; }

    public DateTime RawTsupdate { get; set; }

    public DateTime RawTsinsert { get; set; }

    public int? RawParGid { get; set; }

    public string? RawParCleanOrgId { get; set; }

    public string? RawParDirtyOrgId { get; set; }

    public string? RawOpis { get; set; }

    public string RawNazwa { get; set; } = null!;

    public string RawDirtyOrgId { get; set; } = null!;

    public string RawOrgId { get; set; } = null!;

    public int RawZrodgid { get; set; }

    public int RawDataUtworzenia { get; set; }

    public int RawDataArchiwizacji { get; set; }
}
