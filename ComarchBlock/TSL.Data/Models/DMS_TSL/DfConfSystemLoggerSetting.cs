using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfSystemLoggerSetting
{
    public int SlsId { get; set; }

    public byte SlsGeneralLogsConfigSource { get; set; }

    public bool SlsIsGeneralLogsEnabled { get; set; }

    public byte SlsErpXllogsConfigSource { get; set; }

    public bool SlsIsErpXllogsEnabled { get; set; }

    public byte SlsExeLogsConfigSource { get; set; }

    public bool SlsIsExeLogsEnabled { get; set; }

    public byte SlsCsScriptLogsConfigSource { get; set; }

    public bool SlsIsCsScriptLogsEnabled { get; set; }
}
