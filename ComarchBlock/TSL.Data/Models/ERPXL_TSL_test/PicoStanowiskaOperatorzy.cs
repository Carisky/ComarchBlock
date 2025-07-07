using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PicoStanowiskaOperatorzy
{
    public int PknPsaId { get; set; }

    public short? PknOpeTyp { get; set; }

    public int? PknOpeFirma { get; set; }

    public int PknOpeNumer { get; set; }

    public short? PknOpeLp { get; set; }

    public int? PknCzasModyfikacji { get; set; }

    public byte[]? PknHaslo { get; set; }

    public virtual OpeKarty PknOpeNumerNavigation { get; set; } = null!;

    public virtual PicoStanowiska PknPsa { get; set; } = null!;
}
