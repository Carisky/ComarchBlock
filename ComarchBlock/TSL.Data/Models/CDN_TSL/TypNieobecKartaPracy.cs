using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TypNieobecKartaPracy
{
    public int TnkTnkId { get; set; }

    public string TnkAkronim { get; set; } = null!;

    public string TnkNazwa { get; set; } = null!;

    public byte? TnkSortOrder { get; set; }

    public virtual ICollection<TypNieobec> TypNieobecs { get; set; } = new List<TypNieobec>();
}
