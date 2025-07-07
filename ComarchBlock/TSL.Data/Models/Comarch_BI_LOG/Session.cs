using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class Session
{
    public string SesUserLogin { get; set; } = null!;

    public DateTime SesLoginDate { get; set; }

    public DateTime? SesLogoutDate { get; set; }

    public byte[] SesRowVersion { get; set; } = null!;

    public string? SesDescription { get; set; }

    public string? SesMachineIp { get; set; }

    public string? SesMachineName { get; set; }

    public int SesUserId { get; set; }

    public int SesCompanyId { get; set; }

    public string? SesCompanyName { get; set; }

    public int SesId { get; set; }

    public virtual ICollection<LogAction> LogActions { get; set; } = new List<LogAction>();

    public virtual ICollection<Transformation> Transformations { get; set; } = new List<Transformation>();
}
