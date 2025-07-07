using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class ReportTranslation
{
    public int RptId { get; set; }

    public string RptLocaleId { get; set; } = null!;

    public string RptReportName { get; set; } = null!;

    public string RptTranslationSubject { get; set; } = null!;

    public string? RptOriginalText { get; set; }

    public string? RptTranslatedText { get; set; }
}
