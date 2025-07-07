using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfHeadDokumentFlow
{
    public int DfhId { get; set; }

    public int DfhType { get; set; }

    public string DfhName { get; set; } = null!;

    public DateTime? DfhCreateDate { get; set; }

    public bool? DfhArchives { get; set; }

    public string? DfhSymbol { get; set; }

    public int? DfhSddtyp { get; set; }

    public string? DfhPrefix { get; set; }

    public bool DfhChangesHistory { get; set; }

    public int DfhPosition { get; set; }

    public int? DfhDdwid { get; set; }

    public int DfhIconId { get; set; }

    public string? DfhCreatedInDmsversion { get; set; }

    public bool DfhIsLocked { get; set; }

    public int? DfhLockedByUserId { get; set; }

    public int? DfhLockedByCompanyId { get; set; }

    public DateTime? DfhLockedTimestamp { get; set; }

    public virtual ICollection<DfConfDshead> DfConfDsheads { get; set; } = new List<DfConfDshead>();

    public virtual ICollection<DfConfDssettingsObserver> DfConfDssettingsObservers { get; set; } = new List<DfConfDssettingsObserver>();
}
