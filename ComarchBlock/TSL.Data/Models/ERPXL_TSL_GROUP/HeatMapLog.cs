using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class HeatMapLog
{
    public long HmlLogId { get; set; }

    public string? HmlOpeGuid { get; set; }

    public string? HmlSessionGuid { get; set; }

    public int? HmlTime { get; set; }

    public string? HmlViewName { get; set; }

    public string? HmlControlPath { get; set; }

    public int? HmlAction { get; set; }

    public int? HmlMessageId { get; set; }

    public string? HmlMessage { get; set; }

    public string? HmlOpeModules { get; set; }
}
