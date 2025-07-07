using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymCechy
{
    public string? CechaAktualneOrgId { get; set; }

    public string? CechaAktualneOrgParId { get; set; }

    public int? CechaAktywny { get; set; }

    public int? CechaDataDo { get; set; }

    public int? CechaDataOd { get; set; }

    public string CechaDirtyOrgId { get; set; } = null!;

    public int CechaId { get; set; }

    public int? CechaKimball1CheckSum { get; set; }

    public int? CechaKimball2CheckSum { get; set; }

    public int? CechaKlasaId { get; set; }

    public string? CechaNazwa { get; set; }

    public string? CechaOpis { get; set; }

    public string? CechaOrgAtrId { get; set; }

    public string CechaOrgId { get; set; } = null!;

    public string? CechaOrgParId { get; set; }

    public string? CechaParCleanOrgId { get; set; }

    public string? CechaParDirtyOrgId { get; set; }

    public int? CechaParId { get; set; }

    public int? CechaPoprzednikId { get; set; }

    public int? CechaRowId { get; set; }

    public byte[] CechaRowVersion { get; set; } = null!;

    public int? CechaSubTransformationId { get; set; }

    public DateTime CechaTsinsert { get; set; }

    public DateTime CechaTsupdate { get; set; }

    public int? CechaWymFirma { get; set; }

    public int? CechaWymTyp { get; set; }

    public int CechaZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
