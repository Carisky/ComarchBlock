using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class MlWorkApprocess
{
    public int MlwId { get; set; }

    public int MlwApdid { get; set; }

    public int? MlwMailId { get; set; }

    public DateTime? MlwCreateDate { get; set; }

    public int MlwOperatorId { get; set; }

    public byte MlwStatus { get; set; }

    public bool MlwArchival { get; set; }

    public DateTime? MlwProcessDate { get; set; }
}
