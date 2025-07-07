using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymOdpowiedz
{
    public int OdpChecksumKimball1 { get; set; }

    public int OdpChecksumKimball2 { get; set; }

    public string OdpDirtyOrgId { get; set; } = null!;

    public int OdpId { get; set; }

    public int OdpInsertSubTransformationId { get; set; }

    public int? OdpInsertTransformationId { get; set; }

    public string? OdpNazwa { get; set; }

    public string? OdpOpis { get; set; }

    public string OdpOrgId { get; set; } = null!;

    public string? OdpParCleanOrgId { get; set; }

    public string? OdpParDirtyOrgId { get; set; }

    public int? OdpParGid { get; set; }

    public decimal? OdpPunkty { get; set; }

    public int OdpPytid { get; set; }

    public int? OdpRowId { get; set; }

    public byte[] OdpRowVersion { get; set; } = null!;

    public DateTime OdpTimeFrom { get; set; }

    public DateTime? OdpTimeTo { get; set; }

    public string? OdpTresc { get; set; }

    public DateTime OdpTsinsert { get; set; }

    public DateTime OdpTsupdate { get; set; }

    public int OdpUpdateSubTransformationId { get; set; }

    public int? OdpUpdateTransformationId { get; set; }

    public int OdpZrodgid { get; set; }
}
