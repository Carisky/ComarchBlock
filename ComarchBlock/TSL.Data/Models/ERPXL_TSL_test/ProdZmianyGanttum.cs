using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdZmianyGanttum
{
    public int PzgFrsid { get; set; }

    public byte PzgNumer { get; set; }

    public string? PzgKod { get; set; }

    public int? PzgGodzinaOd { get; set; }

    public int? PzgGodzinaDo { get; set; }

    public byte? PzgAktywny { get; set; }

    public virtual FrmStruktura PzgFrs { get; set; } = null!;
}
