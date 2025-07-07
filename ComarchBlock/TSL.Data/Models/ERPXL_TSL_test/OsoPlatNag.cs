using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class OsoPlatNag
{
    public int OsnId { get; set; }

    public int? OsnOsoNumer { get; set; }

    public int? OsnDataOd { get; set; }

    public int? OsnDataDo { get; set; }

    public byte? OsnFormaNr { get; set; }

    public int? OsnBnkNumer { get; set; }

    public string? OsnNrRachunku { get; set; }

    public int? OsnWalutaNumer { get; set; }

    public int? OsnOpeWnumer { get; set; }

    public int? OsnCzasWprowadzenia { get; set; }

    public int? OsnOpeMnumer { get; set; }

    public int? OsnCzasModyfikacji { get; set; }

    public virtual PrcKarty? OsnOsoNumerNavigation { get; set; }

    public virtual ICollection<OsoPlatElem> OsoPlatElems { get; set; } = new List<OsoPlatElem>();
}
