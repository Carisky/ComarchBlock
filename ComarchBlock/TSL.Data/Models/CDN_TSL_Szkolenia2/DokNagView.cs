using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DokNagView
{
    public int DnvDoNid { get; set; }

    public int? DnvDdfId { get; set; }

    public int? DnvSsid { get; set; }

    public string DnvProcesKod { get; set; } = null!;

    public int DnvEtapBiezacyLp { get; set; }

    public string DnvNumerObcy { get; set; } = null!;

    public string DnvNumerString { get; set; } = null!;

    public string? DnvNumerPelny { get; set; }

    public int DnvNumerNr { get; set; }

    public DateTime DnvDataDok { get; set; }

    public string? DnvTytul { get; set; }

    public string? DnvDotyczy { get; set; }

    public int? DnvOpiekunId { get; set; }

    public int? DnvOpiekunTyp { get; set; }

    public int? DnvStatus { get; set; }

    public int? DnvTyp { get; set; }

    public int? DnvKatalog { get; set; }

    public string? DnvKatalogSymbol { get; set; }

    public string? DnvKatalogNazwa { get; set; }

    public int? DnvOriginId { get; set; }

    public int? DnvOpeZalId { get; set; }

    public int? DnvStaZalId { get; set; }

    public DateTime DnvTsZal { get; set; }

    public int? DnvOpeModId { get; set; }

    public int? DnvStaModId { get; set; }

    public DateTime DnvTsMod { get; set; }
}
