using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class PmaProcessMailsAttachment
{
    public int PmaId { get; set; }

    public string PmaName { get; set; } = null!;

    public byte[] PmaData { get; set; } = null!;

    public int? PmaPmid { get; set; }

    public virtual PmProcessMail? PmaPm { get; set; }
}
