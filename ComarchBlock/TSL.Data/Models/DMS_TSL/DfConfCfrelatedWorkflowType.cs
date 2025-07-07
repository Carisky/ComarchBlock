using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfCfrelatedWorkflowType
{
    public int? CrtDkoid { get; set; }

    public int? CrtDmcid { get; set; }

    public int CrtDfhid { get; set; }

    public bool CrtArchival { get; set; }
}
