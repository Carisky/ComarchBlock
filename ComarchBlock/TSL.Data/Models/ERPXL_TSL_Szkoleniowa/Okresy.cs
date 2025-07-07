using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Okresy
{
    public int OkrId { get; set; }

    public string? OkrOpis { get; set; }

    public int? OkrPoczatek { get; set; }

    public int? OkrKoniec { get; set; }

    public int? OkrZamknietyDo { get; set; }

    public int? OkrOpeZgidnumer { get; set; }

    public string? OkrSymbol { get; set; }

    public byte? OkrSymbolWnr { get; set; }

    public virtual ICollection<Kontum> Konta { get; set; } = new List<Kontum>();

    public virtual ICollection<OkresyMiesiace> OkresyMiesiaces { get; set; } = new List<OkresyMiesiace>();
}
