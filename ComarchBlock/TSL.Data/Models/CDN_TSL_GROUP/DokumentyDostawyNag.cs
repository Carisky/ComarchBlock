using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DokumentyDostawyNag
{
    public int DdnDdnid { get; set; }

    public int? DdnDdfId { get; set; }

    public int DdnNumerNr { get; set; }

    public string DdnNumerString { get; set; } = null!;

    public string? DdnNumerPelny { get; set; }

    public int DdnStatus { get; set; }

    public DateTime DdnDataDok { get; set; }

    public DateTime DdnDataFaktury { get; set; }

    public string DdnNrFaktury { get; set; } = null!;

    public int? DdnSanid { get; set; }

    public string DdnSanulica { get; set; } = null!;

    public string DdnSannrDomu { get; set; } = null!;

    public string DdnSannrLokalu { get; set; } = null!;

    public string DdnSanmiasto { get; set; } = null!;

    public string DdnSankodPocztowy { get; set; } = null!;

    public string? DdnSantelefon { get; set; }

    public string? DdnSanemail { get; set; }

    public string DdnSanwojewodztwo { get; set; } = null!;

    public short? DdnPodmiotTyp { get; set; }

    public int? DdnPodId { get; set; }

    public string DdnPodNazwa { get; set; } = null!;

    public string DdnPodUlica { get; set; } = null!;

    public string DdnPodNrDomu { get; set; } = null!;

    public string DdnPodNrLokalu { get; set; } = null!;

    public string DdnPodMiasto { get; set; } = null!;

    public string DdnPodKodPocztowy { get; set; } = null!;

    public string DdnPodNipKraj { get; set; } = null!;

    public string DdnPodNipE { get; set; } = null!;

    public string DdnPodKraj { get; set; } = null!;

    public string DdnIdSisc { get; set; } = null!;

    public DateTime DdnDataWywozu { get; set; }

    public int DdnDokumentZrodlowyTyp { get; set; }

    public string DdnNumerPuesc { get; set; } = null!;

    public string DdnStatusPuesc { get; set; } = null!;

    public string DdnDokumentPuescChecksum { get; set; } = null!;

    public string DdnDokumentPuescTyp { get; set; } = null!;

    public DateTime? DdnDokumentPuescModificationDate { get; set; }

    public DateTime? DdnDataWyslaniaPuesc { get; set; }

    public string DdnSenderKey { get; set; } = null!;

    public string DdnRecipientKey { get; set; } = null!;

    public string DdnCarrierKey { get; set; } = null!;

    public string? DdnImiePuesc { get; set; }

    public string? DdnNazwiskoPuesc { get; set; }

    public int DdnTypeOfTransport { get; set; }

    public string DdnTransportInneOpis { get; set; } = null!;

    public int DdnTypZgloszenia { get; set; }

    public int DdnRodzajIdentyfikatoraPodatkowego { get; set; }

    public string DdnPodKodUrzedu { get; set; } = null!;

    public string DdnSankodUrzedu { get; set; } = null!;

    public short DdnCzasPrzewozuTyp { get; set; }

    public int DdnCzasPrzewozu { get; set; }

    public short DdnTrybOdroczony { get; set; }

    public int? DdnOpeZalId { get; set; }

    public string DdnOpeZalKod { get; set; } = null!;

    public string DdnOpeZalNazwisko { get; set; } = null!;

    public int? DdnStaZalId { get; set; }

    public DateTime DdnTsZal { get; set; }

    public int? DdnOpeModId { get; set; }

    public string DdnOpeModKod { get; set; } = null!;

    public string DdnOpeModNazwisko { get; set; } = null!;

    public int? DdnStaModId { get; set; }

    public DateTime DdnTsMod { get; set; }

    public virtual DokDefinicje? DdnDdf { get; set; }

    public virtual ICollection<DokumentyDostawyElem> DokumentyDostawyElems { get; set; } = new List<DokumentyDostawyElem>();

    public virtual ICollection<DokumentyDostawyHistorium> DokumentyDostawyHistoria { get; set; } = new List<DokumentyDostawyHistorium>();

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
