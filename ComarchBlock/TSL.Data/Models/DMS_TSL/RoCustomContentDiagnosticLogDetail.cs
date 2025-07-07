using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class RoCustomContentDiagnosticLogDetail
{
    public int Id { get; set; }

    public int LogTypeId { get; set; }

    public string? LogType { get; set; }

    public int? UserId { get; set; }

    public int? WorkflowInstanceIdDshid { get; set; }

    public int? WorkflowId { get; set; }

    public int? DocumentId { get; set; }

    public int? ControlId { get; set; }

    public string? ControlType { get; set; }

    public int? MultilineControlListId { get; set; }

    public DateTime StartTime { get; set; }

    public int Duration { get; set; }

    public Guid? EventGuid { get; set; }

    public int? SessionId { get; set; }
}
