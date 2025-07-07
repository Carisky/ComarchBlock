using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class OpeZakazy
{
    public short? OpZOpeTyp { get; set; }

    public int? OpZOpeFirma { get; set; }

    public int OpZOpeNumer { get; set; }

    public short? OpZOpeLp { get; set; }

    public int OpZProcId { get; set; }

    public byte? OpZMaskaFormy { get; set; }

    public short? OpZMaskaFormyAtr { get; set; }

    public short? OpZMaskaFormyExp { get; set; }

    public virtual OpeKarty OpZOpeNumerNavigation { get; set; } = null!;
}
