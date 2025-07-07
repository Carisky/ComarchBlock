using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PodElemNagListy
{
    public short PenPontyp { get; set; }

    public int PenPonnumer { get; set; }

    public short PenPoelp { get; set; }

    public int PenId { get; set; }

    public short? PenObiTyp { get; set; }

    public int? PenObiNumer { get; set; }

    public short? PenObiLp { get; set; }

    public short? PenObiLp1 { get; set; }

    public virtual PodElem PodElem { get; set; } = null!;

    public virtual ICollection<PodElemListy> PodElemListies { get; set; } = new List<PodElemListy>();
}
