using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class MlMail
{
    public int MlmId { get; set; }

    public int? MlmMessageId { get; set; }

    public DateTime? MlmDate { get; set; }

    public string? MlmFrom { get; set; }

    public string? MlmTo { get; set; }

    public string? MlmCc { get; set; }

    public string? MlmSubject { get; set; }

    public string? MlmBodyText { get; set; }

    public string? MlmMailBox { get; set; }

    public virtual ICollection<MlMailAttachment> MlMailAttachments { get; set; } = new List<MlMailAttachment>();
}
