using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DzialyView
{
    public int DvDzlid { get; set; }

    public string DvDzlkod { get; set; } = null!;

    public int? DvDzlparentid { get; set; }

    public string DvDzlnazwa { get; set; } = null!;

    public int? DvDzllokId { get; set; }

    public short DvDzlnieaktywny { get; set; }

    public string DvDzlKonto { get; set; } = null!;
}
