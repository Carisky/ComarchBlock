using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymPracownikUmowy
{
    public int PumId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? PumRowId { get; set; }

    public string? PumWypadkowe { get; set; }

    public string? PumEmerytalne { get; set; }

    public string? PumRentowe { get; set; }

    public string? PumChorobowe { get; set; }

    public string? PumTypPracownika { get; set; }

    public string? PumTypWyplaty { get; set; }

    public string? PumZatrudnienieDo { get; set; }

    public string? PumZatrudnienieOd { get; set; }

    public string? PumStanowisko { get; set; }

    public string? PumRodzajUmowy { get; set; }

    public int? PumTypUmowy { get; set; }

    public byte[] PumRowVersion { get; set; } = null!;

    public int? PumInsertTransformationId { get; set; }

    public int PumInsertSubTransformationId { get; set; }

    public int? PumUpdateTransformationId { get; set; }

    public int PumUpdateSubTransformationId { get; set; }

    public int PumChecksumKimball2 { get; set; }

    public int PumChecksumKimball1 { get; set; }

    public DateTime? PumTimeTo { get; set; }

    public DateTime PumTimeFrom { get; set; }

    public DateTime PumTsupdate { get; set; }

    public DateTime PumTsinsert { get; set; }

    public int? PumParGid { get; set; }

    public string? PumParCleanOrgId { get; set; }

    public string? PumParDirtyOrgId { get; set; }

    public string? PumOpis { get; set; }

    public string PumNazwa { get; set; } = null!;

    public string PumDirtyOrgId { get; set; } = null!;

    public string PumOrgId { get; set; } = null!;

    public int PumZrodgid { get; set; }

    public string? PumAktualna { get; set; }
}
