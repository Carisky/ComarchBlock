using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class SoaLog
{
    public int SloGSlogId { get; set; }

    public int? SloGParentId { get; set; }

    public Guid? SloGSession { get; set; }

    public DateTime SloGDate { get; set; }

    public int? SloGServiceId { get; set; }

    public string? SloGServiceName { get; set; }

    public string SloGThread { get; set; } = null!;

    public string SloGLevel { get; set; } = null!;

    public string SloGLogger { get; set; } = null!;

    public string? SloGUser { get; set; }

    public string? SloGDatabaseName { get; set; }

    public string? SloGDatabaseGuid { get; set; }

    public string? SloGMessage { get; set; }

    public string? SloGException { get; set; }
}
