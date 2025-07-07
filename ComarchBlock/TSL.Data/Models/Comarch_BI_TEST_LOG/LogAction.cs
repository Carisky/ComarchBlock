using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class LogAction
{
    public int LacId { get; set; }

    public int LacLogActionGroupId { get; set; }

    /// <summary>
    /// Name of Action
    /// </summary>
    public string LacActionName { get; set; } = null!;

    /// <summary>
    /// Duration of action in miliseconds
    /// </summary>
    public int LacDuration { get; set; }

    /// <summary>
    /// Foreign key to dbo.Levels
    /// </summary>
    public int LacSeverityId { get; set; }

    /// <summary>
    /// ToString() on arguments, additional data for action
    /// </summary>
    public string? LacParameters { get; set; }

    /// <summary>
    /// Stack trace of excetion if occured
    /// </summary>
    public string? LacException { get; set; }

    /// <summary>
    /// Action start date
    /// </summary>
    public DateTime LacDateTime { get; set; }

    /// <summary>
    /// Foreign key to dbo.Sessions
    /// </summary>
    public int LacSessionId { get; set; }

    /// <summary>
    /// Object ID which is subject of action
    /// </summary>
    public int? LacObjectId { get; set; }

    /// <summary>
    /// Id of action to group action with different translations
    /// </summary>
    public int LacActionId { get; set; }

    public bool LacShowInRecent { get; set; }

    public string? LacMessage { get; set; }

    public virtual LogActionGroup LacLogActionGroup { get; set; } = null!;

    public virtual Session LacSession { get; set; } = null!;

    public virtual Level LacSeverity { get; set; } = null!;
}
