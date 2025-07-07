using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Informacje
{
    public int InfInfId { get; set; }

    public byte InfTypInformacji { get; set; }

    public byte InfTypDefinicji { get; set; }

    public string InfKod { get; set; } = null!;

    public string InfNazwa { get; set; } = null!;

    public byte InfModulId { get; set; }

    public int InfLp { get; set; }

    public int? InfTmiId { get; set; }

    public int? InfTmiIdDomyslny { get; set; }

    public byte InfTerminDomyslny { get; set; }

    public byte InfTypWykresu { get; set; }

    public int InfWkDid { get; set; }

    public int? InfProcId { get; set; }

    public int? InfOpeZalId { get; set; }

    public int? InfStaZalId { get; set; }

    public DateTime InfTsZal { get; set; }

    public int? InfOpeModId { get; set; }

    public int? InfStaModId { get; set; }

    public DateTime InfTsMod { get; set; }

    public string InfOpeModKod { get; set; } = null!;

    public string InfOpeModNazwisko { get; set; } = null!;

    public string InfOpeZalKod { get; set; } = null!;

    public string InfOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<OpeInformacje> OpeInformacjes { get; set; } = new List<OpeInformacje>();
}
