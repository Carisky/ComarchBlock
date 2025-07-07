using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWork
{
    public int DwdId { get; set; }

    public DateTime DwdCreateDate { get; set; }

    public int DwdDshid { get; set; }

    public int? DwdNumber { get; set; }

    public string? DwdFullNumber { get; set; }

    public bool DwdArchival { get; set; }

    public int? DwdNatSddid { get; set; }

    public int DwdDcdownerId { get; set; }

    public bool DwdIsAutoSaved { get; set; }

    public int? DwdMonth { get; set; }

    public int? DwdYear { get; set; }

    public int? DwdDwscurrentStageId { get; set; }

    public int? DwdDcdcreatorId { get; set; }

    public int? DwdCompanyId { get; set; }

    public int? DwdErpdepartmentId { get; set; }

    public int? DwdParentDocumentDwdid { get; set; }

    public int? DwdSelectedNextStageId { get; set; }

    public int? DwdDcdlockUserId { get; set; }

    public DateTime? DwdLockDate { get; set; }

    public virtual ICollection<DfWorkCf> DfWorkCfs { get; set; } = new List<DfWorkCf>();

    public virtual ICollection<DfWorkD> DfWorkDs { get; set; } = new List<DfWorkD>();

    public virtual ICollection<DfWorkOsclosedDoc> DfWorkOsclosedDocs { get; set; } = new List<DfWorkOsclosedDoc>();

    public virtual ICollection<DfWorkOsworkDoc> DfWorkOsworkDocs { get; set; } = new List<DfWorkOsworkDoc>();

    public virtual DfConfOsdictionary DwdDcdowner { get; set; } = null!;

    public virtual DfConfDshead DwdDsh { get; set; } = null!;

    public virtual DfWorkD? DwdDwscurrentStage { get; set; }
}
