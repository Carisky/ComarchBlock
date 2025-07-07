using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymWmsmagazyn
{
    public int? WmsmOdpowiedzialnyId { get; set; }

    public string WmsmPrcDirtyOrgId { get; set; } = null!;

    public int WmsmRowId { get; set; }

    public int WmsmId { get; set; }

    public int WmsmZrodgid { get; set; }

    public string WmsmOrgId { get; set; } = null!;

    public string WmsmDirtyOrgId { get; set; } = null!;

    public string? WmsmNazwa { get; set; }

    public string? WmsmOpis { get; set; }

    public string? WmsmParDirtyOrgId { get; set; }

    public string? WmsmParCleanOrgId { get; set; }

    public int? WmsmParGid { get; set; }

    public DateTime WmsmTsinsert { get; set; }

    public DateTime WmsmTsupdate { get; set; }

    public DateTime WmsmTimeFrom { get; set; }

    public DateTime? WmsmTimeTo { get; set; }

    public int WmsmChecksumKimball1 { get; set; }

    public int WmsmChecksumKimball2 { get; set; }

    public int WmsmUpdateSubTransformationId { get; set; }

    public int? WmsmUpdateTransformationId { get; set; }

    public int WmsmInsertSubTransformationId { get; set; }

    public int? WmsmInsertTransformationId { get; set; }

    public byte[] WmsmRowVersion { get; set; } = null!;

    public string? WmsmAdres { get; set; }

    public string? WmsmCzyMagazynWms { get; set; }

    public string? WmsmCzyWirtualny { get; set; }

    public string? WmsmCzyZbiorczy { get; set; }

    public int? WmsmMagazynWmsid { get; set; }

    public string? WmsmOsobaOdpowiedzialna { get; set; }

    public string? WmsmSymbol { get; set; }

    public string? WmsmTyp { get; set; }

    public int? BudgetMemberId { get; set; }
}
