using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class PmProcessMail
{
    public int PmId { get; set; }

    public string PmCcRecipients { get; set; } = null!;

    public string? PmBccRecipients { get; set; }

    public string? PmSubject { get; set; }

    public string? PmBody { get; set; }

    public short? PmSent { get; set; }

    public virtual ICollection<PmaProcessMailsAttachment> PmaProcessMailsAttachments { get; set; } = new List<PmaProcessMailsAttachment>();
}
