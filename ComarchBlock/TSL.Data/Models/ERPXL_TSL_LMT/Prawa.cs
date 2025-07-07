using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Prawa
{
    public int PraId { get; set; }

    public int? PraRodzaj { get; set; }

    public string? PraNazwa { get; set; }

    public string? PraOpis { get; set; }

    public virtual ICollection<Role> RlPRols { get; set; } = new List<Role>();
}
