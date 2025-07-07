using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TypWyplatum
{
    public int TwpTwpId { get; set; }

    public int TwpPdpId { get; set; }

    public int TwpPdzId { get; set; }

    public int? TwpParentId { get; set; }

    public string TwpNazwa { get; set; } = null!;

    public string TwpNazwa2 { get; set; } = null!;

    public string TwpNazwaPelna { get; set; } = null!;

    public string TwpSkrot { get; set; } = null!;

    public string TwpSkrot2 { get; set; } = null!;

    public int TwpRodzajZrodla { get; set; }

    public int TwpZalPodat { get; set; }

    public byte TwpImPrzelZalPodat { get; set; }

    public int TwpKoszty { get; set; }

    public int TwpKodRna { get; set; }

    public int TwpSklZus { get; set; }

    public int TwpSklZdrow { get; set; }

    public byte TwpNiePomniejszZdrow { get; set; }

    public byte TwpKorygowana { get; set; }

    public byte TwpWchodziDoWyplaty { get; set; }

    public byte TwpUwzglMin { get; set; }

    public byte TwpUwzglNadgodz { get; set; }

    public int TwpOkresWyplaty { get; set; }

    public byte TwpWplywaZalPodat { get; set; }

    public int TwpWliczUrlop { get; set; }

    public int TwpWliczChor { get; set; }

    public int TwpWliczEkwiwal { get; set; }

    public string TwpStOkrWartosc { get; set; } = null!;

    public int TwpStOkrTyp { get; set; }

    public byte TwpZaOkrZwolLek { get; set; }

    public int TwpAlgAlgorytm { get; set; }

    public byte TwpAlgPotracenie { get; set; }

    public decimal TwpAlgZaokraglenie { get; set; }

    public byte TwpAlgPotrNieobec { get; set; }

    public byte TwpAlgOdchylki { get; set; }

    public decimal TwpAlgProcWynagr { get; set; }

    public byte TwpAlgStaz { get; set; }

    public int TwpAlgStOkrTyp { get; set; }

    public string TwpAlgStOkrWartosc { get; set; } = null!;

    public decimal TwpAlgWspolcz { get; set; }

    public int TwpAlgLiczbaDni { get; set; }

    public int TwpAlgLiczbaGodz { get; set; }

    public byte TwpAlgBrutto { get; set; }

    public byte TwpAlgUrlop { get; set; }

    public byte TwpAlgAutomat { get; set; }

    public decimal TwpAlgProcent { get; set; }

    public decimal TwpAlgKwota { get; set; }

    public byte? TwpAlgUzyjKwota { get; set; }

    public byte TwpAlgStdWspolcz { get; set; }

    public decimal TwpAlgIlosc { get; set; }

    public int TwpAlgIloscMies { get; set; }

    public byte TwpAlgStdIloscMies { get; set; }

    public decimal TwpKosztyProc { get; set; }

    public string TwpZmienna1 { get; set; } = null!;

    public string TwpZmienna2 { get; set; } = null!;

    public byte TwpAktPoWyp1 { get; set; }

    public byte TwpAktPoWyp2 { get; set; }

    public short TwpPriorytetZus { get; set; }

    public short TwpPriorytetFis { get; set; }

    public short TwpPriorytetKoszty { get; set; }

    public short TwpRodzajFis { get; set; }

    public int TwpKategoria { get; set; }

    public byte TwpPodstawowe { get; set; }

    public short TwpStandardowy { get; set; }

    public byte TwpZasadnicze { get; set; }

    public byte TwpRodzajPotracenia { get; set; }

    public byte TwpWycofany { get; set; }

    public byte TwpAlgSposobZaokr { get; set; }

    public int TwpPriorytet { get; set; }

    public int TwpAlgStOkrPlusTyp { get; set; }

    public string TwpAlgStOkrPlusWartosc { get; set; } = null!;

    public byte TwpAlgStazSposob { get; set; }

    public short TwpUlga { get; set; }

    public int? TwpWzrId { get; set; }

    public string TwpAlgWzorzec { get; set; } = null!;

    public short TwpAlgRodzaj12 { get; set; }

    public short TwpAlgSposobPomn { get; set; }

    public byte TwpNieaktywny { get; set; }

    public byte TwpAlgPodstDzielGodz { get; set; }

    public DateTime TwpAlgGodziny { get; set; }

    public byte TwpWliczPfron { get; set; }

    public byte TwpKosztFirma { get; set; }

    public byte TwpOpisAnalitCzasPracy { get; set; }

    public int? TwpKopia { get; set; }

    public int TwpPozycjaRp7 { get; set; }

    public byte TwpWskaznik { get; set; }

    public byte TwpUmowa { get; set; }

    public short TwpWliczanyDoGus { get; set; }

    public decimal TwpZalPodProc { get; set; }

    public byte TwpPkzp { get; set; }

    public byte TwpSwiadczFs { get; set; }

    public byte TwpTypWaluty { get; set; }

    public byte TwpNieZapisujZerowego { get; set; }

    public byte TwpAlgIloscMiesWszystkie { get; set; }

    public byte TwpAlgGodzinyDni { get; set; }

    public byte TwpZajecieWynagr { get; set; }

    public byte TwpDoliczNaKoncu { get; set; }

    public byte TwpAlgKnfWspolcz { get; set; }

    public byte TwpWliczChorPodwojnie { get; set; }

    public byte TwpNieZapisujZerowegoPkzp { get; set; }

    public byte TwpWykazZusrpa { get; set; }

    public byte TwpSkladkaCzlonkowskaZz { get; set; }

    public byte TwpPrzychodPpkumowa { get; set; }

    public int? TwpPpkumowaId { get; set; }

    public byte TwpWliczLimitZwolZfss { get; set; }

    public byte TwpUwzglZasadPowNormy { get; set; }

    public byte TwpUwzglZasadPonNormy { get; set; }

    public byte TwpKierowcaZwrotKosztow { get; set; }

    public string? TwpImportAppId { get; set; }

    public string? TwpImportRowId { get; set; }

    public string? TwpImportRowId2 { get; set; }

    public DateTime? TwpTsExport { get; set; }

    public int? TwpOpeZalId { get; set; }

    public int? TwpStaZalId { get; set; }

    public DateTime TwpTsZal { get; set; }

    public int? TwpOpeModId { get; set; }

    public int? TwpStaModId { get; set; }

    public DateTime TwpTsMod { get; set; }

    public string TwpOpeModKod { get; set; } = null!;

    public string TwpOpeModNazwisko { get; set; } = null!;

    public string TwpOpeZalKod { get; set; } = null!;

    public string TwpOpeZalNazwisko { get; set; } = null!;

    public byte TwpWliczChorPoprzedniOkres { get; set; }

    public virtual ICollection<AkordDefinicja> AkordDefinicjas { get; set; } = new List<AkordDefinicja>();

    public virtual ICollection<DodatkiHist> DodatkiHists { get; set; } = new List<DodatkiHist>();

    public virtual ICollection<TypWyplatum> InverseTwpParent { get; set; } = new List<TypWyplatum>();

    public virtual ICollection<TypWyplatum> InverseTwpPpkumowa { get; set; } = new List<TypWyplatum>();

    public virtual ICollection<PodtypWyplatum> PodtypWyplata { get; set; } = new List<PodtypWyplatum>();

    public virtual TypWyplatum? TwpParent { get; set; }

    public virtual PozDeklPit TwpPdp { get; set; } = null!;

    public virtual PozDeklZu TwpPdz { get; set; } = null!;

    public virtual TypWyplatum? TwpPpkumowa { get; set; }

    public virtual ICollection<TypNieobec> TypNieobecs { get; set; } = new List<TypNieobec>();

    public virtual ICollection<TypWyplataGrupaSkladniki> TypWyplataGrupaSkladnikis { get; set; } = new List<TypWyplataGrupaSkladniki>();

    public virtual ICollection<TypWyplataStaz> TypWyplataStazs { get; set; } = new List<TypWyplataStaz>();

    public virtual ICollection<WypElementy> WypElementies { get; set; } = new List<WypElementy>();

    public virtual ICollection<WypSkladniki> WypSkladnikis { get; set; } = new List<WypSkladniki>();

    public virtual ICollection<WzorWartosci> WzorWartoscis { get; set; } = new List<WzorWartosci>();
}
