using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfApattribute
{
    public int ApatId { get; set; }

    public int ApatApdid { get; set; }

    public string ApatExternalId { get; set; } = null!;

    public int ApatType { get; set; }

    public string ApatName { get; set; } = null!;

    public bool ApatRequired { get; set; }

    public string? ApatSqlQuery { get; set; }

    public bool ApatArchival { get; set; }
}
