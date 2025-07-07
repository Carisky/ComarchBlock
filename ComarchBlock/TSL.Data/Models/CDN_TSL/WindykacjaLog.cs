using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class WindykacjaLog
{
    public int WiLWiLid { get; set; }

    public DateTime WiLData { get; set; }

    public int WiLAkcja { get; set; }

    public int WiLAkcjaId { get; set; }

    public int WiLBlad { get; set; }

    public string WiLNumerDok { get; set; } = null!;

    public short WiLPodmiotTyp { get; set; }

    public int WiLPodmiotId { get; set; }

    public string WiLOpis { get; set; } = null!;

    public int WiLDokumentTyp { get; set; }

    public int WiLDokumentId { get; set; }

    public int WiLPlatnoscId { get; set; }

    public int WiLSource { get; set; }

    public Guid? WiLDokumentGuid { get; set; }
}
