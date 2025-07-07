using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SeSkwotyDod
{
    public int SkOSeSid { get; set; }

    public short SkOLp { get; set; }

    public short? SkORodzaj { get; set; }

    public decimal? SkOKwota { get; set; }

    public decimal? SkOKwotaSys { get; set; }

    public string? SkOWaluta { get; set; }

    public byte? SkOWliczanaDo { get; set; }

    public virtual SeSkwoty SkOSeS { get; set; } = null!;
}
