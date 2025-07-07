using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class PrzWyrej
{
    public int PwrPwrId { get; set; }

    public int PwrPrzWyrej3 { get; set; }

    public int PwrPoziom { get; set; }

    public int PwrWybieralny { get; set; }

    public string PwrOpis { get; set; } = null!;

    public string PwrZjeId { get; set; } = null!;
}
