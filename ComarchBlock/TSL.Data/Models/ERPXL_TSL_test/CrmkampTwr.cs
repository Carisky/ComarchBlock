using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class CrmkampTwr
{
    public int CktId { get; set; }

    public int? CktCknnumer { get; set; }

    public short? CktTwrTyp { get; set; }

    public int? CktTwrNumer { get; set; }

    public decimal? CktPrzychodIlosc { get; set; }

    public virtual CrmkampNag? CktCknnumerNavigation { get; set; }

    public virtual ICollection<CrmkntEtapyTwr> CrmkntEtapyTwrs { get; set; } = new List<CrmkntEtapyTwr>();
}
