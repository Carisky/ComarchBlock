using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Process
{
    public int PrcId { get; set; }

    public string PrcName { get; set; } = null!;

    public int PrcState { get; set; }

    public string PrcUserName { get; set; } = null!;

    public int? PrcInId { get; set; }

    public string PrcXmlDefinition { get; set; } = null!;

    public DateTime PrcDateCreate { get; set; }

    public DateTime PrcDateLastEdit { get; set; }

    public string PrcLastEditUserName { get; set; } = null!;

    public int PrcCreatorSourceSystemId { get; set; }

    public virtual Input? PrcIn { get; set; }

    public virtual ICollection<Target> Targets { get; set; } = new List<Target>();
}
