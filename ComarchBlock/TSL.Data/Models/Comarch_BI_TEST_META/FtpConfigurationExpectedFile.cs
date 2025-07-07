using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class FtpConfigurationExpectedFile
{
    public string FcfeId { get; set; } = null!;

    public string FcfeName { get; set; } = null!;

    public virtual ICollection<FtpConfiguration> FtpConfigurationFcfFcfeidmainNavigations { get; set; } = new List<FtpConfiguration>();

    public virtual ICollection<FtpConfiguration> FtpConfigurationFcfFcfeidsubNavigations { get; set; } = new List<FtpConfiguration>();
}
