using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DetalPlatnosciDokumentu
{
    public int DplDDplDid { get; set; }

    public int DplDDsplDid { get; set; }

    public int DplDDstrNid { get; set; }

    public int DplDDszkbid { get; set; }

    public int DplDStanDetalId { get; set; }

    public int DplDDsfplId { get; set; }

    public decimal DplDKwota { get; set; }

    public decimal DplDKwotaZaplacona { get; set; }

    public DateTime DplDDataPlatnosci { get; set; }

    public byte? DplDGotowka { get; set; }

    public DateTime DplDTermin { get; set; }

    public int? DplDStanSynchronizacji { get; set; }

    public DateTime? DplDTsExport { get; set; }

    public virtual DetalTraNag DetalTraNag { get; set; } = null!;
}
