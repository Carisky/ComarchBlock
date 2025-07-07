using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymUmowa
{
    public int UmnId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? UmnRowId { get; set; }

    public string? UmnNumerHlp { get; set; }

    public int? UmnObjectId { get; set; }

    public string? UmnSeria { get; set; }

    public string? UmnOrgAtrId { get; set; }

    public string? UmnRodzaj { get; set; }

    public string? UmnTyp { get; set; }

    public string? UmnNumer { get; set; }

    public byte[] UmnRowVersion { get; set; } = null!;

    public int? UmnInsertTransformationId { get; set; }

    public int UmnInsertSubTransformationId { get; set; }

    public int? UmnUpdateTransformationId { get; set; }

    public int UmnUpdateSubTransformationId { get; set; }

    public int UmnChecksumKimball2 { get; set; }

    public int UmnChecksumKimball1 { get; set; }

    public DateTime? UmnTimeTo { get; set; }

    public DateTime UmnTimeFrom { get; set; }

    public DateTime UmnTsupdate { get; set; }

    public DateTime UmnTsinsert { get; set; }

    public int? UmnParGid { get; set; }

    public string? UmnParOrgId { get; set; }

    public string? UmnParDirtyOrgId { get; set; }

    public string? UmnOpis { get; set; }

    public string UmnNazwa { get; set; } = null!;

    public string UmnDirtyOrgId { get; set; } = null!;

    public string UmnOrgId { get; set; } = null!;

    public int UmnZrodgid { get; set; }

    public int UmnUmsgid { get; set; }

    public int UmnChtgid { get; set; }

    public int? UmNCzyPozycjeTwr { get; set; }
}
