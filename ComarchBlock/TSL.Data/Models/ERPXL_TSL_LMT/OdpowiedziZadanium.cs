using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class OdpowiedziZadanium
{
    public int OdzZadId { get; set; }

    public int OdzPytId { get; set; }

    public int? OdzAntId { get; set; }

    public string? OdzOpis { get; set; }

    public string? OdzTresc { get; set; }

    public int? OdzRodpId { get; set; }

    public int? OdzOdpId { get; set; }

    public decimal? OdzPytWaga { get; set; }

    public decimal? OdzGrupWaga { get; set; }

    public decimal? OdzPunkty { get; set; }

    public decimal? OdzPunktyWazone { get; set; }

    public short? OdzZatwierdzona { get; set; }

    public virtual ICollection<OdpowiedziZadaniaWielokrotne> OdpowiedziZadaniaWielokrotnes { get; set; } = new List<OdpowiedziZadaniaWielokrotne>();

    public virtual Zadanium OdzZad { get; set; } = null!;
}
