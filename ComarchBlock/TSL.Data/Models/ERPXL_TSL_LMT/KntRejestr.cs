using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KntRejestr
{
    public int KrjId { get; set; }

    public short? KrjObiTyp { get; set; }

    public int? KrjObiFirma { get; set; }

    public int? KrjObiNumer { get; set; }

    public short? KrjObiLp { get; set; }

    public byte? KrjTypRejestru { get; set; }

    public string? KrjWaluta { get; set; }

    public byte? KrjPrzypiszDoPlatnosci { get; set; }

    public string? KrjNrRachunku { get; set; }

    public int? KrjKarNumer { get; set; }

    public string? KrjUwagi { get; set; }

    public int? KrjCzasArchiwizacji { get; set; }
}
