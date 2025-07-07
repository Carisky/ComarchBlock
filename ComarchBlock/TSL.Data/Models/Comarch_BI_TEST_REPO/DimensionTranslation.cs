using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class DimensionTranslation
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int DimensionId { get; set; }

    public int Languag { get; set; }

    public string Caption { get; set; } = null!;

    public int RowVer { get; set; }

    public virtual Dimension Dimension { get; set; } = null!;
}
