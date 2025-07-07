using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymMiejscowosc
{
    public string? MiejscowoscAktualneOrgId { get; set; }

    public string? MiejscowoscAktualneOrgParId { get; set; }

    public int? MiejscowoscAktywny { get; set; }

    public int? MiejscowoscDataDo { get; set; }

    public int? MiejscowoscDataOd { get; set; }

    public string MiejscowoscDirtyOrgId { get; set; } = null!;

    public int MiejscowoscId { get; set; }

    public int? MiejscowoscKimball1CheckSum { get; set; }

    public int? MiejscowoscKimball2CheckSum { get; set; }

    public string? MiejscowoscNazwa { get; set; }

    public string? MiejscowoscOpis { get; set; }

    public string? MiejscowoscOrgAtrId { get; set; }

    public string MiejscowoscOrgId { get; set; } = null!;

    public string? MiejscowoscOrgParId { get; set; }

    public string? MiejscowoscParCleanOrgId { get; set; }

    public string? MiejscowoscParDirtyOrgId { get; set; }

    public int? MiejscowoscParId { get; set; }

    public int? MiejscowoscPoprzednikId { get; set; }

    public int? MiejscowoscRowId { get; set; }

    public byte[] MiejscowoscRowVersion { get; set; } = null!;

    public int? MiejscowoscSubTransformationId { get; set; }

    public DateTime MiejscowoscTsinsert { get; set; }

    public DateTime MiejscowoscTsupdate { get; set; }

    public int? MiejscowoscWymFirma { get; set; }

    public int? MiejscowoscWymTyp { get; set; }

    public int MiejscowoscZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
