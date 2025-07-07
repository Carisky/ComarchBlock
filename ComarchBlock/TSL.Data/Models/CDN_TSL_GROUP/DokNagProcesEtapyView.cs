using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DokNagProcesEtapyView
{
    public int DnPrDnPrId { get; set; }

    public int? DnPrDoNid { get; set; }

    public int? DnPrTyp { get; set; }

    public int DnPrLp { get; set; }

    public short DnPrPoziom { get; set; }

    public int DnPrPoprzedniLp { get; set; }
}
