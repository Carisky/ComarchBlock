using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class RejestryHistorium
{
    public int KrhKarnumer { get; set; }

    public short KrhLp { get; set; }

    public int KrhDataObowiazywania { get; set; }

    public byte? KrhWycenaKolejnosc { get; set; }

    public int? KrhDataModyfikacji { get; set; }

    public string? KrhOpeident { get; set; }

    public virtual Rejestry KrhKarnumerNavigation { get; set; } = null!;
}
