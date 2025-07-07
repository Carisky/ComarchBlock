using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class SlDocument
{
    public int Id { get; set; }

    public string? CompanyProgramId { get; set; }

    public long DocumentId { get; set; }

    public DateTime? SaldeoSyncCreateDate { get; set; }

    public string? Number { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? SaleDate { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public DateOnly? ReceiveDate { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }

    public string? Registry { get; set; }

    public int? FolderMonth { get; set; }

    public int? FolderYear { get; set; }

    public bool? IsCorrective { get; set; }

    public string? CorrInvNum { get; set; }

    public DateOnly? CorrInvDate { get; set; }

    public bool? IsCashBasis { get; set; }

    public string? CurrencyIso4217 { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal? CurrencyFactor { get; set; }

    public string? CurrencyTable { get; set; }

    public DateOnly? CurrencyDate { get; set; }

    public string? ContractorProgramId { get; set; }

    public string? ContractorNip { get; set; }

    public int? ContractorId { get; set; }

    public string? ContractorFullName { get; set; }

    public string? ContractorShortName { get; set; }

    public string? ContractorStreet { get; set; }

    public string? ContractorPostcode { get; set; }

    public string? ContractorCity { get; set; }

    public string? ContractorCountryIso3166a2 { get; set; }

    public decimal? Sum { get; set; }

    public string? PaymentType { get; set; }

    public byte[]? SourceContent { get; set; }

    public string? Filename { get; set; }

    public string? QueueUser { get; set; }

    public long OcrId { get; set; }

    public virtual ICollection<SlDocumentBankAccount> SlDocumentBankAccounts { get; set; } = new List<SlDocumentBankAccount>();

    public virtual ICollection<SlDocumentItem> SlDocumentItems { get; set; } = new List<SlDocumentItem>();

    public virtual ICollection<SlDocumentVatRegistry> SlDocumentVatRegistries { get; set; } = new List<SlDocumentVatRegistry>();

    public virtual ICollection<SlItem> SlItems { get; set; } = new List<SlItem>();
}
