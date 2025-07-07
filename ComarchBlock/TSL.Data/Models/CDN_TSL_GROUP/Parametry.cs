using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Parametry
{
    public int PrmPrmId { get; set; }

    public int PrmWzrId { get; set; }

    public string PrmNazwa { get; set; } = null!;

    public int PrmTyp { get; set; }

    public decimal PrmWartosc1 { get; set; }

    public decimal PrmWartosc2 { get; set; }

    public int PrmWartoscInt1 { get; set; }

    public int PrmWartoscInt2 { get; set; }

    public string PrmWzor { get; set; } = null!;

    public string PrmDodatkowe { get; set; } = null!;

    public int PrmNumer { get; set; }

    public virtual Wzorce PrmWzr { get; set; } = null!;
}
