using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfCmsetting
{
    public string CmsName { get; set; } = null!;

    public string CmsUrl { get; set; } = null!;

    public string? CmsErpdbmap { get; set; }
}
