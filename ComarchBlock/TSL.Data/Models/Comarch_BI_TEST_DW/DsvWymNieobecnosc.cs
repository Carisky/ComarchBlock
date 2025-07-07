using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymNieobecnosc
{
    public int NobRowId { get; set; }

    public int NobId { get; set; }

    public int NobZrodgid { get; set; }

    public string NobOrgId { get; set; } = null!;

    public string NobDirtyOrgId { get; set; } = null!;

    public string NobNazwa { get; set; } = null!;

    public string? NobOpis { get; set; }

    public string? NobParDirtyOrgId { get; set; }

    public string? NobParCleanOrgId { get; set; }

    public int? NobParGid { get; set; }

    public DateTime NobTsinsert { get; set; }

    public DateTime NobTsupdate { get; set; }

    public DateTime NobTimeFrom { get; set; }

    public DateTime? NobTimeTo { get; set; }

    public int NobChecksumKimball1 { get; set; }

    public int NobChecksumKimball2 { get; set; }

    public int NobUpdateSubTransformationId { get; set; }

    public int? NobUpdateTransformationId { get; set; }

    public int NobInsertSubTransformationId { get; set; }

    public int? NobInsertTransformationId { get; set; }

    public byte[] NobRowVersion { get; set; } = null!;

    public string? NobOdDnia { get; set; }

    public string? NobDoDnia { get; set; }

    public string? NobPrzyczynaNieobZus { get; set; }

    public string? NobTytulUbezp { get; set; }

    public string? NobCzyNaCzescDnia { get; set; }

    public string? NobTypNieobecnosci { get; set; }
}
