using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymAdre
{
    public int AdrId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? AdrRowId { get; set; }

    public int? AdrGeoid { get; set; }

    public string? AdrEmail { get; set; }

    public decimal? AdrOdleglosc { get; set; }

    public decimal? AdrSzerGeog { get; set; }

    public decimal? AdrDlugGeog { get; set; }

    public string? AdrNip { get; set; }

    public string? AdrAdres { get; set; }

    public string? AdrTelefon { get; set; }

    public string? AdrKodPocztowy { get; set; }

    public string? AdrAkronim { get; set; }

    public byte[] AdrRowVersion { get; set; } = null!;

    public int? AdrInsertSubTransformationId { get; set; }

    public int AdrInsertTransformationId { get; set; }

    public int? AdrUpdateSubTransformationId { get; set; }

    public int AdrUpdateTransformationId { get; set; }

    public int AdrChecksumKimball2 { get; set; }

    public int AdrChecksumKimball1 { get; set; }

    public DateTime? AdrTimeTo { get; set; }

    public DateTime AdrTimeFrom { get; set; }

    public DateTime AdrTsupdate { get; set; }

    public DateTime AdrTsinsert { get; set; }

    public int? AdrParGid { get; set; }

    public string? AdrParCleanOrgId { get; set; }

    public string? AdrParDirtyOrgId { get; set; }

    public string? AdrOpis { get; set; }

    public string AdrNazwa { get; set; } = null!;

    public string AdrDirtyOrgId { get; set; } = null!;

    public string AdrOrgId { get; set; } = null!;

    public int AdrZrodgid { get; set; }

    public int? AdrMiejscowoscId { get; set; }

    public int? AdrRejonid { get; set; }

    public string? AdrAktualny { get; set; }
}
