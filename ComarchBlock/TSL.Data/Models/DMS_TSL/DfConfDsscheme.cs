using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfDsscheme
{
    public int DssId { get; set; }

    public int DssDdsid { get; set; }

    public int? DssWaitingTime { get; set; }

    public int? DssDdsnextId { get; set; }

    public bool DssMixedMode { get; set; }

    public int? DssMaxNumberOfPassesMixMode { get; set; }

    public bool DssSendMail { get; set; }

    public int DssDshid { get; set; }

    public bool DssArchival { get; set; }

    public string? DssGuid { get; set; }

    public virtual ICollection<DfConfDsconnection> DfConfDsconnectionDscDssfroms { get; set; } = new List<DfConfDsconnection>();

    public virtual ICollection<DfConfDsconnection> DfConfDsconnectionDscDsstos { get; set; } = new List<DfConfDsconnection>();

    public virtual DfConfDsdictionary DssDds { get; set; } = null!;

    public virtual DfConfDshead DssDsh { get; set; } = null!;
}
