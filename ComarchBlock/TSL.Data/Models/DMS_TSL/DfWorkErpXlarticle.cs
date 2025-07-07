using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkErpXlarticle
{
    public int XlaId { get; set; }

    public int? XlaPosition { get; set; }

    public int XlaXldid { get; set; }

    public int? XlaArticleId { get; set; }

    public string? XlaArticleName { get; set; }

    public decimal? XlaQuantity { get; set; }

    public string? XlaUnitName { get; set; }

    public bool? XlaIsBaseUnit { get; set; }

    public decimal? XlaPrice { get; set; }

    public int? XlaTaxRateId { get; set; }

    public bool XlaArchival { get; set; }

    public string? XlaArticleCode { get; set; }

    public decimal? XlaCorrectionDocumentAmount { get; set; }

    public DateTime? XlaModificationDate { get; set; }

    public int? XlaDdsid { get; set; }

    public int? XlaDcdid { get; set; }

    public decimal? XlaVatValue { get; set; }

    public byte? XlaVatDeduction { get; set; }

    public virtual DfWorkErpXldocument XlaXld { get; set; } = null!;
}
