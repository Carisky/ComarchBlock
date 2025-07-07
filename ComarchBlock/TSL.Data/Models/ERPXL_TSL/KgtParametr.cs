using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KgtParametr
{
    public int KparId { get; set; }

    public int? KparWszystkoPlId { get; set; }

    public string? KparNazwa { get; set; }

    public byte? KparTyp { get; set; }

    public virtual ICollection<KgtParametryKategorii> KgtParametryKategoriis { get; set; } = new List<KgtParametryKategorii>();
}
