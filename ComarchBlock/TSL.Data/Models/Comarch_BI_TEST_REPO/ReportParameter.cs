using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class ReportParameter
{
    public int RpaId { get; set; }

    public int PraReportId { get; set; }

    public int RpaParameterType { get; set; }

    public int? RpaContextParameterId { get; set; }

    public int? RpaContextId { get; set; }

    public int? RpaHierarchyId { get; set; }

    public int? RpaDataModelId { get; set; }

    public string? RpaCubeName { get; set; }

    public bool RpaIsActiveContexts { get; set; }

    public virtual Report PraReport { get; set; } = null!;

    public virtual Context? RpaContext { get; set; }

    public virtual Parameter? RpaContextParameter { get; set; }

    public virtual DataModel? RpaDataModel { get; set; }

    public virtual Hierarchy1? RpaHierarchy { get; set; }
}
