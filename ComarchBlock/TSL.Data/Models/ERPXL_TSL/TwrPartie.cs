using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TwrPartie
{
    public int TpaId { get; set; }

    public short? TpaTwrTyp { get; set; }

    public int? TpaTwrNumer { get; set; }

    public short? TpaCcktyp { get; set; }

    public int? TpaCcknumer { get; set; }

    public string? TpaCecha { get; set; }

    public string? TpaEan { get; set; }

    public int? TpaDataW { get; set; }

    public short? TpaDstTyp { get; set; }

    public int? TpaDstNumer { get; set; }

    public int? TpaWms { get; set; }

    public int? TpaZewn { get; set; }

    public int? TpaDataUtworzenia { get; set; }

    public virtual ICollection<PosrozbieznosciMmp> PosrozbieznosciMmps { get; set; } = new List<PosrozbieznosciMmp>();
}
