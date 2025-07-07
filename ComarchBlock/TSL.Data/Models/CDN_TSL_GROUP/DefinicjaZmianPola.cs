using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DefinicjaZmianPola
{
    public int DzpDzpId { get; set; }

    public int DzpDfzId { get; set; }

    public string? DzpNazwa { get; set; }

    public byte DzpRodzaj { get; set; }

    public decimal? DzpWartosc { get; set; }

    public string DzpWartoscTekst { get; set; } = null!;

    public byte DzpNieaktywny { get; set; }

    public string DzpFormat { get; set; } = null!;

    public string DzpDodatkowe { get; set; } = null!;

    public string DzpKolekcja { get; set; } = null!;

    public string DzpInne { get; set; } = null!;

    public virtual DefinicjaZmian DzpDfz { get; set; } = null!;
}
