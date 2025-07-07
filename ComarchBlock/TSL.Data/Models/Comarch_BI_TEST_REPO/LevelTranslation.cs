using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class LevelTranslation
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int LevelId { get; set; }

    public int Language { get; set; }

    public string Caption { get; set; } = null!;

    public int RowVer { get; set; }

    public virtual Level Level { get; set; } = null!;
}
