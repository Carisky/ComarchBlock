using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdCzynnosciObiekty
{
    public int PcoCzynnosc { get; set; }

    public int PcoFunkcja { get; set; }

    public int PcoObiekt { get; set; }

    public int PcoTermin { get; set; }

    public decimal? PcoKoszt { get; set; }

    public decimal? PcoKosztPrzygotowania { get; set; }

    public decimal? PcoKosztZakonczenia { get; set; }

    public int PcoId { get; set; }

    public byte? PcoZablokowany { get; set; }

    public byte? PcoPochodzenie { get; set; }

    public virtual ProdCzynnosci PcoCzynnoscNavigation { get; set; } = null!;
}
