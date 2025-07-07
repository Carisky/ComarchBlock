using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class KasaPit
{
    public int KptKptId { get; set; }

    public int? KptParentId { get; set; }

    public string? KptNumerRozliczenia { get; set; }

    public DateTime KptDataWystawienia { get; set; }

    public DateTime? KptData { get; set; }

    public decimal? KptKwotaRozliczenia { get; set; }

    public int? KptVaNid { get; set; }

    public int? KptEdNid { get; set; }

    public int? KptBrkid { get; set; }

    public int? KptKprid { get; set; }

    public int? KptRycId { get; set; }

    public virtual ZapisyKpr? KptKpr { get; set; }

    public virtual Ryczalt? KptRyc { get; set; }
}
