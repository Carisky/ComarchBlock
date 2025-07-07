using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class FtpFilesAnalizeStatus
{
    public string FfsId { get; set; } = null!;

    public string FfsName { get; set; } = null!;

    public virtual ICollection<FtpFilesAnalize> FtpFilesAnalizes { get; set; } = new List<FtpFilesAnalize>();
}
