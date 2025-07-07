using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymMiejsceSkladowanium
{
    public string? MsklAktualneOrgId { get; set; }

    public string? MsklAktualneOrgParId { get; set; }

    public int? MsklAktywny { get; set; }

    public int? MsklDataDo { get; set; }

    public int? MsklDataOd { get; set; }

    public string MsklDirtyOrgId { get; set; } = null!;

    public int MsklId { get; set; }

    public int? MsklKimball1CheckSum { get; set; }

    public int? MsklKimball2CheckSum { get; set; }

    public string? MsklKod { get; set; }

    public string? MsklNazwa { get; set; }

    public string? MsklOpis { get; set; }

    public string? MsklOrgAtrId { get; set; }

    public string? MsklOrgId { get; set; }

    public string? MsklOrgParId { get; set; }

    public string? MsklParCleanOrgId { get; set; }

    public string? MsklParDirtyOrgId { get; set; }

    public int? MsklParId { get; set; }

    public int? MsklPoprzednikId { get; set; }

    public int? MsklRowId { get; set; }

    public byte[] MsklRowVersion { get; set; } = null!;

    public int? MsklSubTransformationId { get; set; }

    public DateTime MsklTsinsert { get; set; }

    public DateTime MsklTsupdate { get; set; }

    public int? MsklWymFirma { get; set; }

    public int? MsklWymTyp { get; set; }

    public int MsklZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
