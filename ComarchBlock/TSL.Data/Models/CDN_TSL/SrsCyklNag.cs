using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class SrsCyklNag
{
    public int SrWSrWid { get; set; }

    public string SrWKod { get; set; } = null!;

    public string SrWNazwa { get; set; } = null!;

    public DateTime? SrWDataDok { get; set; }

    public DateTime? SrWDataOstatniej { get; set; }

    public byte SrWNieaktywny { get; set; }

    public byte? SrWPowtarzajCo { get; set; }

    public DateTime? SrWPowtarzajCoData { get; set; }

    public DateTime? SrWDataKolejnego { get; set; }

    public byte SrWPrzypomnienie { get; set; }

    public DateTime? SrWCzasPrzypomnienia { get; set; }

    public int SrWDdfId { get; set; }

    public int? SrWKatId { get; set; }

    public string SrWNumerString { get; set; } = null!;

    public int SrWNumerNr { get; set; }

    public short? SrWPodmiotTyp { get; set; }

    public int? SrWPodmiotId { get; set; }

    public string SrWPodNazwa1 { get; set; } = null!;

    public string SrWPodNazwa2 { get; set; } = null!;

    public string SrWPodNazwa3 { get; set; } = null!;

    public string SrWPodKraj { get; set; } = null!;

    public string SrWPodWojewodztwo { get; set; } = null!;

    public string SrWPodPowiat { get; set; } = null!;

    public string SrWPodGmina { get; set; } = null!;

    public string SrWPodUlica { get; set; } = null!;

    public string SrWPodNrDomu { get; set; } = null!;

    public string SrWPodNrLokalu { get; set; } = null!;

    public string SrWPodMiasto { get; set; } = null!;

    public string SrWPodKodPocztowy { get; set; } = null!;

    public string SrWPodPoczta { get; set; } = null!;

    public string SrWPodAdres2 { get; set; } = null!;

    public string SrWTelefon { get; set; } = null!;

    public string SrWEmail { get; set; } = null!;

    public short? SrWOdbiorcaTyp { get; set; }

    public int? SrWOdbId { get; set; }

    public string SrWOdbNazwa1 { get; set; } = null!;

    public string SrWOdbNazwa2 { get; set; } = null!;

    public string SrWOdbNazwa3 { get; set; } = null!;

    public string SrWOdbKraj { get; set; } = null!;

    public string SrWOdbWojewodztwo { get; set; } = null!;

    public string SrWOdbPowiat { get; set; } = null!;

    public string SrWOdbGmina { get; set; } = null!;

    public string SrWOdbUlica { get; set; } = null!;

    public string SrWOdbNrDomu { get; set; } = null!;

    public string SrWOdbNrLokalu { get; set; } = null!;

    public string SrWOdbMiasto { get; set; } = null!;

    public string SrWOdbKodPocztowy { get; set; } = null!;

    public string SrWOdbPoczta { get; set; } = null!;

    public string SrWOdbAdres2 { get; set; } = null!;

    public string SrWOdbTelefon { get; set; } = null!;

    public string SrWOdbEmail { get; set; } = null!;

    public int? SrWZlecajacyId { get; set; }

    public string SrWZlecajacyNazwisko { get; set; } = null!;

    public string? SrWZlecajacyTelefon { get; set; }

    public int? SrWPrzedstawicielId { get; set; }

    public string? SrWPrzedstawicielNazwisko { get; set; }

    public string? SrWPrzedstawicielTelefon { get; set; }

    public short? SrWProwadzacyTyp { get; set; }

    public int? SrWProwadzacyId { get; set; }

    public int? SrWSrUid { get; set; }

    public string SrWOpis { get; set; } = null!;

    public byte SrWTypNb { get; set; }

    public byte SrWZbiorczeFaCzesci { get; set; }

    public int? SrWZbiorczeTwrIdCzesci { get; set; }

    public byte SrWZbiorczeFaCzynnosci { get; set; }

    public int? SrWZbiorczeTwrIdCzynnosci { get; set; }

    public string SrWWaluta { get; set; } = null!;

    public int? SrWMagId { get; set; }

    public byte SrWAutomat { get; set; }

    public byte? SrWAutomatEmail { get; set; }

    public int? SrWAutomatEmailSzablonId { get; set; }

    public string? SrWAutomatEmailAdres { get; set; }

    public byte? SrWAutomatSms { get; set; }

    public int? SrWAutomatSmsSzablonId { get; set; }

    public string? SrWAutomatSmsNumerTelefonu { get; set; }

    public int? SrWOpeZalId { get; set; }

    public int? SrWStaZalId { get; set; }

    public DateTime SrWTsZal { get; set; }

    public int? SrWOpeModId { get; set; }

    public int? SrWStaModId { get; set; }

    public DateTime SrWTsMod { get; set; }

    public string SrWOpeModKod { get; set; } = null!;

    public string SrWOpeModNazwisko { get; set; } = null!;

    public string SrWOpeZalKod { get; set; } = null!;

    public string SrWOpeZalNazwisko { get; set; } = null!;

    public virtual PodmiotyView? PodmiotyView { get; set; }

    public virtual PodmiotyView? PodmiotyViewNavigation { get; set; }

    public virtual Kategorie? SrWKat { get; set; }

    public virtual KntOsoby? SrWZlecajacy { get; set; }

    public virtual ICollection<SrsCyklElem> SrsCyklElems { get; set; } = new List<SrsCyklElem>();
}
