using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KodyCn
{
    public int KcnId { get; set; }

    public string? KcnKod { get; set; }

    public decimal? KcnStawkaVat { get; set; }

    public byte? KcnFlagaVat { get; set; }

    public string? KcnOpis { get; set; }

    public string? KcnJedUzup { get; set; }

    public short? KcnBezMasy { get; set; }

    public byte? KcnSent { get; set; }

    public string? KcnJedSent { get; set; }

    public virtual ICollection<KodyCnjednostkiSent> KodyCnjednostkiSents { get; set; } = new List<KodyCnjednostkiSent>();
}
