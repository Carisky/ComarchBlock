using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Cdccertyfikaty
{
    public int CdcId { get; set; }

    public byte? CdcTyp { get; set; }

    public int? CdcBnkNumer { get; set; }

    public int? CdcOpeNumer { get; set; }

    public string? CdcNazwa { get; set; }

    public string? CdcOdcisk { get; set; }

    public virtual Banki? CdcBnkNumerNavigation { get; set; }
}
