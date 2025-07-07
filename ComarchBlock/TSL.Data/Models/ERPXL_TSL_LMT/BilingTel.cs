using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class BilingTel
{
    public int BtelId { get; set; }

    public string? BtelOpTelOrgId { get; set; }

    public string? BtelNazwaPliku { get; set; }

    public DateTime? BtelDataWczytania { get; set; }

    public virtual OperatorTel? BtelOpTelOrg { get; set; }

    public virtual ICollection<RozmowaTel> RozmowaTels { get; set; } = new List<RozmowaTel>();
}
