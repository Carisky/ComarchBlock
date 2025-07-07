using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Poreczyciele
{
    public int PorPorId { get; set; }

    public int PorDodId { get; set; }

    public int? PorPraId { get; set; }

    public string PorOsoba { get; set; } = null!;

    public string PorOpis { get; set; } = null!;

    public byte PorPoreczycielLista { get; set; }

    public int? PorOpeZalId { get; set; }

    public int? PorStaZalId { get; set; }

    public DateTime PorTsZal { get; set; }

    public int? PorOpeModId { get; set; }

    public int? PorStaModId { get; set; }

    public DateTime PorTsMod { get; set; }

    public string PorOpeModKod { get; set; } = null!;

    public string PorOpeModNazwisko { get; set; } = null!;

    public string PorOpeZalKod { get; set; } = null!;

    public string PorOpeZalNazwisko { get; set; } = null!;

    public virtual Dodatki PorDod { get; set; } = null!;
}
