using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Hierarchy1
{
    public int HrcId { get; set; }

    public string? HrcName { get; set; }

    public string HrcBusinessType { get; set; } = null!;

    public virtual ICollection<CubesParametersHierarchy> CubesParametersHierarchies { get; set; } = new List<CubesParametersHierarchy>();

    public virtual ICollection<HierarchiesTranslation> HierarchiesTranslations { get; set; } = new List<HierarchiesTranslation>();

    public virtual ICollection<ReportParameter> ReportParameters { get; set; } = new List<ReportParameter>();
}
