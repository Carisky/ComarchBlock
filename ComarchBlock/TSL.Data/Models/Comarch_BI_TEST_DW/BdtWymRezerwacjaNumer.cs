using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymRezerwacjaNumer
{
    public int RenId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RenRowId { get; set; }

    public int? RenReTid { get; set; }

    public int? FaktyRez { get; set; }

    public byte? RenPriorytet { get; set; }

    public string? RenRodzaj { get; set; }

    public string? RenCzyAktualny { get; set; }

    public int RenDokTypGid { get; set; }

    public int RenOpegid { get; set; }

    public string? RenPelnyNumer { get; set; }

    public byte[] RenRowVersion { get; set; } = null!;

    public int? RenInsertTransformationId { get; set; }

    public int? RenInsertSubTransformationId { get; set; }

    public int? RenUpdateTransformationId { get; set; }

    public int? RenUpdateSubTransformationId { get; set; }

    public int RenChecksumKimball2 { get; set; }

    public int RenChecksumKimball1 { get; set; }

    public DateTime? RenTimeTo { get; set; }

    public DateTime RenTimeFrom { get; set; }

    public DateTime RenTsupdate { get; set; }

    public DateTime RenTsinsert { get; set; }

    public int? RenParGid { get; set; }

    public string? RenParCleanOrgId { get; set; }

    public string? RenParDirtyOrgId { get; set; }

    public string? RenOpis { get; set; }

    public string RenNazwa { get; set; } = null!;

    public string RenDirtyOrgId { get; set; } = null!;

    public string RenOrgId { get; set; } = null!;

    public int RenZrodgid { get; set; }
}
