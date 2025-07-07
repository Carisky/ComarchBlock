using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Wzorce
{
    public int WzrWzrId { get; set; }

    public string WzrNazwa { get; set; } = null!;

    public int WzrTyp { get; set; }

    public string WzrOpis { get; set; } = null!;

    public decimal WzrZmiennaCur1 { get; set; }

    public decimal WzrZmiennaCur2 { get; set; }

    public decimal WzrZmiennaCur3 { get; set; }

    public int WzrZmiennaInt1 { get; set; }

    public int WzrZmiennaInt2 { get; set; }

    public int WzrZmiennaInt3 { get; set; }

    public short WzrRodzaj { get; set; }

    public string WzrWzor { get; set; } = null!;

    public string WzrDodatkowe { get; set; } = null!;

    public short WzrLista { get; set; }

    public DateTime WzrDataOd { get; set; }

    public DateTime WzrDataDo { get; set; }

    public int? WzrOpeZalId { get; set; }

    public int? WzrStaZalId { get; set; }

    public DateTime WzrTsZal { get; set; }

    public int? WzrOpeModId { get; set; }

    public int? WzrStaModId { get; set; }

    public DateTime WzrTsMod { get; set; }

    public string WzrOpeModKod { get; set; } = null!;

    public string WzrOpeModNazwisko { get; set; } = null!;

    public string WzrOpeZalKod { get; set; } = null!;

    public string WzrOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<Parametry> Parametries { get; set; } = new List<Parametry>();
}
