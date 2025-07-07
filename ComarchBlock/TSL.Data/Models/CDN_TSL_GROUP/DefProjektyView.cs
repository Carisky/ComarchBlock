using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DefProjektyView
{
    public int DvPrjid { get; set; }

    public string DvPrjkod { get; set; } = null!;

    public int? DvPrjparentid { get; set; }

    public string DvPrjnazwa { get; set; } = null!;

    public byte DvPrjnieaktywny { get; set; }

    public string DvPrjkonto { get; set; } = null!;
}
