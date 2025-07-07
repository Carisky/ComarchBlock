using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsDocument
{
    public int KsdId { get; set; }

    public string? KsdKodWaluty { get; set; }

    public DateTime? KsdDataWystawienia { get; set; }

    public string? KsdMiejsceWystawienia { get; set; }

    public string? KsdNumerFaktury { get; set; }

    public DateTime? KsdDataDostawy { get; set; }

    public DateTime? KsdDataSprzedazyOd { get; set; }

    public DateTime? KsdDataSprzedazyDo { get; set; }

    public decimal? KsdSumaNettoStawkaPodstawowa { get; set; }

    public decimal? KsdSumaVatstawkaPodstawowa { get; set; }

    public decimal? KsdSumaVatstawkaPodstawowaPln { get; set; }

    public decimal? KsdSumaNettoStawkaObnizona { get; set; }

    public decimal? KsdSumaVatstawkaObnizona { get; set; }

    public decimal? KsdSumaVatstawkaObnizonaPln { get; set; }

    public decimal? KsdSumaNettoStawkaObnizonaDruga { get; set; }

    public decimal? KsdSumaVatstawkaObnizonaDruga { get; set; }

    public decimal? KsdSumaVatstawkaObnizonaDrugaPln { get; set; }

    public decimal? KsdSumaNettoStawkaObnizonaTrzecia { get; set; }

    public decimal? KsdSumaVatstawkaObnizonaTrzecia { get; set; }

    public decimal? KsdSumaVatstawkaObnizonaTrzeciaPln { get; set; }

    public decimal? KsdSumaNettoStawkiExportowe { get; set; }

    public decimal? KsdSumaVatoss { get; set; }

    public decimal? KsdSumaNetto0NoWdtNoExport { get; set; }

    public decimal? KsdSumaNetto0Wdt { get; set; }

    public decimal? KsdSumaNetto0Export { get; set; }

    public decimal? KsdSumaNettoZw { get; set; }

    public decimal? KsdSumaNettoInna { get; set; }

    public decimal? KsdSumaNettoRs { get; set; }

    public decimal? KsdSumaNettoOokraj { get; set; }

    public decimal? KsdSumaNettoMarza { get; set; }

    public decimal? KsdSumaBrutto { get; set; }

    public decimal? KsdKursWalutyZ { get; set; }

    public short? KsdMetodaKasowa { get; set; }

    public short? KsdSamofakturowanie { get; set; }

    public short? KsdOdwrotneObciazenie { get; set; }

    public short? KsdPodzielonaPlatnosc { get; set; }

    public short? KsdSprzedazZwolniona { get; set; }

    public string? KsdSprzedazZwustawa { get; set; }

    public string? KsdSprzedazZwdyrektywa { get; set; }

    public string? KsdSprzedazZwpodstawa { get; set; }

    public short? KsdZnacznikNstwdt { get; set; }

    public short? KsdNstwdt { get; set; }

    public short? KsdFakturaProceduraUproszczona { get; set; }

    public short? KsdFakturaVatmarza { get; set; }

    public short? KsdMarzaBiuraPodrozy { get; set; }

    public short? KsdMarzaTowaryUzywane { get; set; }

    public short? KsdMarzaDzielaSztuki { get; set; }

    public short? KsdMarzaKolekcjonerskieAntyki { get; set; }

    public string? KsdRodzajFaktury { get; set; }

    public string? KsdPrzyczynaKorekty { get; set; }

    public byte? KsdTypKorekty { get; set; }

    public DateTime? KsdDataWystFaKorygowanej { get; set; }

    public string? KsdNrFaKorygowanej { get; set; }

    public string? KsdNrKseFfaKorygowanej { get; set; }

    public string? KsdOkresFaKorygowanej { get; set; }

    public string? KsdNrFaKorygowany { get; set; }

    public string? KsdKorDanychPodatnikPrefiksNip { get; set; }

    public string? KsdKorDanychPodatnikNip { get; set; }

    public string? KsdKorDanychPodatnikNazwa { get; set; }

    public string? KsdKorDanychPodatnikKodKraju { get; set; }

    public string? KsdKorDanychPodatnikAdres { get; set; }

    public string? KsdKorDanychPodatnikGln { get; set; }

    public decimal? KsdFaKorygowanaKwotaZaplatyPrzedKorekta { get; set; }

    public decimal? KsdKursWalutyZk { get; set; }

    public short? KsdFakturaDoParagonu { get; set; }

    public short? KsdFakturaPowiazanyNabywca { get; set; }

    public short? KsdZwrotAkcyzy { get; set; }

    public decimal? KsdRozliczenieObciazeniaSuma { get; set; }

    public decimal? KsdRozliczenieOdliczeniaSuma { get; set; }

    public decimal? KsdRozliczenieDoZaplaty { get; set; }

    public decimal? KsdRozliczenieDoRozliczenia { get; set; }

    public short? KsdPlZaplacono { get; set; }

    public DateTime? KsdPlDataZaplaty { get; set; }

    public short? KsdPlZaplataCzesciowa { get; set; }

    public decimal? KsdKwotaZaplatyCzesciowej { get; set; }

    public DateTime? KsdDataZaplatyCzesciowej { get; set; }

    public byte? KsdFormaPlatnosci { get; set; }

    public short? KsdPlatnoscInna { get; set; }

    public string? KsdOpisPlatnosci { get; set; }

    public string? KsdWarunkiSkonta { get; set; }

    public string? KsdWysokoscSkonta { get; set; }

    public string? KsdWarunkiTransakcjiWarunkiDostawy { get; set; }

    public decimal? KsdWarunkiTransakcjiKursUmowny { get; set; }

    public string? KsdWarunkiTransakcjiWalutaUmowna { get; set; }

    public short? KsdWarunkiTransakcjiPodmiotPosredniczacy { get; set; }

    public decimal? KsdZamWartoscBrutto { get; set; }

    public string? KsdXml { get; set; }

    public string? KsdHtml { get; set; }

    public virtual ICollection<KsAdditionalDescription> KsAdditionalDescriptions { get; set; } = new List<KsAdditionalDescription>();

    public virtual ICollection<KsAsidocument> KsAsidocuments { get; set; } = new List<KsAsidocument>();

    public virtual ICollection<KsBankAccount> KsBankAccounts { get; set; } = new List<KsBankAccount>();

    public virtual ICollection<KsDeductionSettlement> KsDeductionSettlements { get; set; } = new List<KsDeductionSettlement>();

    public virtual ICollection<KsDocumentAgreement> KsDocumentAgreements { get; set; } = new List<KsDocumentAgreement>();

    public virtual ICollection<KsDocumentContractor> KsDocumentContractors { get; set; } = new List<KsDocumentContractor>();

    public virtual ICollection<KsDocumentFooter> KsDocumentFooters { get; set; } = new List<KsDocumentFooter>();

    public virtual ICollection<KsDocumentHeader> KsDocumentHeaders { get; set; } = new List<KsDocumentHeader>();

    public virtual ICollection<KsDocumentItem> KsDocumentItems { get; set; } = new List<KsDocumentItem>();

    public virtual ICollection<KsDocumentLotNumber> KsDocumentLotNumbers { get; set; } = new List<KsDocumentLotNumber>();

    public virtual ICollection<KsDocumentOrderItem> KsDocumentOrderItems { get; set; } = new List<KsDocumentOrderItem>();

    public virtual ICollection<KsDocumentOrder> KsDocumentOrders { get; set; } = new List<KsDocumentOrder>();

    public virtual ICollection<KsFactorBankAccount> KsFactorBankAccounts { get; set; } = new List<KsFactorBankAccount>();

    public virtual ICollection<KsLoadSettlement> KsLoadSettlements { get; set; } = new List<KsLoadSettlement>();

    public virtual ICollection<KsPartialPayment> KsPartialPayments { get; set; } = new List<KsPartialPayment>();

    public virtual ICollection<KsPaymentDate> KsPaymentDates { get; set; } = new List<KsPaymentDate>();

    public virtual ICollection<KsSordocument> KsSordocuments { get; set; } = new List<KsSordocument>();

    public virtual ICollection<KsTransportMean> KsTransportMeans { get; set; } = new List<KsTransportMean>();

    public virtual ICollection<KsTransport> KsTransports { get; set; } = new List<KsTransport>();
}
