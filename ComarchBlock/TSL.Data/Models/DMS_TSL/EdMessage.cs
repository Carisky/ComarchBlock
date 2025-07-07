using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class EdMessage
{
    public int EdmId { get; set; }

    public string EdmMessageId { get; set; } = null!;

    public string? EdmSenderName { get; set; }

    public string? EdmSubject { get; set; }

    public DateTime? EdmDeliveryDate { get; set; }

    public string? EdmTextBody { get; set; }

    public byte[]? EdmEvidencesFile { get; set; }

    public virtual ICollection<EdMessageAttachment> EdMessageAttachments { get; set; } = new List<EdMessageAttachment>();
}
