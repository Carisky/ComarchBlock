using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Notification
{
    public int NotId { get; set; }

    public string? NotDescriptionPl { get; set; }

    public string? NotDescriptionEn { get; set; }

    public string? NotDescriptionDe { get; set; }

    public string? NotDescriptionFr { get; set; }

    public DateTime NotDateFrom { get; set; }

    public DateTime NotDateTo { get; set; }

    public int NotCookieInterval { get; set; }

    public string? NotShowPath { get; set; }

    public string? NotHidePath { get; set; }

    public int NotType { get; set; }

    public int? NotWorkMode { get; set; }
}
