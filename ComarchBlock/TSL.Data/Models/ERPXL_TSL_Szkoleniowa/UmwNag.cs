using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class UmwNag
{
    public int UmNId { get; set; }

    public int? UmNUmTid { get; set; }

    public byte? UmNPozycjaTwr { get; set; }

    public int? UmNDataRozpoczecia { get; set; }

    public int? UmNDataZakonczenia { get; set; }

    public int? UmNDataZawarcia { get; set; }

    public int? UmNUmowaId { get; set; }

    public int? UmNAneksId { get; set; }

    public short? UmNPodTyp { get; set; }

    public int? UmNPodNumer { get; set; }

    public int? UmNKnAnumer { get; set; }

    public short? UmNKnAtyp { get; set; }

    public short? UmNKnDtyp { get; set; }

    public int? UmNKnDnumer { get; set; }

    public int? UmNAdWnumer { get; set; }

    public short? UmNAdWtyp { get; set; }

    public short? UmNKnPtyp { get; set; }

    public int? UmNKnPnumer { get; set; }

    public int? UmNAdPnumer { get; set; }

    public int? UmNOpeWnumer { get; set; }

    public int? UmNOpePnumer { get; set; }

    public int? UmNOpeMnumer { get; set; }

    public int? UmNOpiekunNumer { get; set; }

    public int? UmNDataCzasW { get; set; }

    public int? UmNDataCzasP { get; set; }

    public int? UmNDataCzasM { get; set; }

    public int? UmNRodzajUmowyId { get; set; }

    public byte? UmNSprZak { get; set; }

    public byte? UmNFormaNr { get; set; }

    public string? UmNFormaNazwa { get; set; }

    public decimal? UmNFormaRabat { get; set; }

    public int? UmNTerminPlatnosci { get; set; }

    public short? UmNRok { get; set; }

    public byte? UmNMiesiac { get; set; }

    public string? UmNSeria { get; set; }

    public int? UmNNumer { get; set; }

    public string? UmNDokumentObcy { get; set; }

    public byte? UmNExpoNorm { get; set; }

    public string? UmNWaluta { get; set; }

    public short? UmNNrKursu { get; set; }

    public decimal? UmNKursM { get; set; }

    public decimal? UmNKursL { get; set; }

    public byte? UmNTypKursu { get; set; }

    public decimal? UmNRabat { get; set; }

    public decimal? UmNRabatW { get; set; }

    public decimal? UmNRabatPromocyjnyGlobalny { get; set; }

    public int? UmNPromocje { get; set; }

    public string? UmNSpDostawy { get; set; }

    public string? UmNCechaOpis { get; set; }

    public byte? UmNStan { get; set; }

    public int? UmNOpisStanuId { get; set; }

    public int? UmNPowodAneksuId { get; set; }

    public int? UmNAktywny { get; set; }

    public byte? UmNWsk { get; set; }

    public short? UmNKnStyp { get; set; }

    public int? UmNKnSfirma { get; set; }

    public int? UmNKnSnumer { get; set; }

    public short? UmNKnSlp { get; set; }

    public short? UmNKnStypOdb { get; set; }

    public int? UmNKnSfirmaOdb { get; set; }

    public int? UmNKnSnumerOdb { get; set; }

    public short? UmNKnSlpOdb { get; set; }

    public string? UmNUrl { get; set; }

    public int? UmNFrSid { get; set; }

    public string? UmNFlagaNb { get; set; }

    public string? UmNOpis { get; set; }

    public short? UmNCenaSpr { get; set; }

    public int? UmNPrjId { get; set; }

    public int? UmNFrmNumer { get; set; }

    public int? UmNCzasObow { get; set; }

    public byte? UmNCzasObowJedn { get; set; }

    public string? UmNNieUzywac { get; set; }

    public decimal? UmNNadwyzkaTwr { get; set; }

    public int? UmNDataPierwszejPl { get; set; }

    public byte? UmNOstatniDzienPl { get; set; }

    public byte? UmNOkresPl { get; set; }

    public decimal? UmNProcentRatyPl { get; set; }

    public decimal? UmNKwotaRatyPl { get; set; }

    public short? UmNIloscRatPl { get; set; }

    public byte? UmNBlokadaPl { get; set; }

    public byte? UmNRoznicaPl { get; set; }

    public byte? UmNInnaRataPl { get; set; }

    public decimal? UmNKwotaInnejRatyPl { get; set; }

    public string? UmNGenDokNazwaPozycji { get; set; }

    public short? UmNKnStypPlt { get; set; }

    public int? UmNKnSfirmaPlt { get; set; }

    public int? UmNKnSnumerPlt { get; set; }

    public short? UmNKnSlpPlt { get; set; }

    public string? UmNGenDokGrupaPod { get; set; }

    public decimal? UmNGenDokStawkaPod { get; set; }

    public int? UmNMagNumer { get; set; }

    public virtual ICollection<UmwPlat> UmwPlats { get; set; } = new List<UmwPlat>();

    public virtual ICollection<UmwPozycje> UmwPozycjes { get; set; } = new List<UmwPozycje>();

    public virtual ICollection<UmwVat> UmwVats { get; set; } = new List<UmwVat>();
}
