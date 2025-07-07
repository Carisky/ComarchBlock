using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PodZestawy
{
    public int PozId { get; set; }

    public string? PozNazwa { get; set; }

    public int? PozDataU { get; set; }

    public byte? PozStatus { get; set; }

    public int? PozOpeWnumer { get; set; }

    public int? PozOpeMnumer { get; set; }

    public int? PozOpeBnumer { get; set; }
}
