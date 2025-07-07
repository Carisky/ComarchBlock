using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KksGrupyNag
{
    public int KgnId { get; set; }

    public string? KgnNazwa { get; set; }

    public int? KgnOkres { get; set; }

    public byte? KgnAktywna { get; set; }

    public virtual ICollection<KksGrupyElem> KksGrupyElems { get; set; } = new List<KksGrupyElem>();
}
