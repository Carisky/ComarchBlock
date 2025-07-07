using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class BudzetPrjElemDzialanium
{
    public int BpedId { get; set; }

    public int? BpedBpeid { get; set; }

    public int? BpedPozycja { get; set; }

    public byte? BpedWymiar { get; set; }

    public byte? BpedDzialanie1 { get; set; }

    public decimal? BpedWartosc1 { get; set; }

    public byte? BpedDzialanie2 { get; set; }

    public decimal? BpedWartosc2 { get; set; }

    public decimal? BpedWynikDzialania { get; set; }

    public decimal? BpedWynikCalosciowy { get; set; }

    public virtual BudzetPrjElem? BpedBpe { get; set; }

    public virtual ICollection<BudzetPrjElem> BpepBpes { get; set; } = new List<BudzetPrjElem>();
}
