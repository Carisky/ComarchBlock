using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfCfmultiLineCtrlList
{
    public int DmlId { get; set; }

    public int DmlDkoid { get; set; }

    public string? DmlName { get; set; }

    public int DmlCompanyId { get; set; }

    public int? DmlInitType { get; set; }

    public string? DmlSqlQuery { get; set; }

    public byte DmlExpectedSqlQueryResultColumnsCount { get; set; }

    public int? DmlWorkMode { get; set; }

    public bool DmlArchival { get; set; }

    public int DmlPosition { get; set; }

    public int? DmlDclid { get; set; }

    public bool DmlIsSearchForAnyStringModeEnabled { get; set; }

    public string? DmlCsScriptName { get; set; }

    public string? DmlCsScriptGenerated { get; set; }

    public string? DmlCsScriptUser { get; set; }

    public string? DmlCsScriptReferences { get; set; }

    public byte DmlIdentifierType { get; set; }
}
