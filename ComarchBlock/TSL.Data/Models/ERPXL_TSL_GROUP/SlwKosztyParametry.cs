using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SlwKosztyParametry
{
    public int SlpId { get; set; }

    public int? SlpSlwId { get; set; }

    public string? SlpNazwa { get; set; }

    public byte? SlpTyp { get; set; }

    public virtual Slowniki? SlpSlw { get; set; }
}
