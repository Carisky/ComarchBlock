using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class BnkRachZakazy
{
    public int BrzBrzid { get; set; }

    public int BrzBraId { get; set; }

    public int BrzOpeId { get; set; }

    public byte BrzRachL { get; set; }

    public byte BrzRachP { get; set; }

    public byte BrzRachZ { get; set; }

    public byte BrzRachR { get; set; }

    public byte BrzRachU { get; set; }

    public byte BrzRachS { get; set; }

    public byte BrzRapD { get; set; }

    public byte BrzRapP { get; set; }

    public byte BrzRapZ { get; set; }

    public byte BrzRapZc { get; set; }

    public byte BrzRapU { get; set; }

    public byte BrzRapUc { get; set; }

    public byte BrzZdarzD { get; set; }

    public byte BrzZdarzP { get; set; }

    public byte BrzZdarzZ { get; set; }

    public byte BrzZdarzZc { get; set; }

    public byte BrzZdarzU { get; set; }

    public byte BrzZdarzUc { get; set; }

    public byte BrzZapD { get; set; }

    public byte BrzZapP { get; set; }

    public byte BrzZapZ { get; set; }

    public byte BrzZapZc { get; set; }

    public byte BrzZapU { get; set; }

    public byte BrzZapUc { get; set; }

    public virtual BnkRachunki BrzBra { get; set; } = null!;
}
