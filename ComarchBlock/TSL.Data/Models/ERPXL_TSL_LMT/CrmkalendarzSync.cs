using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class CrmkalendarzSync
{
    public int CksId { get; set; }

    public int? CksSyncNumer { get; set; }

    public short? CksSyncTyp { get; set; }

    public int? CksObiNumer { get; set; }

    public short? CksObiTyp { get; set; }

    public string? CksOutlookId { get; set; }

    public string? CksGoogleId { get; set; }

    public int? CksCzasUsuniecia { get; set; }
}
