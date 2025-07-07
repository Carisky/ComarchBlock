using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class MagWybor
{
    public int MgWSesjaId { get; set; }

    public int MgWWatek { get; set; }

    public int MgWLp { get; set; }

    public short MgWMagTyp { get; set; }

    public int? MgWMagFirma { get; set; }

    public int? MgWMagNumer { get; set; }

    public short? MgWMagLp { get; set; }

    public virtual Magazyny? MgWMagNumerNavigation { get; set; }
}
