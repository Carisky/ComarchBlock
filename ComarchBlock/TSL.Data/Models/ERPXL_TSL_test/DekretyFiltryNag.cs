using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class DekretyFiltryNag
{
    public int DfnId { get; set; }

    public short? DfnObiTyp { get; set; }

    public int? DfnObiFirma { get; set; }

    public int? DfnObiNumer { get; set; }

    public short? DfnObiLp { get; set; }

    public string? DfnOpeNumer { get; set; }

    public string? DfnFiltrSql { get; set; }

    public string? DfnFiltrWmrSql { get; set; }

    public string? DfnFiltrAtrSql { get; set; }

    public int? DfnTs { get; set; }

    public virtual ICollection<DekretyFiltryElem> DekretyFiltryElems { get; set; } = new List<DekretyFiltryElem>();
}
