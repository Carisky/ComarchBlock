using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfDsctrlCondition
{
    public int DsmId { get; set; }

    public int DsmDdsid { get; set; }

    public int DsmDkoid { get; set; }

    public bool DsmVisible { get; set; }

    public bool DsmReadonly { get; set; }

    public bool DsmRequired { get; set; }

    public bool DsmArchival { get; set; }

    public bool DsmInit { get; set; }

    public int DsmDkovariant { get; set; }

    public int? DsmInitOrder { get; set; }

    public bool DsmManualObserverExecution { get; set; }

    public virtual DfConfDsdictionary DsmDds { get; set; } = null!;

    public virtual DfConfCfcardDokFlow DsmDko { get; set; } = null!;
}
