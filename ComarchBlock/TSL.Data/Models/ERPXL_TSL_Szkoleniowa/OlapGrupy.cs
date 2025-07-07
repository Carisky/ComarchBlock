using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OlapGrupy
{
    public int OgrId { get; set; }

    public string? OgrNazwa { get; set; }

    public short? OgrWlaTyp { get; set; }

    public int? OgrWlaFirma { get; set; }

    public int? OgrWlaNumer { get; set; }

    public short? OgrWlaLp { get; set; }

    public string? OgrHaslo { get; set; }

    public int? OgrDataUtw { get; set; }

    public short? OgrPrcTypZ { get; set; }

    public int? OgrPrcFirmaZ { get; set; }

    public int? OgrPrcNumerZ { get; set; }

    public short? OgrPrcLpZ { get; set; }

    public virtual ICollection<Olaplinki> Olaplinkis { get; set; } = new List<Olaplinki>();
}
