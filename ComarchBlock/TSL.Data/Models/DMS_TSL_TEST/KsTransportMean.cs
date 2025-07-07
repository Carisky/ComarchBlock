using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsTransportMean
{
    public int KsmId { get; set; }

    public int KsmDocumentId { get; set; }

    public DateTime? KsmNstdataDopuszczenia { get; set; }

    public int? KsmNstnrWierszaFa { get; set; }

    public string? KsmNstmarka { get; set; }

    public string? KsmNstmodel { get; set; }

    public string? KsmNstkolor { get; set; }

    public string? KsmNstnrRej { get; set; }

    public string? KsmNstrokProd { get; set; }

    public string? KsmNstprzebieg { get; set; }

    public string? KsmNstvin { get; set; }

    public string? KsmNstnrNadwozia { get; set; }

    public string? KsmNstnrPodwozia { get; set; }

    public string? KsmNstnrRamy { get; set; }

    public string? KsmNsttyp { get; set; }

    public string? KsmNstplywGodzRobocze { get; set; }

    public string? KsmNstnrKadluba { get; set; }

    public string? KsmNstpowGodzRobocze { get; set; }

    public string? KsmNstnrFabryczny { get; set; }

    public virtual KsDocument KsmDocument { get; set; } = null!;
}
