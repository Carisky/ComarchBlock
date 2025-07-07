using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Link
{
    public int LinReportId { get; set; }

    public int LinFolderId { get; set; }

    public string? LinName { get; set; }

    public bool LinIsMainLink { get; set; }

    public DateTime? LinCreatedOn { get; set; }

    public DateTime? LinModifiedOn { get; set; }

    public virtual Folder LinFolder { get; set; } = null!;

    public virtual Report LinReport { get; set; } = null!;
}
