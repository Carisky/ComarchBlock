using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WebSubtask
{
    public long StaStaId { get; set; }

    public long StaTasId { get; set; }

    public DateTime StaCreationDateTime { get; set; }

    public DateTime? StaStartDateTime { get; set; }

    public DateTime? StaEndDateTime { get; set; }

    public Guid StaDatabaseGuid { get; set; }

    public string StaCommandName { get; set; } = null!;

    public string StaJsonData { get; set; } = null!;

    public bool StaInstanceAction { get; set; }

    public int StaStatus { get; set; }

    public virtual WebTask StaTas { get; set; } = null!;

    public virtual ICollection<WebSubtasksLog> WebSubtasksLogs { get; set; } = new List<WebSubtasksLog>();
}
