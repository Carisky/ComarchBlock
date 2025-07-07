using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class MessageTranslation
{
    public int? TransLangid { get; set; }

    public string? TransLangname { get; set; }

    public string? TransParid { get; set; }

    public string? TransName { get; set; }

    public string? TransTables { get; set; }

    public bool? TransIstech { get; set; }

    public bool TransIsssisvariable { get; set; }

    public int TransId { get; set; }
}
