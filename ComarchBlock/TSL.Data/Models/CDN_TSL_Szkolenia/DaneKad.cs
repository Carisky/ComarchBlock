using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DaneKad
{
    public int DkdDkdId { get; set; }

    public int DkdKod { get; set; }

    public byte DkdRodzaj { get; set; }

    public int DkdPoziom { get; set; }

    public int DkdWybieralny { get; set; }

    public string DkdOpis { get; set; } = null!;

    public string DkdZjeId { get; set; } = null!;
}
