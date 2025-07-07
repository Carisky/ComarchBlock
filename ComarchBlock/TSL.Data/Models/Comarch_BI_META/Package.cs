using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Package
{
    public int PacId { get; set; }

    public string PacName { get; set; } = null!;

    public int PacState { get; set; }

    public string PacCreatorName { get; set; } = null!;

    public DateTime PacDateCreate { get; set; }

    public string PacLastEditorName { get; set; } = null!;

    public DateTime PacDateLastEdited { get; set; }

    public string PacXmlDefinition { get; set; } = null!;

    public int PacCreatorSourceSystemId { get; set; }

    public int? PacRefreshData { get; set; }
}
