using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class Link1
{
    public long LinkId { get; set; }

    public string? LinkPhysicalTableName { get; set; }

    public string? LinkPartialViewsNames { get; set; }

    public string? LinkBdttableName { get; set; }

    public string? LinkDsvnameDw { get; set; }

    public string? LinkDsvnameOlap { get; set; }

    public string? LinkFriendlyNameOlap { get; set; }

    public string? LinkDbtableName { get; set; }

    public string? LinkDbtableType { get; set; }
}
