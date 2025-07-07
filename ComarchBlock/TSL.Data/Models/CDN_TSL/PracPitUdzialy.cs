using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class PracPitUdzialy
{
    public int PpuPpuid { get; set; }

    public int PpuPpdid { get; set; }

    public decimal PpuUdzialL { get; set; }

    public decimal PpuUdzialM { get; set; }

    public DateTime PpuDataOd { get; set; }

    public DateTime PpuDataDo { get; set; }

    public decimal PpuPrzychody { get; set; }

    public decimal PpuKoszty { get; set; }

    public decimal PpuStawka1Przychod { get; set; }

    public decimal PpuStawka2Przychod { get; set; }

    public decimal PpuStawka3Przychod { get; set; }

    public decimal PpuStawka4Przychod { get; set; }

    public decimal PpuStawka5Przychod { get; set; }

    public decimal PpuStawka6Przychod { get; set; }

    public decimal PpuStawka7Przychod { get; set; }

    public decimal PpuStawka8Przychod { get; set; }

    public decimal PpuStawka9Przychod { get; set; }

    public decimal PpuStawka10Przychod { get; set; }

    public decimal PpuStawka11Przychod { get; set; }

    public virtual PracPitDzialalnosci PpuPpd { get; set; } = null!;
}
