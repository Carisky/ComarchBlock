using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfUrdokListColumnSetting
{
    public int DlcId { get; set; }

    public int DlcDfhid { get; set; }

    public int DlcDcdid { get; set; }

    public int DlcWidth { get; set; }

    public string DlcColumnName { get; set; } = null!;

    public int DlcPos { get; set; }

    public bool DlcArchival { get; set; }
}
