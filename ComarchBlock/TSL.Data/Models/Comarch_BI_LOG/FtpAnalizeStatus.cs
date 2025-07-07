using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class FtpAnalizeStatus
{
    public string FasId { get; set; } = null!;

    public string FasName { get; set; } = null!;

    public virtual ICollection<FtpAnalizeResult> FtpAnalizeResults { get; set; } = new List<FtpAnalizeResult>();
}
