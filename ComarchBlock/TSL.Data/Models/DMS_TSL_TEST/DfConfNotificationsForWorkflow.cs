using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfNotificationsForWorkflow
{
    public int DfcDfhid { get; set; }

    public int DfcDcdid { get; set; }

    public bool DfcNotificationsEnabled { get; set; }

    public bool? DfcArchival { get; set; }
}
