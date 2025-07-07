using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class Input
{
    public int InId { get; set; }

    public string InName { get; set; } = null!;

    public string InType { get; set; } = null!;

    public string InDefinition { get; set; } = null!;

    public DateTime InDate { get; set; }

    public string InServer { get; set; } = null!;

    public string InDatabase { get; set; } = null!;

    public string InCubeName { get; set; } = null!;

    public string InInputTableName { get; set; } = null!;

    public string InXmlDefinition { get; set; } = null!;

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();
}
