using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Role
{
    public int RolId { get; set; }

    public string? RolNazwa { get; set; }

    public string? RolOpis { get; set; }

    public byte? RolOptimaKierownik { get; set; }

    public virtual ICollection<Prawa> RlPPras { get; set; } = new List<Prawa>();
}
