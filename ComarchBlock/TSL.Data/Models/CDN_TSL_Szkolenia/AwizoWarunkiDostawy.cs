using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AwizoWarunkiDostawy
{
    public int AwwdAwwdid { get; set; }

    public string AwwdKod { get; set; } = null!;

    public string AwwdNazwa { get; set; } = null!;
}
