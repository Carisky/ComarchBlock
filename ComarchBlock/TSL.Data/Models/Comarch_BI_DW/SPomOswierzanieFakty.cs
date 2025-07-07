using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class SPomOswierzanieFakty
{
    public int Id { get; set; }

    public int Transid { get; set; }

    public string Etlnode { get; set; } = null!;

    public int DaysOfRefreshBefore { get; set; }

    public int DaysOfRefresh { get; set; }

    public bool Succed { get; set; }

    public int Area { get; set; }

    public DateTime Date { get; set; }
}
