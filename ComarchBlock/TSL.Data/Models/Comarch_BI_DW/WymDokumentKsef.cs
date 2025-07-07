using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymDokumentKsef
{
    public int KsefRowId { get; set; }

    public int KsefId { get; set; }

    public int KsefZrodgid { get; set; }

    public string KsefOrgId { get; set; } = null!;

    public string KsefDirtyOrgId { get; set; } = null!;

    public string? KsefParCleanOrgId { get; set; }

    public string? KsefParDirtyOrgId { get; set; }

    public int? KsefParGid { get; set; }

    public string KsefNazwa { get; set; } = null!;

    public string? KsefOpis { get; set; }

    public DateTime KsefTsinsert { get; set; }

    public DateTime KsefTsupdate { get; set; }

    public int? KsefUpdateTransformationId { get; set; }

    public int KsefUpdateSubTransformationId { get; set; }

    public int? KsefInsertTransformationId { get; set; }

    public int KsefInsertSubTransformationId { get; set; }

    public DateTime KsefTimeFrom { get; set; }

    public DateTime? KsefTimeTo { get; set; }

    public int KsefChecksumKimball1 { get; set; }

    public int KsefChecksumKimball2 { get; set; }

    public byte[] KsefRowVersion { get; set; } = null!;

    public string? KsefWeryfikacja { get; set; }

    public string? KsefRodzajFaktury { get; set; }

    public string? KsefStatus { get; set; }

    public string? KsefCzyWsystemie { get; set; }

    public string? KsefOdrzucony { get; set; }

    public string? KsefNumer { get; set; }

    public string? KsefNumerObcy { get; set; }

    public virtual WymZrodloDanych KsefZrodg { get; set; } = null!;
}
