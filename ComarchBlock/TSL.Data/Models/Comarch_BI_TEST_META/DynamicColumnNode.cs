using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class DynamicColumnNode
{
    public int DcnId { get; set; }

    public string DcnName { get; set; } = null!;

    public int DcnTblid { get; set; }

    public string DcnAotid { get; set; } = null!;

    public string? DcnOlapParentObjId { get; set; }

    public string? DcnOlapParentObjType { get; set; }

    public int? DcnAobid { get; set; }

    public bool? DcnImport { get; set; }

    public bool? DcnIsImported { get; set; }

    public virtual AnalyticObject? DcnAob { get; set; }

    public virtual AnalyticObjectType DcnAot { get; set; } = null!;

    public virtual Table DcnTbl { get; set; } = null!;
}
