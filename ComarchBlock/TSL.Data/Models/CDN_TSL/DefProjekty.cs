using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DefProjekty
{
    public int PrjPrjId { get; set; }

    public string PrjKod { get; set; } = null!;

    public string PrjNazwa { get; set; } = null!;

    public string PrjSymbol { get; set; } = null!;

    public string PrjUrl { get; set; } = null!;

    public int? PrjParentId { get; set; }

    public short PrjPoziom { get; set; }

    public byte PrjNieaktywny { get; set; }

    public string PrjWezel { get; set; } = null!;

    public int PrjLp { get; set; }

    public int? PrjStaZalId { get; set; }

    public int? PrjOpeZalId { get; set; }

    public int? PrjStaModId { get; set; }

    public string PrjKonto { get; set; } = null!;

    public string? PrjImportAppId { get; set; }

    public string? PrjImportRowId { get; set; }

    public DateTime? PrjTsExport { get; set; }

    public int? PrjOpeModId { get; set; }

    public DateTime? PrjDataOtw { get; set; }

    public DateTime? PrjDataZam { get; set; }

    public DateTime? PrjTsZal { get; set; }

    public DateTime? PrjTsMod { get; set; }

    public string PrjOpeModKod { get; set; } = null!;

    public string PrjOpeModNazwisko { get; set; } = null!;

    public string PrjOpeZalKod { get; set; } = null!;

    public string PrjOpeZalNazwisko { get; set; } = null!;
}
