using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class Department
{
    public int DepId { get; set; }

    public string DepName { get; set; } = null!;

    public bool DepIsCentral { get; set; }

    public string? DepServerName { get; set; }

    public string? DepMetaDatabaseName { get; set; }

    public string? DepLogDatabaseName { get; set; }

    public string? DepWarehouseDatabaseName { get; set; }

    public string? DepAdministratorName { get; set; }

    public string? DepAdministratorEmail { get; set; }

    public string? DepDatabaseLogin { get; set; }

    public bool DepIntegratedLogin { get; set; }

    public string? DepPassword { get; set; }

    public DateTime DepTsinsert { get; set; }

    public DateTime DepTsupdate { get; set; }

    public byte[] DepRowVersion { get; set; } = null!;

    public virtual ICollection<LogicalSource> LogicalSources { get; set; } = new List<LogicalSource>();

    public virtual ICollection<Setting> Settings { get; set; } = new List<Setting>();
}
