using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymDostawa
{
    public string? DostCecha { get; set; }

    public int? DostCechyId { get; set; }

    public int DostChecksumKimball1 { get; set; }

    public int DostChecksumKimball2 { get; set; }

    public int? DostDataWaznosciId { get; set; }

    public string DostDirtyOrgId { get; set; } = null!;

    public int? DostDokNumerId { get; set; }

    public string? DostEan { get; set; }

    public int DostId { get; set; }

    public int? DostInsertSubTransformationId { get; set; }

    public int DostInsertTransformationId { get; set; }

    public string DostNazwa { get; set; } = null!;

    public string? DostOpis { get; set; }

    public string? DostOrgAtrId { get; set; }

    public string? DostOrgId { get; set; }

    public string? DostParCleanOrgId { get; set; }

    public string? DostParDirtyOrgId { get; set; }

    public int? DostParGid { get; set; }

    public int? DostPartid { get; set; }

    public string? DostPolozenieWmag { get; set; }

    public int? DostRowId { get; set; }

    public byte[] DostRowVersion { get; set; } = null!;

    public DateTime DostTimeFrom { get; set; }

    public DateTime? DostTimeTo { get; set; }

    public DateTime DostTsinsert { get; set; }

    public DateTime DostTsupdate { get; set; }

    public int? DostUpdateSubTransformationId { get; set; }

    public int DostUpdateTransformationId { get; set; }

    public int DostZrodgid { get; set; }
}
