using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class ServiceLog
{
    public int SloId { get; set; }

    public DateTime SloDate { get; set; }

    public string SloThread { get; set; } = null!;

    public string SloLevel { get; set; } = null!;

    public string SloLogger { get; set; } = null!;

    public string? SloController { get; set; }

    public string? SloAction { get; set; }

    public string? SloUser { get; set; }

    public int? SloCompanyId { get; set; }

    public int? SloDuration { get; set; }

    public string? SloDetails { get; set; }

    public string SloMessage { get; set; } = null!;

    public string? SloException { get; set; }
}
