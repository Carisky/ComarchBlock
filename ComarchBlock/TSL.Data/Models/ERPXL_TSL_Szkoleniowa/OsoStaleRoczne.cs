using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OsoStaleRoczne
{
    public int OroId { get; set; }

    public int? OroGidnumer { get; set; }

    public int? OroOsoNumer { get; set; }

    public int? OroDataOd { get; set; }

    public int? OroDataDo { get; set; }

    public int? OroTypProgow { get; set; }

    public int? OroKosztUzyskaniaZtytulu { get; set; }

    public decimal? OroMnoznikKosztu { get; set; }

    public decimal? OroProcentWynag { get; set; }

    public decimal? OroMnoznikUlgi { get; set; }

    public int? OroUrzad { get; set; }

    public int? OroOpeWnumer { get; set; }

    public int? OroCzasWprowadzenia { get; set; }

    public int? OroOpeMnumer { get; set; }

    public int? OroCzasModyfikacji { get; set; }

    public virtual ICollection<OsoWskazniki> OsoWskaznikis { get; set; } = new List<OsoWskazniki>();
}
