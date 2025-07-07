using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KgtSlownik
{
    public int KsloId { get; set; }

    public int? KsloWszystkoPlId { get; set; }

    public string? KsloWartosc { get; set; }

    public virtual ICollection<KgtSlownikiParametruKategorii> KgtSlownikiParametruKategoriis { get; set; } = new List<KgtSlownikiParametruKategorii>();
}
