using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DokNag
{
    public int DoNDoNid { get; set; }

    public int? DoNDdfId { get; set; }

    public int? DoNSsid { get; set; }

    public string DoNProcesKod { get; set; } = null!;

    public int DoNEtapBiezacyLp { get; set; }

    public string DoNNumerObcy { get; set; } = null!;

    public string DoNNumerString { get; set; } = null!;

    public string? DoNNumerPelny { get; set; }

    public int DoNNumerNr { get; set; }

    public string? DoNTytul { get; set; }

    public string? DoNDotyczy { get; set; }

    public DateTime DoNDataDok { get; set; }

    public int? DoNOpiekunId { get; set; }

    public int? DoNOpiekunTyp { get; set; }

    public int? DoNStatus { get; set; }

    public int? DoNTyp { get; set; }

    public int? DoNKatalog { get; set; }

    public string? DoNImportAppId { get; set; }

    public string? DoNImportRowId { get; set; }

    public int? DoNOriginId { get; set; }

    public DateTime? DoNTsExport { get; set; }

    public int? DoNOpeZalId { get; set; }

    public int? DoNStaZalId { get; set; }

    public DateTime DoNTsZal { get; set; }

    public int? DoNOpeModId { get; set; }

    public int? DoNStaModId { get; set; }

    public DateTime DoNTsMod { get; set; }

    public string DoNOpeModKod { get; set; } = null!;

    public string DoNOpeModNazwisko { get; set; } = null!;

    public string DoNOpeZalKod { get; set; } = null!;

    public string DoNOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<DokNagEtapyHistorium> DokNagEtapyHistoria { get; set; } = new List<DokNagEtapyHistorium>();

    public virtual ICollection<DokNagPliki> DokNagPlikis { get; set; } = new List<DokNagPliki>();

    public virtual ICollection<DokNagProcesEtapy> DokNagProcesEtapies { get; set; } = new List<DokNagProcesEtapy>();
}
