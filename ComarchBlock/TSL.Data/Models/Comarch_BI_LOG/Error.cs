using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class Error
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int UserId { get; set; }

    public string Level { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string InnerMessage { get; set; } = null!;
}
