using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdZabiegiOperacji
{
    public int PzoId { get; set; }

    public int? PzoLp { get; set; }

    public int? PzoTechnologiaCzynnosc { get; set; }

    public string? PzoKod { get; set; }

    public string? PzoNazwa { get; set; }

    public string? PzoNrInstrukcji { get; set; }

    public decimal? PzoIlosc { get; set; }

    public string? PzoOpis { get; set; }

    public virtual ProdTechnologiaCzynnosci? PzoTechnologiaCzynnoscNavigation { get; set; }
}
