using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PodzielnikZelem
{
    public short PdzPdNtyp { get; set; }

    public int PdzPdNfirma { get; set; }

    public int PdzPdNnumer { get; set; }

    public int PdzPdNlp { get; set; }

    public short PdzFrStyp { get; set; }

    public int PdzFrSfirma { get; set; }

    public int PdzFrSnumer { get; set; }

    public short PdzFrSlp { get; set; }

    public short PdzPrcTyp { get; set; }

    public int PdzPrcFirma { get; set; }

    public int PdzPrcNumer { get; set; }

    public short PdzPrcLp { get; set; }

    public short PdzLp { get; set; }

    public int PdzTsdata { get; set; }

    public virtual PodzielnikNag PdzPdNnumerNavigation { get; set; } = null!;
}
