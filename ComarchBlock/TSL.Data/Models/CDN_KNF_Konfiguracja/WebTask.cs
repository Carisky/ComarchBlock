using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WebTask
{
    public long TasTasId { get; set; }

    public DateTime TasCreatedDate { get; set; }

    public DateTime? TasEndDate { get; set; }

    public int TasOperatorId { get; set; }

    public DateTime? TasDeletedDate { get; set; }

    public bool TasDeleted { get; set; }

    public bool TasCancelled { get; set; }

    public int TasActionIndex { get; set; }

    public string? TasActionParams { get; set; }

    public virtual ICollection<WebSubtask> WebSubtasks { get; set; } = new List<WebSubtask>();
}
