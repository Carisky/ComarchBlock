using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class MobileReportsSnapshot
{
    public int MrsId { get; set; }

    public byte[] MrsSnapshot { get; set; } = null!;

    public int MrsSnapshotSize { get; set; }

    public string MrsLayout { get; set; } = null!;

    public string MrsColumns { get; set; } = null!;

    public DateTime MrsCreatedOn { get; set; }

    public virtual ICollection<MobileReportsUsersSnapshot> MobileReportsUsersSnapshots { get; set; } = new List<MobileReportsUsersSnapshot>();
}
