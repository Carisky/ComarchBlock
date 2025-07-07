using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraNagRelacje
{
    public int TrRTrRid { get; set; }

    public short TrRTrNtyp { get; set; }

    public int TrRTrNid { get; set; }

    public short TrRFaTyp { get; set; }

    public int TrRFaId { get; set; }

    public short? TrRFlaga { get; set; }
}
