using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ZrodlaPozycje
{
    public short ZpzTabId { get; set; }

    public short ZpzTrntyp { get; set; }

    public int ZpzTrnnumer { get; set; }

    public short ZpzTrnlp { get; set; }

    public short ZpzTrnsubLp { get; set; }

    public short ZpzPdttyp { get; set; }

    public int ZpzPdtnumer { get; set; }

    public short ZpzPdtlp { get; set; }

    public int ZpzDtnumer { get; set; }

    public short ZpzDtlp { get; set; }

    public byte? ZpzKdwyrazenie { get; set; }

    public byte? ZpzKcwyrazenie { get; set; }

    public decimal? ZpzKwota { get; set; }

    public decimal? ZpzKwotaWal { get; set; }
}
