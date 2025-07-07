using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class OcDocument
{
    public int OcdId { get; set; }

    public Guid OcdDocumentId { get; set; }

    public string? OcdNumber { get; set; }

    public DateTime? OcdIssueDate { get; set; }

    public DateTime? OcdPurchaseDate { get; set; }

    public DateTime? OcdReceiptDate { get; set; }

    public DateTime? OcdDate { get; set; }

    public string? OcdCurrency { get; set; }

    public string? OcdContractorName1 { get; set; }

    public string? OcdContractorName2 { get; set; }

    public string? OcdContractorName3 { get; set; }

    public string? OcdContractorCountry { get; set; }

    public string? OcdContractorStreet { get; set; }

    public string? OcdContractorHouseNumber { get; set; }

    public string? OcdContractorApartmentNumber { get; set; }

    public string? OcdContractorCity { get; set; }

    public string? OcdContractorPostcode { get; set; }

    public string? OcdContractorPost { get; set; }

    public string? OcdContractorNip { get; set; }

    public DateTime? OcdPaymentDate { get; set; }

    public string? OcdPaymentType { get; set; }

    public decimal? OcdPaymentAmount { get; set; }

    public string? OcdCorrection { get; set; }

    public string? OcdCorrectionNumber { get; set; }

    public byte[]? OcdSourceContent { get; set; }

    public string? OcdFileName { get; set; }

    public byte OcdDocumentType { get; set; }

    public string? OcdBankAccountNumber { get; set; }

    public decimal? OcdCurrencyRate { get; set; }

    public decimal? OcdCurrencyUnit { get; set; }

    public DateTime? OcdCurrencyDate { get; set; }

    public string? OcdPaymentCurrency { get; set; }

    public string? OcdPaymentCurrencyType { get; set; }

    public decimal? OcdPaymentCurrencyRate { get; set; }

    public decimal? OcdPaymentCurrencyUnit { get; set; }

    public decimal? OcdSystemCurrencyPaymentAmount { get; set; }

    public DateTime? OcdPaymentCurrencyDate { get; set; }

    public string? OcdContractorName { get; set; }

    public string? OcdOrderNumber { get; set; }

    public string? OcdPurchaseOrderNumber { get; set; }

    public string? OcdBarcodeText { get; set; }

    public string? OcdBarcodeType { get; set; }

    public string? OcdContractorVoivodeship { get; set; }

    public bool? OcdContractorIsActiveVatPayer { get; set; }

    public string? OcdSellerContractorStreet { get; set; }

    public string? OcdSellerContractorHouseNumber { get; set; }

    public string? OcdSellerContractorApartmentNumber { get; set; }

    public string? OcdSellerContractorCity { get; set; }

    public string? OcdSellerContractorPostcode { get; set; }

    public string? OcdSellerContractorPost { get; set; }

    public string? OcdSellerContractorNip { get; set; }

    public string? OcdSellerContractorName { get; set; }

    public string? OcdSellerContractorVoivodeship { get; set; }

    public bool? OcdSellerContractorIsActiveVatPayer { get; set; }

    public string? OcdSellerContractorTaxIdentificationNumber { get; set; }

    public string? OcdBuyerContractorStreet { get; set; }

    public string? OcdBuyerContractorHouseNumber { get; set; }

    public string? OcdBuyerContractorApartmentNumber { get; set; }

    public string? OcdBuyerContractorCity { get; set; }

    public string? OcdBuyerContractorPostcode { get; set; }

    public string? OcdBuyerContractorPost { get; set; }

    public string? OcdBuyerContractorNip { get; set; }

    public string? OcdBuyerContractorName { get; set; }

    public string? OcdBuyerContractorVoivodeship { get; set; }

    public bool? OcdBuyerContractorIsActiveVatPayer { get; set; }

    public string? OcdLanguage { get; set; }

    public string? OcdVehicleIdentificationNumber { get; set; }

    public string? OcdQrreference { get; set; }

    public string? OcdQradditionalInformation { get; set; }

    public string? OcdQrbillInformation { get; set; }

    public string? OcdEsrCode { get; set; }

    public string? OcdEsrReference { get; set; }

    public string? OcdEsrSubscriberCode { get; set; }

    public string? OcdDocumentRawText { get; set; }

    public byte OcdDocumentName { get; set; }

    public DateTime? OcdOrderDate { get; set; }

    public DateTime? OcdDeliveryDate { get; set; }

    public decimal? OcdNetAmount { get; set; }

    public decimal? OcdGrossAmount { get; set; }

    public decimal? OcdVatAmount { get; set; }

    public int? OcdFirstPageNumber { get; set; }

    public string? OcdTag1 { get; set; }

    public string? OcdTag2 { get; set; }

    public string? OcdTag3 { get; set; }

    public virtual ICollection<OcDocumentItem> OcDocumentItems { get; set; } = new List<OcDocumentItem>();

    public virtual ICollection<OcDocumentJpkcode> OcDocumentJpkcodes { get; set; } = new List<OcDocumentJpkcode>();

    public virtual ICollection<OcDocumentVatRegistry> OcDocumentVatRegistries { get; set; } = new List<OcDocumentVatRegistry>();
}
