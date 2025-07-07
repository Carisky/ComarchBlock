using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DetalTraNag
{
    public int DtrNDtrNid { get; set; }

    public byte DtrNTypNb { get; set; }

    public int DtrNDstrNid { get; set; }

    public int DtrNStanDetalId { get; set; }

    public int DtrNFaId { get; set; }

    public int? DtrNMagId { get; set; }

    public int? DtrNZwrId { get; set; }

    public int DtrNTypDokumentu { get; set; }

    public int DtrNNumerNr { get; set; }

    public string DtrNNumerString { get; set; } = null!;

    public string DtrNNumerPelny { get; set; } = null!;

    public DateTime DtrNDataDok { get; set; }

    public byte DtrNFiskalna { get; set; }

    public int? DtrNPodId { get; set; }

    public int? DtrNOdbId { get; set; }

    public decimal DtrNRazemBrutto { get; set; }

    public decimal DtrNRabat { get; set; }

    public int? DtrNStanSynchronizacji { get; set; }

    public string DtrNWaluta { get; set; } = null!;

    public string? DtrNOsobaOdbierajaca { get; set; }

    public int DtrNOpeId { get; set; }

    public DateTime DtrNTsZal { get; set; }

    public int DtrNIloscElementow { get; set; }

    public int DtrNIloscPlatnosci { get; set; }

    public int? DtrNOptimaId { get; set; }

    public int? DtrNFplId { get; set; }

    public byte? DtrNKorekta { get; set; }

    public int DtrNParodzajKor { get; set; }

    public byte? DtrNStanKorekta { get; set; }

    public string? DtrNOpis { get; set; }

    public DateTime? DtrNTsExport { get; set; }

    public DateTime? DtrNDataRealizacji { get; set; }

    public DateTime? DtrNDataPlatnosci { get; set; }

    public int DtrNAdresId { get; set; }

    public string DtrNMagKod { get; set; } = null!;

    public int DtrNDdfId { get; set; }

    public byte DtrNStawkaNpoo { get; set; }

    public byte DtrNAnulowanie { get; set; }

    public int DtrNPlatnikId { get; set; }

    public byte DtrNSplitPay { get; set; }

    public virtual ICollection<DetalPlatnosciDokumentu> DetalPlatnosciDokumentus { get; set; } = new List<DetalPlatnosciDokumentu>();

    public virtual ICollection<DetalTraElem> DetalTraElems { get; set; } = new List<DetalTraElem>();
}
