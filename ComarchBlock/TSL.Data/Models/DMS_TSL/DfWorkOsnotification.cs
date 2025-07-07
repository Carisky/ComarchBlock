using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkOsnotification
{
    public int NtfId { get; set; }

    public int NtfDwdid { get; set; }

    public int NtfDcdid { get; set; }

    public int NtfDwsid { get; set; }

    public DateTime NtfDateOpening { get; set; }
}
