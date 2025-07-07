using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class EdMessageAttachment
{
    public int EdaId { get; set; }

    public Guid? EdaAttachmentId { get; set; }

    public int EdaEdmid { get; set; }

    public string? EdaFileName { get; set; }

    public string? EdaContentType { get; set; }

    public long? EdaSize { get; set; }

    public byte[]? EdaContent { get; set; }

    public int EdaPosition { get; set; }

    public int? EdaAngleOfRotation { get; set; }

    public bool EdaArchival { get; set; }

    public virtual EdMessage EdaEdm { get; set; } = null!;
}
