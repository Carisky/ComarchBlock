using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PodzielnikMelem
{
    public short PdmPdNtyp { get; set; }

    public int PdmPdNfirma { get; set; }

    public int PdmPdNnumer { get; set; }

    public short PdmPdNlp { get; set; }

    public short PdmFrStyp { get; set; }

    public int PdmFrSfirma { get; set; }

    public int PdmFrSnumer { get; set; }

    public short PdmFrSlp { get; set; }

    public short PdmPrcTyp { get; set; }

    public int PdmPrcFirma { get; set; }

    public int PdmPrcNumer { get; set; }

    public short PdmPrcLp { get; set; }

    public short PdmLp { get; set; }

    public int PdmDataMod { get; set; }

    public virtual PodzielnikNag PdmPdNnumerNavigation { get; set; } = null!;
}
