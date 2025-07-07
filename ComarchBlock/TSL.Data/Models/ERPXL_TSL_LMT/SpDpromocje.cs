using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SpDpromocje
{
    public int SpdId { get; set; }

    public int? SpdPrmId { get; set; }

    public short? SpdSpDtyp { get; set; }

    public int? SpdSpDlp { get; set; }

    public virtual PrmKarty? SpdPrm { get; set; }
}
