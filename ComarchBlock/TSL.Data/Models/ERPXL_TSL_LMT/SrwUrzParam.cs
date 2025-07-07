using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrwUrzParam
{
    public int SupId { get; set; }

    public int? SupObiNumer { get; set; }

    public short? SupObiTyp { get; set; }

    public int? SupSudid { get; set; }

    public string? SupParWartoscS { get; set; }

    public int? SupParWartoscL { get; set; }

    public decimal? SupParWartoscDec { get; set; }

    public short? SupLp { get; set; }

    public int? SupZewnetrznyId { get; set; }

    public int? SupZewnetrznySys { get; set; }

    public virtual SrwUrzParDef? SupSud { get; set; }
}
