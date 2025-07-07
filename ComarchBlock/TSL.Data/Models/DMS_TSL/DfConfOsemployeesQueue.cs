using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfOsemployeesQueue
{
    public int DcqId { get; set; }

    public Guid DcqGuid { get; set; }

    public string DcqLogin { get; set; } = null!;

    public string DcqName { get; set; } = null!;

    public string DcqPassword { get; set; } = null!;

    public string DcqMail { get; set; } = null!;

    public DateTime DcqExpirationDate { get; set; }

    public DateTime DcqRegistrationDate { get; set; }

    public string DcqIp { get; set; } = null!;

    public string? DcqNip { get; set; }

    public bool? DcqTermsAccepted { get; set; }

    public bool? DcqWorkConditionsAccepted { get; set; }
}
