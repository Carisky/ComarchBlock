using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class OsoHistZatrudnienium
{
    public int OhzId { get; set; }

    public int? OhzOsoNumer { get; set; }

    public string? OhzNazwa { get; set; }

    public int? OhzOkresOd { get; set; }

    public int? OhzOkresDo { get; set; }

    public int? OhzOstStanowisko { get; set; }

    public short? OhzDataStazL { get; set; }

    public short? OhzDataStazM { get; set; }

    public short? OhzDataStazD { get; set; }

    public int? OhzBranza { get; set; }

    public string? OhzAdres { get; set; }

    public int? OhzOpeWnumer { get; set; }

    public int? OhzCzasWprowadzenia { get; set; }

    public int? OhzOpeMnumer { get; set; }

    public int? OhzCzasModyfikacji { get; set; }

    public virtual PrcKarty? OhzOsoNumerNavigation { get; set; }
}
