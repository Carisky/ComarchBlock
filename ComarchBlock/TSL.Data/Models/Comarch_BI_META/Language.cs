using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Language
{
    public string LanName { get; set; } = null!;

    public string LanId { get; set; } = null!;

    public virtual ICollection<ToolTipField> ToolTipFields { get; set; } = new List<ToolTipField>();

    public virtual ICollection<ToolTipTable> ToolTipTables { get; set; } = new List<ToolTipTable>();
}
