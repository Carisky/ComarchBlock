using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class FtpFilesExtension
{
    public string FfeId { get; set; } = null!;

    public string FfeName { get; set; } = null!;

    public virtual ICollection<FtpFilesAnalize> FtpFilesAnalizes { get; set; } = new List<FtpFilesAnalize>();
}
