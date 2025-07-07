using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Parameter
{
    public int ParId { get; set; }

    public string? ParName { get; set; }

    public virtual ICollection<CubesParametersHierarchy> CubesParametersHierarchies { get; set; } = new List<CubesParametersHierarchy>();

    public virtual ICollection<ParametersTranslation> ParametersTranslations { get; set; } = new List<ParametersTranslation>();

    public virtual ICollection<ReportParameter> ReportParameters { get; set; } = new List<ReportParameter>();

    public virtual ICollection<Context> CtpContexts { get; set; } = new List<Context>();
}
