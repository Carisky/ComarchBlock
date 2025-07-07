using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymAdre
{
    public string? AdrAdres { get; set; }

    public string? AdrAkronim { get; set; }

    public int AdrChecksumKimball1 { get; set; }

    public int AdrChecksumKimball2 { get; set; }

    public string AdrDirtyOrgId { get; set; } = null!;

    public decimal? AdrDlugGeog { get; set; }

    public string? AdrEmail { get; set; }

    public int? AdrGeoid { get; set; }

    public int AdrId { get; set; }

    public int? AdrInsertSubTransformationId { get; set; }

    public int AdrInsertTransformationId { get; set; }

    public string? AdrKodPocztowy { get; set; }

    public int? AdrMiejscowoscId { get; set; }

    public string AdrNazwa { get; set; } = null!;

    public string? AdrNip { get; set; }

    public decimal? AdrOdleglosc { get; set; }

    public string? AdrOpis { get; set; }

    public string AdrOrgId { get; set; } = null!;

    public string? AdrParCleanOrgId { get; set; }

    public string? AdrParDirtyOrgId { get; set; }

    public int? AdrParGid { get; set; }

    public int? AdrRejonid { get; set; }

    public int? AdrRowId { get; set; }

    public byte[] AdrRowVersion { get; set; } = null!;

    public decimal? AdrSzerGeog { get; set; }

    public string? AdrTelefon { get; set; }

    public DateTime AdrTimeFrom { get; set; }

    public DateTime? AdrTimeTo { get; set; }

    public DateTime AdrTsinsert { get; set; }

    public DateTime AdrTsupdate { get; set; }

    public int? AdrUpdateSubTransformationId { get; set; }

    public int AdrUpdateTransformationId { get; set; }

    public int AdrZrodgid { get; set; }

    public string? AdrAktualny { get; set; }
}
