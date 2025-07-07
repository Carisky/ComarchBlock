using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkErpXldocumentHistory
{
    public int XlhId { get; set; }

    public int XlhXldid { get; set; }

    public int? XlhCustomerId { get; set; }

    public string? XlhCustomerName { get; set; }

    public string? XlhCustomerAcronym { get; set; }

    public string? XlhCurrency { get; set; }

    public int? XlhDocumentTypeId { get; set; }

    public int? XlhDocumentId { get; set; }

    public int? XlhCompanyId { get; set; }

    public int? XlhPayerId { get; set; }

    public string? XlhPayerName { get; set; }

    public int? XlhAccountingNoteSeriesId { get; set; }

    public string? XlhAccountingNoteSeriesName { get; set; }

    public string? XlhAccrualNoteDocTypeName { get; set; }

    public int? XlhAccrualNoteDocTypeId { get; set; }

    public decimal? XlhTotalExpenditure { get; set; }

    public decimal? XlhTotalIncome { get; set; }

    public decimal? XlhGrossAmount { get; set; }

    public decimal? XlhNetAmount { get; set; }

    public int? XlhPucharseTypeId { get; set; }

    public string? XlhPucharseTypeName { get; set; }

    public int? XlhTaxRateId { get; set; }

    public int? XlhPayerType { get; set; }

    public bool? XlhPayerIsCentral { get; set; }

    public int? XlhSeriesId { get; set; }

    public string? XlhSeriesName { get; set; }

    public int? XlhVatRegisterId { get; set; }

    public string? XlhVatRegisterName { get; set; }

    public bool? XlhVatRegisterTypeOfPatternIsRequired { get; set; }

    public int? XlhVatDeduction { get; set; }

    public int XlhPriceType { get; set; }

    public bool? XlhMappingDisabled { get; set; }

    public bool? XlhPricePrecision2Digits { get; set; }

    public int? XlhDdsid { get; set; }

    public int? XlhDcdid { get; set; }

    public DateTime? XlhModificationDate { get; set; }

    public int? XlhAccrualNoteDocTypeType { get; set; }
}
