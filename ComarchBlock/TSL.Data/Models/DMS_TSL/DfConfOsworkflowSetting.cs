using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfOsworkflowSetting
{
    public int CowId { get; set; }

    public int CowDcdid { get; set; }

    public int CowDfhid { get; set; }

    public bool? CowMlstageSuggestions { get; set; }
}
