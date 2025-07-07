using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkCfbin
{
    public Guid DwbId { get; set; }

    public int? DwbDwcid { get; set; }

    public int? DwbPos { get; set; }

    public byte[]? DwbBin { get; set; }

    public string? DwbName { get; set; }

    public string? DwbFilePath { get; set; }

    public int? DwbMode { get; set; }

    public int? DwbErpid { get; set; }

    public int? DwbSize { get; set; }

    public int? DwbArchival { get; set; }

    public DateTime? DwbCreateDate { get; set; }

    public int? DwbCompanyId { get; set; }

    public DateTime? DwbModificationData { get; set; }

    public int? DwbDdsid { get; set; }

    public int? DwbDcdid { get; set; }

    public int? DwbAngleOfRotation { get; set; }

    public int? DwbDrtid { get; set; }

    public long? DwbIbardId { get; set; }

    public string? DwbArchiveDocumentTypeId { get; set; }

    public string? DwbArchiveDocumentId { get; set; }

    public string? DwbArchiveDocumentLocationId { get; set; }

    public string? DwbArchiveDocumentLinkId { get; set; }

    public bool? DwbSigned { get; set; }

    public int DwbIdint { get; set; }

    public virtual DfWorkCf? DwbDwc { get; set; }
}
