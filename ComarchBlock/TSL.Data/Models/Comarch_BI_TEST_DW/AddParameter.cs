using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class AddParameter
{
    public int ParId { get; set; }

    public int ParZrodgid { get; set; }

    public int ParCzdgid { get; set; }

    public string ParOrgId { get; set; } = null!;

    public string ParDirtyOrgId { get; set; } = null!;

    public string? ParOpis { get; set; }

    public int? ParUpdateTransformationId { get; set; }

    public int ParUpdateSubTransformationId { get; set; }

    public int? ParInsertTransformationId { get; set; }

    public int ParInsertSubTransformationId { get; set; }

    public DateTime ParTsinsert { get; set; }

    public DateTime ParTsupdate { get; set; }

    public DateTime? ParDataModyfikacji { get; set; }

    public string? ParNazwa { get; set; }

    public string? ParUzytkownikModyfikujacy { get; set; }

    public string? ParWartosc { get; set; }

    public virtual WymCzasDzien ParCzdg { get; set; } = null!;

    public virtual WymZrodloDanych ParZrodg { get; set; } = null!;
}
