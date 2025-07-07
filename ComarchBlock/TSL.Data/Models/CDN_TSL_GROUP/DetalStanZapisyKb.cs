using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DetalStanZapisyKb
{
    public int DszkbDszkbid { get; set; }

    public int DszkbStanDetalId { get; set; }

    public int DszkbDsfplId { get; set; }

    public int DszkbTypDokumentu { get; set; }

    public int DszkbNumerNr { get; set; }

    public string DszkbNumerString { get; set; } = null!;

    public string? DszkbNumerPelny { get; set; }

    public short DszkbBufor { get; set; }

    public DateTime DszkbDataDok { get; set; }

    public int? DszkbPodId { get; set; }

    public decimal DszkbRazemBrutto { get; set; }

    public int? DszkbStanSynchronizacji { get; set; }

    public int DszkbOpeId { get; set; }

    public string? DszkbOpis { get; set; }

    public int DszkbZmianaId { get; set; }
}
