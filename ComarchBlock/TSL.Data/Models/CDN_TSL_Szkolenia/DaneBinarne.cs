using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DaneBinarne
{
    public int DabDabid { get; set; }

    public byte DabMagazynDanych { get; set; }

    public string? DabMagazynDanychId { get; set; }

    public int? DabTyp { get; set; }

    public int? DabFlaga { get; set; }

    public int DabTwAid { get; set; }

    public byte[]? DabWartosc { get; set; }

    public int? DabRozmiar { get; set; }

    public int? DabRozmiarWartosci { get; set; }

    public string DabNazwaPliku { get; set; } = null!;

    public string? DabNazwa { get; set; }

    public string? DabRozszerzenie { get; set; }

    public string DabSciezka { get; set; } = null!;

    public string? DabWersja { get; set; }

    public long? DabIbard24Id { get; set; }

    public string? DabIbard24LinkPrywatny { get; set; }

    public int? DabOpeZalId { get; set; }

    public int? DabStaZalId { get; set; }

    public DateTime DabTsZal { get; set; }

    public int? DabOpeModId { get; set; }

    public int? DabStaModId { get; set; }

    public DateTime DabTsMod { get; set; }

    public string DabOpeModKod { get; set; } = null!;

    public string DabOpeModNazwisko { get; set; } = null!;

    public string DabOpeZalKod { get; set; } = null!;

    public string DabOpeZalNazwisko { get; set; } = null!;

    public Guid? DabGuid { get; set; }

    public Guid? DabESklepZalVerId { get; set; }

    public Guid? DabESklepZalId { get; set; }

    public int? DabESklepJezykId { get; set; }

    public int? DabESklepId { get; set; }
}
