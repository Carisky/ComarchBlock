using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymZestawieniaZmienne
{
    public int ZsrOkrgid { get; set; }

    public string ZsrZszdirtyOrgId { get; set; } = null!;

    public int ZsrZszgid { get; set; }

    public int ZsrRowId { get; set; }

    public int ZsrId { get; set; }

    public int ZsrZrodgid { get; set; }

    public string ZsrOrgId { get; set; } = null!;

    public string ZsrDirtyOrgId { get; set; } = null!;

    public string ZsrNazwa { get; set; } = null!;

    public string? ZsrOpis { get; set; }

    public string? ZsrParDirtyOrgId { get; set; }

    public string? ZsrParCleanOrgId { get; set; }

    public int? ZsrParGid { get; set; }

    public DateTime ZsrTsinsert { get; set; }

    public DateTime ZsrTsupdate { get; set; }

    public DateTime ZsrTimeFrom { get; set; }

    public DateTime? ZsrTimeTo { get; set; }

    public int ZsrChecksumKimball1 { get; set; }

    public int ZsrChecksumKimball2 { get; set; }

    public int ZsrUpdateSubTransformationId { get; set; }

    public int? ZsrUpdateTransformationId { get; set; }

    public int ZsrInsertSubTransformationId { get; set; }

    public int? ZsrInsertTransformationId { get; set; }

    public byte[] ZsrRowVersion { get; set; } = null!;

    public string? ZsrTytul { get; set; }

    public string? ZsrZakres { get; set; }

    public int? ZsrZknNumer { get; set; }

    public string? ZsrZmienna { get; set; }

    public int? BudgetMemberId { get; set; }
}
