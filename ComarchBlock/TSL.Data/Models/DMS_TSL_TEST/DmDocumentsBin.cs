using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DmDocumentsBin
{
    public Guid DrbId { get; set; }

    public int DrbDrtid { get; set; }

    public byte[] DrbBin { get; set; } = null!;

    public int DrbSize { get; set; }

    public string DrbName { get; set; } = null!;

    public string? DrbExtension { get; set; }

    public int DrbVersion { get; set; }

    public DateTime DrbCreationDate { get; set; }

    public int DrbDcdcreation { get; set; }

    public long? DrbIbardFileId { get; set; }

    public virtual DmHeadTree DrbDrt { get; set; } = null!;
}
