using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktAnalizaRfm
{
    public long RfmId { get; set; }

    public int RfmAlokacjaId { get; set; }

    public int? RfmWskaznikRfm { get; set; }

    public int RfmMonetary { get; set; }

    public int RfmFrequency { get; set; }

    public int RfmRecency { get; set; }

    public DateTime RfmTsupdate { get; set; }

    public DateTime RfmTsinsert { get; set; }

    public int? RfmInsertSubTransformationId { get; set; }

    public int RfmInsertTransformationId { get; set; }

    public int? RfmUpdateSubTransformationId { get; set; }

    public int RfmUpdateTransformationId { get; set; }

    public string? RfmOpis { get; set; }

    public string RfmDirtyOrgId { get; set; } = null!;

    public string RfmCleanOrgId { get; set; } = null!;

    public int? RfmKntId { get; set; }

    public int? RfmCzmid { get; set; }

    public int RfmCzdid { get; set; }

    public int RfmZrodgid { get; set; }
}
