using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class UserDatabase
{
    public int UdbConnectionId { get; set; }

    public int? UdbUserId { get; set; }

    public bool UdbIsDefaultMdxSqlRaportDatabase { get; set; }

    public int? UdbExternalUserId { get; set; }

    public virtual Connection UdbConnection { get; set; } = null!;

    public virtual User1? UdbUser { get; set; }
}
