using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Grupy
{
    public int GruGruId { get; set; }

    public short GruTyp { get; set; }

    public string GruNazwa { get; set; } = null!;

    public string GruOpis { get; set; } = null!;

    public short? GruFlaga { get; set; }

    public string GruNazwaPef { get; set; } = null!;

    public string? GruKontoWn { get; set; }

    public string? GruKontoMa { get; set; }

    public int? GruOpeZalId { get; set; }

    public int? GruStaZalId { get; set; }

    public DateTime? GruTsZal { get; set; }

    public string GruOpeZalKod { get; set; } = null!;

    public string GruOpeZalNazwisko { get; set; } = null!;

    public int? GruOpeModId { get; set; }

    public int? GruStaModId { get; set; }

    public DateTime? GruTsMod { get; set; }

    public string GruOpeModKod { get; set; } = null!;

    public string GruOpeModNazwisko { get; set; } = null!;

    public virtual ICollection<GrupaZakazy> GrupaZakazies { get; set; } = new List<GrupaZakazy>();

    public virtual ICollection<GrupyJezykObcy> GrupyJezykObcies { get; set; } = new List<GrupyJezykObcy>();
}
