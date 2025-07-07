using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkErpXldocument
{
    public int XldId { get; set; }

    public int? XldCustomerId { get; set; }

    public string? XldCustomerName { get; set; }

    public string? XldCustomerAcronym { get; set; }

    public string? XldCurrency { get; set; }

    public int? XldDocumentTypeId { get; set; }

    public int? XldDocumentId { get; set; }

    public int? XldCompanyId { get; set; }

    public int? XldPayerId { get; set; }

    public string? XldPayerName { get; set; }

    public int? XldAccountingNoteSeriesId { get; set; }

    public string? XldAccountingNoteSeriesName { get; set; }

    public string? XldAccrualNoteDocTypeName { get; set; }

    public int? XldAccrualNoteDocTypeId { get; set; }

    public decimal? XldTotalExpenditure { get; set; }

    public decimal? XldTotalIncome { get; set; }

    public decimal? XldGrossAmount { get; set; }

    public decimal? XldNetAmount { get; set; }

    public int? XldPucharseTypeId { get; set; }

    public string? XldPucharseTypeName { get; set; }

    public int? XldTaxRateId { get; set; }

    public int? XldPayerType { get; set; }

    public bool? XldPayerIsCentral { get; set; }

    public int? XldSeriesId { get; set; }

    public string? XldSeriesName { get; set; }

    public int? XldVatRegisterId { get; set; }

    public string? XldVatRegisterName { get; set; }

    public bool? XldVatRegisterTypeOfPatternIsRequired { get; set; }

    public int? XldVatDeduction { get; set; }

    public int XldPriceType { get; set; }

    public bool? XldMappingDisabled { get; set; }

    public bool? XldPricePrecision2Digits { get; set; }

    public DateTime? XldModificationDate { get; set; }

    public int? XldDdsid { get; set; }

    public int? XldDcdid { get; set; }

    public int? XldWarehouseId { get; set; }

    public string? XldWarehouseName { get; set; }

    public int? XldSourceWarehouseId { get; set; }

    public string? XldSourceWarehouseName { get; set; }

    public int? XldPayerAddressId { get; set; }

    public string? XldPayerAddressName { get; set; }

    public int? XldXldid { get; set; }

    public string? XldErpDocumentNumber { get; set; }

    public int? XldAccrualNoteDocTypeType { get; set; }

    public bool XldSplitPayment { get; set; }

    public int? XldBankAccountId { get; set; }

    public string? XldBankAccountNumber { get; set; }

    public bool XldBlockVatTableChanges { get; set; }

    public virtual ICollection<DfWorkErpXlaccrualNoteItem> DfWorkErpXlaccrualNoteItems { get; set; } = new List<DfWorkErpXlaccrualNoteItem>();

    public virtual ICollection<DfWorkErpXlarticle> DfWorkErpXlarticles { get; set; } = new List<DfWorkErpXlarticle>();
}
