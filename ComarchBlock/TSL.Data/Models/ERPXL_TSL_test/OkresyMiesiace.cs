using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class OkresyMiesiace
{
    public int OkmOkrId { get; set; }

    public short OkmRok { get; set; }

    public short OkmMiesiac { get; set; }

    public int? OkmMiesiacOd { get; set; }

    public int? OkmMiesiacDo { get; set; }

    public virtual Okresy OkmOkr { get; set; } = null!;
}
