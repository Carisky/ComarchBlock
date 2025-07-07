using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Swpolecenium
{
    public int SwpPolecenieId { get; set; }

    public string? SwpPolecenieOpis { get; set; }

    public int? SwpProcId { get; set; }

    public int? SwpKontekstId { get; set; }

    public int? SwpWydrukId { get; set; }

    public int? SwpFormatId { get; set; }

    public string? SwpFiltrTps { get; set; }

    public string? SwpFiltrSql { get; set; }

    public string? SwpSortowanie { get; set; }

    public string? SwpDrukarkaNazwa { get; set; }

    public string? SwpDrukarkaPlik { get; set; }

    public short? SwpIloscKopii { get; set; }

    public byte? SwpWyslijMaila { get; set; }

    public string? SwpMailAdresat { get; set; }

    public string? SwpMailTemat { get; set; }

    public string? SwpMailTekst { get; set; }

    public byte? SwpDrukujZkolejki { get; set; }

    public int? SwpLData1 { get; set; }

    public int? SwpLData2 { get; set; }

    public int? SwpLData3 { get; set; }

    public string? SwpSSeria1 { get; set; }

    public string? SwpSSeria2 { get; set; }

    public string? SwpSSeria3 { get; set; }

    public string? SwpSTekst1 { get; set; }

    public string? SwpSTekst2 { get; set; }

    public string? SwpSTekst3 { get; set; }

    public int? SwpTsutworzenia { get; set; }

    public string? SwpAutor { get; set; }

    public short? SwpMaxIloscProb { get; set; }

    public short? SwpStan { get; set; }

    public short? SwpIloscProb { get; set; }

    public string? SwpSerwerNazwa { get; set; }

    public byte? SwpZrodloId { get; set; }

    public virtual ICollection<Swkolejka> Swkolejkas { get; set; } = new List<Swkolejka>();

    public virtual ICollection<Swzmienne> Swzmiennes { get; set; } = new List<Swzmienne>();
}
