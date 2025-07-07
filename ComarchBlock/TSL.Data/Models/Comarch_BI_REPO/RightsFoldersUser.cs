using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class RightsFoldersUser
{
    public int RfuFolderId { get; set; }

    public int RfuUserId { get; set; }

    public byte RfuAccessRight { get; set; }

    public virtual Folder RfuFolder { get; set; } = null!;

    public virtual User1 RfuUser { get; set; } = null!;
}
