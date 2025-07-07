using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class RezMagazyny
{
    public short? ReMRezTyp { get; set; }

    public int? ReMRezFirma { get; set; }

    public int ReMRezNumer { get; set; }

    public short ReMRezLp { get; set; }

    public short? ReMMagTyp { get; set; }

    public int? ReMMagFirma { get; set; }

    public int? ReMMagNumer { get; set; }

    public short? ReMMagLp { get; set; }

    public short? ReMZrdTyp { get; set; }

    public int? ReMZrdFirma { get; set; }

    public int? ReMZrdNumer { get; set; }

    public short? ReMZrdLp { get; set; }

    public short? ReMZrdSubLp { get; set; }

    public virtual Magazyny? ReMMagNumerNavigation { get; set; }

    public virtual Rezerwacje ReMRezNumerNavigation { get; set; } = null!;
}
