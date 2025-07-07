using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ZestKsdef
{
    public short? ZkdGidtyp { get; set; }

    public int? ZkdGidfirma { get; set; }

    public int ZkdGidnumer { get; set; }

    public short ZkdGidlp { get; set; }

    public short ZkdSubGidlp { get; set; }

    public string? ZkdWartosc { get; set; }

    public byte? ZkdZnak { get; set; }

    public short? ZkdSidtyp { get; set; }

    public int? ZkdSidfirma { get; set; }

    public int? ZkdSidnumer { get; set; }

    public short? ZkdSidlp { get; set; }

    public byte? ZkdDfnzrodlo { get; set; }

    public int? ZkdDfnid { get; set; }

    public byte? ZkdDfnkwotaWmr { get; set; }

    public virtual ICollection<ZestKsdefKontum> ZestKsdefKonta { get; set; } = new List<ZestKsdefKontum>();

    public virtual ZestKselem ZestKselem { get; set; } = null!;
}
