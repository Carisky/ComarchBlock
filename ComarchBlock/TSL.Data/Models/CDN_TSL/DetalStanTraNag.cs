using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DetalStanTraNag
{
    public int DstrNDstrNid { get; set; }

    public int DstrNStanDetalId { get; set; }

    public int DstrNFaId { get; set; }

    public int? DstrNZwrId { get; set; }

    public int DstrNTypDokumentu { get; set; }

    public int DstrNNumerNr { get; set; }

    public string DstrNNumerString { get; set; } = null!;

    public string? DstrNNumerPelny { get; set; }

    public short DstrNBufor { get; set; }

    public string DstrNOpis { get; set; } = null!;

    public int DstrNAnulowany { get; set; }

    public DateTime DstrNDataDok { get; set; }

    public byte DstrNFiskalna { get; set; }

    public int? DstrNFiskalnaErr { get; set; }

    public int? DstrNPodId { get; set; }

    public int? DstrNOdbId { get; set; }

    public decimal DstrNRazemBrutto { get; set; }

    public decimal DstrNRabat { get; set; }

    public string DstrNWaluta { get; set; } = null!;

    public string? DstrNOsobaOdbierajaca { get; set; }

    public int? DstrNStanSynchronizacji { get; set; }

    public int DstrNOpeId { get; set; }

    public int DstrNZmianaId { get; set; }

    public byte? DstrNKorekta { get; set; }

    public int DstrNParodzajKor { get; set; }

    public DateTime DstrNTsZal { get; set; }

    public virtual ICollection<DetalStanPlatnosciDokumentu> DetalStanPlatnosciDokumentus { get; set; } = new List<DetalStanPlatnosciDokumentu>();

    public virtual ICollection<DetalStanTraElem> DetalStanTraElems { get; set; } = new List<DetalStanTraElem>();

    public virtual DetalStanOperatorzy DstrNOpe { get; set; } = null!;

    public virtual DetalStanKontrahenci? DstrNPod { get; set; }
}
