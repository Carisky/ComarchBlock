using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Marki
{
    public int MrkMrkId { get; set; }

    public int? MrkPrdId { get; set; }

    public string MrkNazwa { get; set; } = null!;

    public int? MrkLogo { get; set; }

    public int? MrkOpeZalId { get; set; }

    public int? MrkStaZalId { get; set; }

    public DateTime MrkTsZal { get; set; }

    public int? MrkOpeModId { get; set; }

    public int? MrkStaModId { get; set; }

    public DateTime MrkTsMod { get; set; }

    public string MrkOpeModKod { get; set; } = null!;

    public string MrkOpeModNazwisko { get; set; } = null!;

    public string MrkOpeZalKod { get; set; } = null!;

    public string MrkOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<MarkiJezykObcy> MarkiJezykObcies { get; set; } = new List<MarkiJezykObcy>();

    public virtual Producenci? MrkPrd { get; set; }
}
