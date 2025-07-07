using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Dimension
{
    public int Id { get; set; }

    /// <summary>
    /// One2ManyCascade=all-delete-orphan;
    /// </summary>
    public int CubeId { get; set; }

    public string Name { get; set; } = null!;

    public int RowVer { get; set; }

    public virtual Cube Cube { get; set; } = null!;

    public virtual ICollection<DimensionTranslation> DimensionTranslations { get; set; } = new List<DimensionTranslation>();

    public virtual ICollection<Hierarchy> Hierarchies { get; set; } = new List<Hierarchy>();
}
