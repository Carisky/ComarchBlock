using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SenditZleceniePrzesylki
{
    public int SzlSzlid { get; set; }

    public int SzlDdfId { get; set; }

    public int SzlFaId { get; set; }

    public int SzlNumerNr { get; set; }

    public string SzlNumerString { get; set; } = null!;

    public string? SzlNumerPelny { get; set; }

    public short SzlBufor { get; set; }

    public DateTime SzlDataDok { get; set; }

    public short? SzlOpiekunTyp { get; set; }

    public int? SzlOpiekunId { get; set; }

    public string SzlOpiekunNazwa { get; set; } = null!;

    public int? SzlSanid { get; set; }

    public string SzlSannazwa { get; set; } = null!;

    public string SzlSanulica { get; set; } = null!;

    public string SzlSannrDomu { get; set; } = null!;

    public string SzlSannrLokalu { get; set; } = null!;

    public string SzlSanmiasto { get; set; } = null!;

    public string SzlSankodPocztowy { get; set; } = null!;

    public string? SzlSantelefon { get; set; }

    public string? SzlSanemail { get; set; }

    public short? SzlOdbiorcaTyp { get; set; }

    public int? SzlOdbId { get; set; }

    public string SzlOdbNazwa { get; set; } = null!;

    public string SzlOdbUlica { get; set; } = null!;

    public string SzlOdbNrDomu { get; set; } = null!;

    public string SzlOdbNrLokalu { get; set; } = null!;

    public string SzlOdbMiasto { get; set; } = null!;

    public string SzlOdbKrajIso { get; set; } = null!;

    public string SzlOdbKodPocztowy { get; set; } = null!;

    public string? SzlOdbTelefon { get; set; }

    public string? SzlOdbEmail { get; set; }

    public string SzlOdebral { get; set; } = null!;

    public int SzlFirmaKurierskaId { get; set; }

    public byte SzlOpcjePobranie { get; set; }

    public decimal SzlOpcjeKwotaPobrania { get; set; }

    public byte SzlOpcjeZwrotPotwierdzenia { get; set; }

    public byte SzlOpcjeUbezpieczenie { get; set; }

    public decimal SzlOpcjeKwotaUbezpieczenia { get; set; }

    public DateTime SzlDataWyslania { get; set; }

    public DateTime SzlDataKurierOd { get; set; }

    public DateTime SzlDataKurierDo { get; set; }

    public string SzlNumerZleceniaSendit { get; set; } = null!;

    public string SzlNumerProtokoluOdbioru { get; set; } = null!;

    public string SzlNumerZleceniaOdbioru { get; set; } = null!;

    public string SzlStatusKey { get; set; } = null!;

    public string SzlStatus { get; set; } = null!;

    public DateTime SzlDataStatusu { get; set; }

    public string SzlUwagi { get; set; } = null!;

    public decimal SzlKoszt { get; set; }

    public int? SzlOpeZalId { get; set; }

    public int? SzlStaZalId { get; set; }

    public DateTime SzlTsZal { get; set; }

    public int? SzlOpeModId { get; set; }

    public int? SzlStaModId { get; set; }

    public DateTime SzlTsMod { get; set; }

    public string SzlOpeModKod { get; set; } = null!;

    public string SzlOpeModNazwisko { get; set; } = null!;

    public string SzlOpeZalKod { get; set; } = null!;

    public string SzlOpeZalNazwisko { get; set; } = null!;

    public int SzlTypKuriera { get; set; }

    public string SzlBladWalidacji { get; set; } = null!;

    public string SzlNrListuPrzewozowego { get; set; } = null!;

    public int SzlPlatnik { get; set; }

    public string SzlNumerPlatnika { get; set; } = null!;

    public int SzlPrzesylkaDoOddzialu { get; set; }

    public int SzlOdbAdresKorespondencyjny { get; set; }

    public int SzlZawartosc { get; set; }

    public string SzlZawartoscTekst { get; set; } = null!;

    public int SzlReferencje { get; set; }

    public string SzlReferencjeTekst { get; set; } = null!;

    public int SzlDokumentyZwrotne { get; set; }

    public string SzlDokumentyZwrotneTekst { get; set; } = null!;

    public int SzlPrzesylkaZwrotna { get; set; }

    public int? SzlOdbSanid { get; set; }

    public int SzlTypPaczkiDpd { get; set; }

    public byte SzlSerwis { get; set; }

    public byte SzlPreawizacja { get; set; }

    public byte SzlOdbiorWpunkcie { get; set; }

    public string SzlOdbiorWpunkcieId { get; set; } = null!;

    public string SzlOdbiorWpunkcieNazwa { get; set; } = null!;

    public string SzlOdbiorWpunkcieAdres { get; set; } = null!;

    public byte SzlSposobPobrania { get; set; }

    public string SzlTytulPrzelewu { get; set; } = null!;

    public byte SzlDokumentyZwrotneTyp { get; set; }

    public byte SzlPotwierdzenieOdbioru { get; set; }

    public byte SzlPotwierdzenieOdbioruTyp { get; set; }

    public byte SzlPotwierdzenieOdbioruIlosc { get; set; }

    public byte SzlEpo { get; set; }

    public byte SzlPotwierdzenieDoreczenia { get; set; }

    public byte SzlPotwierdzenieDoreczeniaTyp { get; set; }

    public string SzlUrzadNadaniaKod { get; set; } = null!;

    public string SzlUrzadNadaniaAdres { get; set; } = null!;

    public string SzlPlikZlecenia { get; set; } = null!;

    public string SzlNrTransakcjiOdbioru { get; set; } = null!;

    public byte SzlOpcjeDeklarowanaWartosc { get; set; }

    public decimal SzlOpcjeDeklarowanaWartoscKwota { get; set; }

    public string SzlAllegroTransactionId { get; set; } = null!;

    public string SzlAllegroUserId { get; set; } = null!;

    public byte SzlDostawaWweekend { get; set; }

    public string SzlDokZrodlowe { get; set; } = null!;

    public int SzlDokZrodloweTyp { get; set; }

    public int SzlSposobNadania { get; set; }

    public string SzlKurierNazwa { get; set; } = null!;

    public string SzlKurierKod { get; set; } = null!;

    public string SzlKurierSzablon { get; set; } = null!;

    public int SzlKurierSzablonId { get; set; }

    public string SzlShippingStatus { get; set; } = null!;

    public string SzlShippingStan { get; set; } = null!;

    public int SzlShippingPickupOrder { get; set; }

    public string SzlSerwisNazwa { get; set; } = null!;

    public virtual ICollection<SenditPaczki> SenditPaczkis { get; set; } = new List<SenditPaczki>();

    public virtual DokDefinicje SzlDdf { get; set; } = null!;
}
