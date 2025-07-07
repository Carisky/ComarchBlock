using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class CubeTranslation
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int CubeId { get; set; }

    public int Language { get; set; }

    public string Caption { get; set; } = null!;

    public int RowVer { get; set; }

    public virtual Cube Cube { get; set; } = null!;
}
