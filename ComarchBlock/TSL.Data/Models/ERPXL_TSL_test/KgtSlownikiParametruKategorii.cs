using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KgtSlownikiParametruKategorii
{
    public int KspkId { get; set; }

    public int? KspkSlownikId { get; set; }

    public int? KspkParametrKategoriiId { get; set; }

    public virtual KgtParametryKategorii? KspkParametrKategorii { get; set; }

    public virtual KgtSlownik? KspkSlownik { get; set; }
}
