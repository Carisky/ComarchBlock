using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class AccountActiveUser
{
    public int AauId { get; set; }

    public int? AauAccountActiveId { get; set; }

    public int? AauUserId { get; set; }

    public virtual AccountActive? AauAccountActive { get; set; }

    public virtual User1? AauUser { get; set; }
}
