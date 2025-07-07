using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class ApplicationUsersTable
{
    public int AutId { get; set; }

    public int AutTblid { get; set; }

    public int AutUsrid { get; set; }

    public bool AutReadOnly { get; set; }

    public virtual Table AutTbl { get; set; } = null!;

    public virtual ApplicationUser AutUsr { get; set; } = null!;
}
