using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class WfHarmonogramAutomatu
{
    public int WfhId { get; set; }

    public int? WfhSlwId { get; set; }

    public int? WfhDataRozpoczecia { get; set; }

    public int? WfhDataZakonczenia { get; set; }

    public int? WfhGodzinaRozpoczecia { get; set; }

    public int? WfhGodzinaZakonczenia { get; set; }

    public short? WfhTypCyklu { get; set; }

    public short? WfhOdstep { get; set; }

    public short? WfhDni { get; set; }

    public int? WfhInterwal { get; set; }

    public virtual Slowniki? WfhSlw { get; set; }
}
