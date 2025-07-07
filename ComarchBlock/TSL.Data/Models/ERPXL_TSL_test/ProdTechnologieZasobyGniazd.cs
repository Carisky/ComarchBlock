using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdTechnologieZasobyGniazd
{
    public int PtgId { get; set; }

    public int? PtgTechnologiaOperacje { get; set; }

    public int? PtgZasobGniazda { get; set; }

    public int? PtgGniazdo { get; set; }

    public byte? PtgPlanowana { get; set; }

    public virtual ProdTechnologiaCzynnosci? PtgTechnologiaOperacjeNavigation { get; set; }

    public virtual ProdObiekty? PtgZasobGniazdaNavigation { get; set; }
}
