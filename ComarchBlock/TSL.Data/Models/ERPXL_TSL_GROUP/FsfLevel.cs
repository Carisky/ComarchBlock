using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class FsfLevel
{
    public int? Level { get; set; }

    public string? Prefix { get; set; }

    public string? Biid { get; set; }

    public int? Gid { get; set; }

    public int? Typ { get; set; }

    public int? ParentId { get; set; }

    public string? Name { get; set; }
}
