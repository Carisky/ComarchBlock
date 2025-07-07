using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfApcontrol
{
    public int ApcId { get; set; }

    public int ApcApdid { get; set; }

    public int ApcDfhid { get; set; }

    public string ApcDkoname { get; set; } = null!;

    public int ApcDctid { get; set; }

    public string? ApcSqlQuery { get; set; }

    public byte? ApcMode { get; set; }

    public bool ApcArchival { get; set; }

    public string? ApcDkodisplayName { get; set; }

    public Guid? ApcDkoguid { get; set; }

    public virtual DfConfApdictionary ApcApd { get; set; } = null!;
}
