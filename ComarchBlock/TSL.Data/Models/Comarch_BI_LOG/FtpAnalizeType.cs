using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class FtpAnalizeType
{
    public string FatId { get; set; } = null!;

    public string FatName { get; set; } = null!;

    public virtual ICollection<FtpAnalizeResult> FtpAnalizeResults { get; set; } = new List<FtpAnalizeResult>();
}
