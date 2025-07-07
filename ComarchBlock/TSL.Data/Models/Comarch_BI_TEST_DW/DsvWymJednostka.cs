using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymJednostka
{
    public string? JmAktualneOrgId { get; set; }

    public string? JmAktualneOrgParId { get; set; }

    public int? JmAktywny { get; set; }

    public int? JmDataDo { get; set; }

    public int? JmDataOd { get; set; }

    public string JmDirtyOrgId { get; set; } = null!;

    public int JmId { get; set; }

    public int? JmKimball1CheckSum { get; set; }

    public int? JmKimball2CheckSum { get; set; }

    public string? JmNazwa { get; set; }

    public string? JmOpis { get; set; }

    public string? JmOrgAtrId { get; set; }

    public string JmOrgId { get; set; } = null!;

    public string? JmOrgParId { get; set; }

    public string? JmParDirtyOrgId { get; set; }

    public int? JmParId { get; set; }

    public int? JmPoprzednikId { get; set; }

    public int? JmRowId { get; set; }

    public byte[] JmRowVersion { get; set; } = null!;

    public int? JmSubTransformationId { get; set; }

    public DateTime JmTsinsert { get; set; }

    public DateTime JmTsupdate { get; set; }

    public int? JmWymFirma { get; set; }

    public int? JmWymTyp { get; set; }

    public int JmZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
