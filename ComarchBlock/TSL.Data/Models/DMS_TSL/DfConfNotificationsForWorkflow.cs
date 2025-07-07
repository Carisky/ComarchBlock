using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfNotificationsForWorkflow
{
    public int DfcDfhid { get; set; }

    public int DfcDcdid { get; set; }

    public bool DfcNotificationsEnabled { get; set; }

    public bool? DfcArchival { get; set; }
}
