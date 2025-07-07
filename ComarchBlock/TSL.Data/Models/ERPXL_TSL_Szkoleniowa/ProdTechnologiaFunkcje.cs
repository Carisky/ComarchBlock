using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdTechnologiaFunkcje
{
    public int PtfTechnologiaCzynnosc { get; set; }

    public int PtfFunkcja { get; set; }

    public short? PtfLiczbaObiektow { get; set; }

    public short? PtfWszystkie { get; set; }

    public byte? PtfZmienna { get; set; }

    public decimal? PtfCenaKosztorysu { get; set; }

    public byte? PtfPlanowana { get; set; }

    public byte? PtfCzyZrownoleglac { get; set; }

    public byte? PtfKontynuacjaPracy { get; set; }

    public int? PtfTypGniazda { get; set; }

    public byte? PtfTenSamZasobWpartiach { get; set; }

    public virtual ProdTechnologiaCzynnosci PtfTechnologiaCzynnoscNavigation { get; set; } = null!;
}
