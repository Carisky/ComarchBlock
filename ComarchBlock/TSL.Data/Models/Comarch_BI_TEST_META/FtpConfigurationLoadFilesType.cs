using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class FtpConfigurationLoadFilesType
{
    public string FcflId { get; set; } = null!;

    public string FcflName { get; set; } = null!;

    public virtual ICollection<FtpConfiguration> FtpConfigurationFcfFcflidmainNavigations { get; set; } = new List<FtpConfiguration>();

    public virtual ICollection<FtpConfiguration> FtpConfigurationFcfFcflidsubNavigations { get; set; } = new List<FtpConfiguration>();
}
