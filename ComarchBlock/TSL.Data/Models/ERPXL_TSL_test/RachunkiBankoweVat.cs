using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class RachunkiBankoweVat
{
    public int RbvId { get; set; }

    public int? RbvRkbId { get; set; }

    public string? RbvNip { get; set; }

    public short? RbvVatWynik { get; set; }

    public string? RbvRequestId { get; set; }

    public int? RbvDataWeryfikacji { get; set; }

    public virtual RachunkiBankowe? RbvRkb { get; set; }
}
