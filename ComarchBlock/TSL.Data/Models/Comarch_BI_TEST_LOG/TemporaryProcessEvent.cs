using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class TemporaryProcessEvent
{
    public int TpeId { get; set; }

    public int TpeTransformationId { get; set; }

    public int? TpeLevel { get; set; }

    public string? TpeMessage { get; set; }

    public int? TpeReadRowCount { get; set; }

    public int? TpeInsertedRowCount { get; set; }

    public int? TpeUpdatedRowCount { get; set; }

    public int? TpeDeletedRowCount { get; set; }

    public int? TpeInvalidRowCount { get; set; }

    public DateTime? TpeDeletedRowBegin { get; set; }

    public DateTime? TpeDeletedRowEnd { get; set; }

    public DateTime? TpeExecutionStart { get; set; }

    public DateTime? TpeExecutionEnd { get; set; }

    public int? TpeInsertedAtTransRowCount { get; set; }

    public int? TpeUpdatedAtTransRowCount { get; set; }
}
