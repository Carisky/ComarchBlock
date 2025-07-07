using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class RightsFoldersGroup
{
    public int RfgFolderId { get; set; }

    public int RfgGroupId { get; set; }

    public byte RfgAccessRight { get; set; }

    public virtual Folder RfgFolder { get; set; } = null!;

    public virtual Group1 RfgGroup { get; set; } = null!;
}
