using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class RsResourceCompany
{
    public int RrcId { get; set; }

    public string RrcRrsid { get; set; } = null!;

    public int RrcCompanyId { get; set; }
}
