using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class DqOutput
{
    public int DqoId { get; set; }

    public int DqoDqrcode { get; set; }

    public int? DqoTransformationId { get; set; }

    public DateTime? DqoExecutionDate { get; set; }

    public bool DqoResult { get; set; }

    public decimal? DqoDiff { get; set; }

    public string? DqoDescription { get; set; }

    public string? DqoTableName { get; set; }

    public string? DqoColumnName { get; set; }

    public decimal? DqoValue { get; set; }

    public decimal? DqoExpectedValue { get; set; }

    public string? DqoRuleStatus { get; set; }

    public virtual DqRule DqoDqrcodeNavigation { get; set; } = null!;
}
