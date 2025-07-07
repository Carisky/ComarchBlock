using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class WfDefZadanium
{
    public int WdzId { get; set; }

    public int? WdzWdpid { get; set; }

    public int? WdzWdsid { get; set; }

    public int? WdzWdaid { get; set; }

    public int? WdzWynik { get; set; }

    public int? WdzLp { get; set; }

    public short? WdzWstecz { get; set; }

    public byte? WdzOpiekunTyp { get; set; }

    public int? WdzOpiekunId { get; set; }

    public string? WdzOpiekunSql { get; set; }

    public virtual WfDefProcesy? WdzWdp { get; set; }

    public virtual ICollection<WfDefStatKonc> WfDefStatKoncs { get; set; } = new List<WfDefStatKonc>();
}
