using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class FtpConfigurationType
{
    public string FcftId { get; set; } = null!;

    public string FcftName { get; set; } = null!;

    public virtual ICollection<FtpConfiguration> FtpConfigurations { get; set; } = new List<FtpConfiguration>();
}
