using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DoDimensionCondition
{
    public string DodcUserName { get; set; } = null!;

    public bool DodcExists { get; set; }

    public int? DodcDimension { get; set; }

    public string? DodcRootName { get; set; }

    public string? DodcFullName { get; set; }

    public string? DodcAddName { get; set; }

    public string? DodcWmrname { get; set; }

    public string? DodcWmrdescription { get; set; }

    public string? DodcWmraccount { get; set; }

    public string? DodcKksaccount { get; set; }

    public string? DodcKksname { get; set; }

    public string? DodcSqlvar { get; set; }

    public string? DodcSqldescription { get; set; }

    public string? DodcCmdshortcut { get; set; }

    public int? DodcDcdid { get; set; }
}
