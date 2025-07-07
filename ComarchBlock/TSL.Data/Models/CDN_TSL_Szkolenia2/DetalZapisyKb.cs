using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DetalZapisyKb
{
    public int DzkbDzkbid { get; set; }

    public int DzkbDszkbid { get; set; }

    public int DzkbStanDetalId { get; set; }

    public int DzkbDsfplId { get; set; }

    public int DzkbTypDokumentu { get; set; }

    public int DzkbNumerNr { get; set; }

    public string DzkbNumerString { get; set; } = null!;

    public string DzkbNumerPelny { get; set; } = null!;

    public DateTime DzkbDataDok { get; set; }

    public int? DzkbPodId { get; set; }

    public decimal DzkbRazemBrutto { get; set; }

    public int? DzkbStanSynchronizacji { get; set; }

    public int DzkbOpeId { get; set; }

    public string DzkbOpis { get; set; } = null!;

    public int? DzkbOptimaId { get; set; }

    public DateTime? DzkbTsExport { get; set; }

    public int DzkbDdfId { get; set; }

    public int DzkbTyp { get; set; }
}
