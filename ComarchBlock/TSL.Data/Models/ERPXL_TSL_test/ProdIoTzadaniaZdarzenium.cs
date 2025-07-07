using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdIoTzadaniaZdarzenium
{
    public int PizzId { get; set; }

    public int? PizzObiNumer { get; set; }

    public short? PizzObiTyp { get; set; }

    public int? PizzLp { get; set; }

    public string? PizzZadanie { get; set; }

    public string? PizzOpisZadania { get; set; }

    public byte? PizzWykonano { get; set; }
}
