using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class LogicalSource1
{
    public int MlsId { get; set; }

    public DateTime? MlsTsinsert { get; set; }

    public string? MlsModifiedBy { get; set; }

    public string? MlsName { get; set; }

    public string? MlsAction { get; set; }

    public int? MlsIsMigrated { get; set; }

    public DateTime? MlsTsmigrate { get; set; }

    public string? MlsNameOld { get; set; }

    public int? MlsLsid { get; set; }

    public int? MlsDepid { get; set; }
}
