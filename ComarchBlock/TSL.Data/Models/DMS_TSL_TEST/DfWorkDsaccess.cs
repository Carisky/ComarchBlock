using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkDsaccess
{
    public int WsaDwsid { get; set; }

    public int? WsaDcdid { get; set; }

    public int? WsaDcpid { get; set; }

    public int WsaTypeAccess { get; set; }

    public bool WsaArchival { get; set; }

    public virtual DfConfOsdictionary? WsaDcd { get; set; }

    public virtual DfWorkD WsaDws { get; set; } = null!;
}
