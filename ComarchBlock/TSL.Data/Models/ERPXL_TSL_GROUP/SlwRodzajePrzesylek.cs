using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SlwRodzajePrzesylek
{
    public int SlrpId { get; set; }

    public int? SlrpSlwId { get; set; }

    public string? SlrpRodzaj { get; set; }

    public byte? SlrpNieaktywny { get; set; }

    public int? SlrpShipId { get; set; }

    public int? SlrpShipServiceId { get; set; }

    public virtual Slowniki? SlrpSlw { get; set; }
}
