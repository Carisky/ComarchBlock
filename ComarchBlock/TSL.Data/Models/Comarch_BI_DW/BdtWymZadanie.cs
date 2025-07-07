using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymZadanie
{
    public int? ZadRowId { get; set; }

    public int ZadId { get; set; }

    public int ZadZrodgid { get; set; }

    public string ZadOrgId { get; set; } = null!;

    public string ZadDirtyOrgId { get; set; } = null!;

    public string? ZadParCleanOrgId { get; set; }

    public string? ZadParDirtyOrgId { get; set; }

    public int? ZadParGid { get; set; }

    public string ZadNazwa { get; set; } = null!;

    public string? ZadOpis { get; set; }

    public DateTime ZadTsinsert { get; set; }

    public DateTime ZadTsupdate { get; set; }

    public int? ZadUpdateTransformationId { get; set; }

    public int ZadUpdateSubTransformationId { get; set; }

    public int? ZadInsertTransformationId { get; set; }

    public int ZadInsertSubTransformationId { get; set; }

    public DateTime ZadTimeFrom { get; set; }

    public DateTime? ZadTimeTo { get; set; }

    public int ZadChecksumKimball1 { get; set; }

    public int ZadChecksumKimball2 { get; set; }

    public byte[] ZadRowVersion { get; set; } = null!;

    public string? ZadRodzaj { get; set; }

    public string? ZadTyp { get; set; }

    public int ZadOpeid { get; set; }

    public int? BudgetMemberId { get; set; }
}
