using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class NotyOdsNag
{
    public int NonNonid { get; set; }

    public short NonBufor { get; set; }

    public int? NonDdfId { get; set; }

    public int NonNumerNr { get; set; }

    public string NonNumerString { get; set; } = null!;

    public string? NonNumerPelny { get; set; }

    public DateTime NonDataDok { get; set; }

    public short? NonPodmiotTyp { get; set; }

    public int? NonPodmiotId { get; set; }

    public int? NonKatId { get; set; }

    public string NonKategoria { get; set; } = null!;

    public int? NonFplId { get; set; }

    public DateTime NonTermin { get; set; }

    public byte NonOdsetkiTyp { get; set; }

    public decimal NonOdsetkiStopa { get; set; }

    public string NonWaluta { get; set; } = null!;

    public int NonKursNumer { get; set; }

    public decimal NonKursL { get; set; }

    public decimal NonKursM { get; set; }

    public decimal NonRazemKwota { get; set; }

    public decimal NonRazemKwotaSys { get; set; }

    public decimal NonRazemOdsetki { get; set; }

    public decimal NonRazemOdsetkiSys { get; set; }

    public string NonUwagi { get; set; } = null!;

    public int? NonDekId { get; set; }

    public int? NonPreDekId { get; set; }

    public int? NonOpeZalId { get; set; }

    public int? NonStaZalId { get; set; }

    public DateTime NonTsZal { get; set; }

    public int? NonOpeModId { get; set; }

    public int? NonStaModId { get; set; }

    public DateTime NonTsMod { get; set; }

    public string NonOpeModKod { get; set; } = null!;

    public string NonOpeModNazwisko { get; set; } = null!;

    public string NonOpeZalKod { get; set; } = null!;

    public string NonOpeZalNazwisko { get; set; } = null!;

    public virtual DokDefinicje? NonDdf { get; set; }

    public virtual FormyPlatnosci? NonFpl { get; set; }

    public virtual Kategorie? NonKat { get; set; }

    public virtual ICollection<NotyOdsElem> NotyOdsElems { get; set; } = new List<NotyOdsElem>();

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
