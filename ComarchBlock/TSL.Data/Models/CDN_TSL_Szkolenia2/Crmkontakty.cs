using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Crmkontakty
{
    public int CrkCrkid { get; set; }

    public int CrkWatekId { get; set; }

    public int? CrkParId { get; set; }

    public int CrkDdfId { get; set; }

    public string CrkNumerString { get; set; } = null!;

    public int CrkNumerNr { get; set; }

    public string? CrkNumerPelny { get; set; }

    public int CrkAnulowany { get; set; }

    public short CrkBufor { get; set; }

    public short? CrkPodmiotTyp { get; set; }

    public int? CrkPodId { get; set; }

    public int? CrkOsobaId { get; set; }

    public string CrkOsobaNazwisko { get; set; } = null!;

    public short? CrkOpiekunTyp { get; set; }

    public int? CrkOpiekunId { get; set; }

    public byte CrkObsluga { get; set; }

    public DateTime CrkDataDok { get; set; }

    public DateTime? CrkCzasPrzygot { get; set; }

    public DateTime? CrkCzasKontaktu { get; set; }

    public DateTime? CrkCzasOpracow { get; set; }

    public byte CrkZadanie { get; set; }

    public DateTime? CrkTerminOd { get; set; }

    public DateTime? CrkTerminDo { get; set; }

    public byte CrkPrzypomnienie { get; set; }

    public DateTime? CrkCzasPrzypomnienia { get; set; }

    public byte CrkPriorytet { get; set; }

    public decimal CrkWykonano { get; set; }

    public int? CrkEtapRealizacji { get; set; }

    public string CrkTemat { get; set; } = null!;

    public string CrkOpis { get; set; } = null!;

    public string CrkUwagiDoRealizacji { get; set; } = null!;

    public string? CrkLokalizacja { get; set; }

    public int CrkWindykacja { get; set; }

    public int? CrkOpeZalId { get; set; }

    public int? CrkStaZalId { get; set; }

    public DateTime CrkTsZal { get; set; }

    public int? CrkOpeModId { get; set; }

    public int? CrkStaModId { get; set; }

    public DateTime CrkTsMod { get; set; }

    public string CrkOpeModKod { get; set; } = null!;

    public string CrkOpeModNazwisko { get; set; } = null!;

    public string CrkOpeZalKod { get; set; } = null!;

    public string CrkOpeZalNazwisko { get; set; } = null!;

    public int? CrkStanowiskoId { get; set; }

    public int? CrkDokId { get; set; }

    public byte CrKAutomatycznePrzypomnienia { get; set; }

    public byte? CrKAutomatycznePrzypomnieniaMail { get; set; }

    public string? CrKAutomatycznePrzypomnieniaEmailAdres { get; set; }

    public DateTime? CrKAutomatycznePrzypomnieniaMailCzasPrzypomnienia { get; set; }

    public DateTime? CrKAutomatycznePrzypomnieniaMailWyslano { get; set; }

    public int? CrKAutomatycznePrzypomnieniaMailSzablonId { get; set; }

    public byte? CrKAutomatycznePrzypomnieniaSms { get; set; }

    public string? CrKAutomatycznePrzypomnieniaSmsNumerTelefonu { get; set; }

    public DateTime? CrKAutomatycznePrzypomnieniaSmsCzasPrzypomnienia { get; set; }

    public DateTime? CrKAutomatycznePrzypomnieniaSmsWyslano { get; set; }

    public int? CrKAutomatycznePrzypomnieniaSmsSzablonId { get; set; }

    public byte CrKAutomatycznePrzypomnieniaOpe { get; set; }

    public byte? CrKAutomatycznePrzypomnieniaOpeMail { get; set; }

    public DateTime? CrKAutomatycznePrzypomnieniaOpeMailCzasPrzypomnienia { get; set; }

    public DateTime? CrKAutomatycznePrzypomnieniaOpeMailWyslano { get; set; }

    public int? CrKAutomatycznePrzypomnieniaOpeMailSzablonId { get; set; }

    public byte? CrKAutomatycznePrzypomnieniaOpeSms { get; set; }

    public DateTime? CrKAutomatycznePrzypomnieniaOpeSmsCzasPrzypomnienia { get; set; }

    public DateTime? CrKAutomatycznePrzypomnieniaOpeSmsWyslano { get; set; }

    public int? CrKAutomatycznePrzypomnieniaOpeSmsSzablonId { get; set; }

    public int CrkCykl { get; set; }

    public int CrkCyklTyp { get; set; }

    public int CrkCyklPowtarzajCo { get; set; }

    public int CrkCyklDzienTygodnia { get; set; }

    public int CrkCyklDzienMiesiaca { get; set; }

    public int CrkCyklMiesiac { get; set; }

    public int CrkCyklTydzien { get; set; }

    public DateTime? CrkCyklDataStart { get; set; }

    public DateTime? CrkCyklDataEnd { get; set; }

    public int CrkCyklLiczbaWystapien { get; set; }

    public int? CrkCyklParentId { get; set; }

    public virtual DokDefinicje CrkDdf { get; set; } = null!;

    public virtual KntOsoby? CrkOsoba { get; set; }

    public virtual Crmkontakty? CrkPar { get; set; }

    public virtual ICollection<CrmKontaktyCykl> CrmKontaktyCykls { get; set; } = new List<CrmKontaktyCykl>();

    public virtual ICollection<Crmdokumenty> Crmdokumenties { get; set; } = new List<Crmdokumenty>();

    public virtual ICollection<DokAtrybuty> DokAtrybuties { get; set; } = new List<DokAtrybuty>();

    public virtual ICollection<Crmkontakty> InverseCrkPar { get; set; } = new List<Crmkontakty>();

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
