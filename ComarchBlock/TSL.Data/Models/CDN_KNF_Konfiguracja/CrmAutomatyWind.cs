using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class CrmAutomatyWind
{
    public int CrAkCrakId { get; set; }

    public byte CrAkTypAutomatu { get; set; }

    public byte CrAkAktywny { get; set; }

    public int CrAkBazId { get; set; }

    public int CrAkOpeId { get; set; }

    public string CrAkOpeParams { get; set; } = null!;

    public decimal CrAkKwotaMin { get; set; }

    public byte CrAkTerminPlatnosciTyp { get; set; }

    public int CrAkDniPrzedTerminem { get; set; }

    public byte CrAkMail { get; set; }

    public DateTime CrAkMailGodzinaAkcji { get; set; }

    public int? CrAkMailKontoId { get; set; }

    public byte CrAkMailWysylka { get; set; }

    public byte CrAkCrm { get; set; }

    public DateTime CrAkCrmGodzinaAkcji { get; set; }

    public byte CrAkCrmOpiekunMode { get; set; }

    public short? CrAkCrmOpiekunTyp { get; set; }

    public int? CrAkCrmOpiekunId { get; set; }

    public int CrAkCrmZadanieTerminCo { get; set; }

    public DateTime CrAkCrmzadanieGodzinaOd { get; set; }

    public DateTime CrAkCrmzadanieGodzinaDo { get; set; }

    public byte CrAkCrmZadaniePrzypomnienie { get; set; }

    public int? CrAkCrmZadanieCzasPrzypomnienia { get; set; }

    public byte CrAkBlokadaSprzedazy { get; set; }

    public DateTime CrAkBlokadaSprGodzinaAkcji { get; set; }

    public decimal CrAkBlokadaSprKwotaMin { get; set; }

    public byte CrAkPonaglenieZaplaty { get; set; }

    public DateTime CrAkPonZapGodzinaAkcji { get; set; }

    public int CrAkPonZapOdsetkiTyp { get; set; }

    public decimal CrAkPonZapOdsetkiStopa { get; set; }

    public decimal CrAkPonZapOdsetkiPodatkoweProg { get; set; }

    public byte CrAkPonZapOdsetkiGenerujPlatnosc { get; set; }

    public int? CrAkPonZapOdsetkiFormaPlatnosciId { get; set; }

    public int CrAkPonZapOdsetkiTerminPlatDni { get; set; }

    public byte CrAkSms { get; set; }

    public DateTime CrAkSmsGodzinaAkcji { get; set; }

    public byte CrAkSmsWysylka { get; set; }

    public byte CrAkFaCyklGenDok { get; set; }

    public DateTime CrAkFaCyklGenDokGodzinaAkcji { get; set; }

    public DateTime? CrAkZleceniaCyklGenDokGodzinaAkcji { get; set; }

    public byte? CrAkCrkPobierajUstawieniaDomyslne { get; set; }

    public DateTime? CrAkCrkPrzypomnieniaGodzinaAkcji { get; set; }

    public int? CrAkCrkPrzypomnieniaMailCzasPrzypomnienia { get; set; }

    public int? CrAkCrkPrzypomnieniaSmsCzasPrzypomnienia { get; set; }

    public int? CrAkMailSzablonId { get; set; }

    public int? CrAkSmsSzablonId { get; set; }

    public byte? CrAkCrkOpePobierajUstawieniaDomyslne { get; set; }

    public int? CrAkCrkOpePrzypomnieniaMailCzasPrzypomnienia { get; set; }

    public int? CrAkCrkOpePrzypomnieniaSmsCzasPrzypomnienia { get; set; }

    public int? CrAkCrkOpeMailSzablonId { get; set; }

    public int? CrAkCrkOpeSmsSzablonId { get; set; }

    public int? CrAkCrkOpeSms { get; set; }

    public int? CrAkCrkOpeMail { get; set; }

    public byte? CrAkIwdEksport { get; set; }

    public int? CrAkIwdEksportKiedy { get; set; }

    public DateTime? CrAkIwdEksportOd { get; set; }

    public DateTime? CrAkIwdEksportDo { get; set; }

    public int? CrAkIwdEksportCo { get; set; }

    public int? CrAkIwdEksportZaOkres { get; set; }

    public string? CrAkIwdEksportRodzajeDok { get; set; }

    public byte? CrAkIwdImport { get; set; }

    public DateTime? CrAkIwdImportOd { get; set; }

    public DateTime? CrAkIwdImportDo { get; set; }

    public int? CrAkIwdImportCo { get; set; }

    public int? CrAkIwdImportUsuwanieRaportowCo { get; set; }

    public int? CrAkWydrukFaTyp { get; set; }

    public int? CrAkWydrukFaId { get; set; }

    public int? CrAkWydrukFaWalTyp { get; set; }

    public int? CrAkWydrukFaWalId { get; set; }

    public int? CrAkOpeZalId { get; set; }

    public DateTime CrAkTsZal { get; set; }

    public string CrAkOpeZalKod { get; set; } = null!;

    public string CrAkOpeZalNazwisko { get; set; } = null!;

    public int? CrAkOpeModId { get; set; }

    public DateTime CrAkTsMod { get; set; }

    public string CrAkOpeModKod { get; set; } = null!;

    public string CrAkOpeModNazwisko { get; set; } = null!;

    public int? CrAkStaZalId { get; set; }

    public int? CrAkStaModId { get; set; }

    public virtual Bazy CrAkBaz { get; set; } = null!;
}
