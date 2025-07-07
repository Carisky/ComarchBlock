using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Context
{
    public int CtxId { get; set; }

    public string CtxName { get; set; } = null!;

    public virtual ICollection<ContextTranslation> ContextTranslations { get; set; } = new List<ContextTranslation>();

    public virtual ICollection<ReportParameter> ReportParameters { get; set; } = new List<ReportParameter>();

    public virtual ICollection<Parameter> CptParameters { get; set; } = new List<Parameter>();

    public virtual ICollection<Report> CtrReports { get; set; } = new List<Report>();
}
