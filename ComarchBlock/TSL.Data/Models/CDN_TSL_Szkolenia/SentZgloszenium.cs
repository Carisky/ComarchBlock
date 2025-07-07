using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class SentZgloszenium
{
    public int SentSentId { get; set; }

    public int? SentDdfId { get; set; }

    public int SentNumerNr { get; set; }

    public string SentNumerString { get; set; } = null!;

    public string? SentNumerPelny { get; set; }

    public short SentRodzaj { get; set; }

    public int SentStatus { get; set; }

    public DateTime SentDataDok { get; set; }

    public int? SentSanid { get; set; }

    public string SentSanulica { get; set; } = null!;

    public string SentSannrDomu { get; set; } = null!;

    public string SentSannrLokalu { get; set; } = null!;

    public string SentSanmiasto { get; set; } = null!;

    public string SentSankodPocztowy { get; set; } = null!;

    public string? SentSantelefon { get; set; }

    public string? SentSanemail { get; set; }

    public string SentSanwojewodztwo { get; set; } = null!;

    public string SentSandlugoscGeograficzna { get; set; } = null!;

    public string SentSanszerokoscGeograficzna { get; set; } = null!;

    public short? SentPodmiotTyp { get; set; }

    public int? SentPodId { get; set; }

    public string SentPodNazwa { get; set; } = null!;

    public string SentPodUlica { get; set; } = null!;

    public string SentPodNrDomu { get; set; } = null!;

    public string SentPodNrLokalu { get; set; } = null!;

    public string SentPodMiasto { get; set; } = null!;

    public string SentPodKodPocztowy { get; set; } = null!;

    public string SentPodNipKraj { get; set; } = null!;

    public string SentPodNipE { get; set; } = null!;

    public string SentPodKraj { get; set; } = null!;

    public string SentIdSisc { get; set; } = null!;

    public DateTime SentDataPrzewozu { get; set; }

    public int SentTwrId { get; set; }

    public int SentDokumentZrodlowyTyp { get; set; }

    public string SentKodCn { get; set; } = null!;

    public decimal SentIlosc { get; set; }

    public string SentJm { get; set; } = null!;

    public decimal SentMasa { get; set; }

    public string? SentOpis { get; set; }

    public string? SentUwagi { get; set; }

    public string SentNumerSentPuesc { get; set; } = null!;

    public string SentStatusPuesc { get; set; } = null!;

    public string SentDokumentPuescChecksum { get; set; } = null!;

    public int SentDokumentPuescTyp { get; set; }

    public DateTime? SentDokumentPuescModificationDate { get; set; }

    public DateTime? SentDataWyslaniaPuesc { get; set; }

    public string SentSenderKey { get; set; } = null!;

    public string SentRecipientKey { get; set; } = null!;

    public string SentCarrierKey { get; set; } = null!;

    public string? SentImiePuesc { get; set; }

    public string? SentNazwiskoPuesc { get; set; }

    public int SentTypeOfTransport { get; set; }

    public int SentPlaceOfControl { get; set; }

    public string SentRecommendationsForControl { get; set; } = null!;

    public int SentTypZgloszenia { get; set; }

    public string SentNrUmowyOlej { get; set; } = null!;

    public int SentOswiadczenieUmowaOlej { get; set; }

    public int SentOswiadczeniePosrednikOlej { get; set; }

    public int SentRodzajIdentyfikatoraPodatkowego { get; set; }

    public string SentIdMiejscaDostawy { get; set; } = null!;

    public string SentIdUrzadzenGrzewczych { get; set; } = null!;

    public int? SentOpeZalId { get; set; }

    public string SentOpeZalKod { get; set; } = null!;

    public string SentOpeZalNazwisko { get; set; } = null!;

    public int? SentStaZalId { get; set; }

    public DateTime SentTsZal { get; set; }

    public int? SentOpeModId { get; set; }

    public string SentOpeModKod { get; set; } = null!;

    public string SentOpeModNazwisko { get; set; } = null!;

    public int? SentStaModId { get; set; }

    public DateTime SentTsMod { get; set; }

    public virtual PodmiotyView? PodmiotyView { get; set; }

    public virtual DokDefinicje? SentDdf { get; set; }

    public virtual ICollection<SentElement> SentElements { get; set; } = new List<SentElement>();

    public virtual ICollection<SentHistorium> SentHistoria { get; set; } = new List<SentHistorium>();
}
