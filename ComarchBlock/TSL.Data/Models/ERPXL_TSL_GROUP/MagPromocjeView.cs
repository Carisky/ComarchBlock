using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class MagPromocjeView
{
    public int MprvId { get; set; }

    public int? MprvPrmId { get; set; }

    public short? MprvMagTyp { get; set; }

    public int? MprvMagNumer { get; set; }

    public string MprvMagKod { get; set; } = null!;

    public string MprvMagNazwa { get; set; } = null!;
}
