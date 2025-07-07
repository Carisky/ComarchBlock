using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DmHeadTree
{
    public int DrtId { get; set; }

    public int? DrtDrtid { get; set; }

    public string DrtName { get; set; } = null!;

    public DateTime DrtCreationDate { get; set; }

    public int DrtDcdcreator { get; set; }

    public DateTime? DrtModificationDate { get; set; }

    public int? DrtDcdmodifiedById { get; set; }

    public int DrtType { get; set; }

    public int? DrtArchiveAfterTime { get; set; }

    public bool DrtVersioning { get; set; }

    public int DrtPosition { get; set; }

    public bool DrtArchived { get; set; }

    public bool DrtArchival { get; set; }

    public virtual ICollection<DmAccess> DmAccesses { get; set; } = new List<DmAccess>();

    public virtual ICollection<DmDocumentsBin> DmDocumentsBins { get; set; } = new List<DmDocumentsBin>();
}
