using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkDsparallelApproval
{
    public int DwpId { get; set; }

    public int DwpDcdid { get; set; }

    public int? DwpDcdreplacementPersonId { get; set; }

    public int DwpDwsid { get; set; }

    public bool? DwpApproved { get; set; }

    public DateTime? DwpApprovalDate { get; set; }

    public string? DwpMessage { get; set; }

    public bool DwpArchival { get; set; }
}
