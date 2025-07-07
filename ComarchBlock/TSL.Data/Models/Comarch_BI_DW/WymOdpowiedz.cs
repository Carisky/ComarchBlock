using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymOdpowiedz
{
    public int OdpRowId { get; set; }

    public int OdpId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int OdpZrodgid { get; set; }

    public string OdpOrgId { get; set; } = null!;

    public string OdpDirtyOrgId { get; set; } = null!;

    public string? OdpNazwa { get; set; }

    public string? OdpOpis { get; set; }

    public string? OdpParDirtyOrgId { get; set; }

    public string? OdpParCleanOrgId { get; set; }

    public int? OdpParGid { get; set; }

    public DateTime OdpTsinsert { get; set; }

    public DateTime OdpTsupdate { get; set; }

    public DateTime OdpTimeFrom { get; set; }

    public DateTime? OdpTimeTo { get; set; }

    public int OdpChecksumKimball1 { get; set; }

    public int OdpChecksumKimball2 { get; set; }

    public int OdpUpdateSubTransformationId { get; set; }

    public int? OdpUpdateTransformationId { get; set; }

    public int OdpInsertSubTransformationId { get; set; }

    public int? OdpInsertTransformationId { get; set; }

    public byte[] OdpRowVersion { get; set; } = null!;

    /// <summary>
    /// Relation to dimension Pytanie
    /// </summary>
    public int OdpPytid { get; set; }

    public decimal? OdpPunkty { get; set; }

    public string? OdpTresc { get; set; }

    public virtual WymPytanie OdpPyt { get; set; } = null!;

    public virtual WymZrodloDanych OdpZrodg { get; set; } = null!;
}
