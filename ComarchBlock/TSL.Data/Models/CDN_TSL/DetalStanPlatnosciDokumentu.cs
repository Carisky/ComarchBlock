using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DetalStanPlatnosciDokumentu
{
    public int DsplDDsplDid { get; set; }

    public int DsplDDstrNid { get; set; }

    public int DsplDDsfplId { get; set; }

    public decimal DsplDKwota { get; set; }

    public decimal DsplDKwotaZaplacona { get; set; }

    public DateTime DsplDDataPlatnosci { get; set; }

    public DateTime DsplDTermin { get; set; }

    public virtual DetalStanTraNag DsplDDstrN { get; set; } = null!;
}
