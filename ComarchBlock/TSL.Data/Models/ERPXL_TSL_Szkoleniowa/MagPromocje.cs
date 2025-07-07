using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class MagPromocje
{
    public int MprId { get; set; }

    public int? MprPrmId { get; set; }

    public short? MprMagTyp { get; set; }

    public int? MprMagNumer { get; set; }

    public virtual PrmKarty? MprPrm { get; set; }
}
