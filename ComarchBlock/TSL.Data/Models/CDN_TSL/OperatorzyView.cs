using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class OperatorzyView
{
    public int OpeOpeId { get; set; }

    public string OpeKod { get; set; } = null!;

    public string OpeNazwisko { get; set; } = null!;

    public short OpeNieaktywny { get; set; }
}
