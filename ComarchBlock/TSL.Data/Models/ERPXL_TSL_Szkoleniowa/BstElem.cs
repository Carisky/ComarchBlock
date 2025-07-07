using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class BstElem
{
    public int BsEBsNid { get; set; }

    public int BsETwrNumer { get; set; }

    public decimal? BsEDoZamowienia { get; set; }

    public short? BsEFlaga { get; set; }

    public virtual TwrKarty BsETwrNumerNavigation { get; set; } = null!;

    public virtual ICollection<BstSelem> BstSelems { get; set; } = new List<BstSelem>();
}
