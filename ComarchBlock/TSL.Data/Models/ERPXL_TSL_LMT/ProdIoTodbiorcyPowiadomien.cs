using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdIoTodbiorcyPowiadomien
{
    public int PiokId { get; set; }

    public int? PiokDefZdarzeniaId { get; set; }

    public short? PiokObiTyp { get; set; }

    public int? PiokObiNumer { get; set; }

    public virtual ProdIoTzdarzeniaDefinicje? PiokDefZdarzenia { get; set; }
}
