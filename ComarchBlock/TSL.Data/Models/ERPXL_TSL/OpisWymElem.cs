using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class OpisWymElem
{
    public short OweGidtyp { get; set; }

    public int? OweGidfirma { get; set; }

    public int OweGidnumer { get; set; }

    public short OweGidlp { get; set; }

    public short? OwePozycja { get; set; }

    public decimal? OweWartosc { get; set; }

    public decimal? OweProcent { get; set; }

    public short? OweKierunek { get; set; }

    public short? OweTyp { get; set; }

    public virtual OpisWymNag OpisWymNag { get; set; } = null!;

    public virtual ICollection<OpisWymSelem> OpisWymSelems { get; set; } = new List<OpisWymSelem>();
}
