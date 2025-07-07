using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymLokalizacja
{
    public string? LokAktualneOrgId { get; set; }

    public string? LokAktualneOrgParId { get; set; }

    public int? LokAktywny { get; set; }

    public int? LokDataDo { get; set; }

    public int? LokDataOd { get; set; }

    public string LokDirtyOrgId { get; set; } = null!;

    public int LokId { get; set; }

    public int? LokKimball1CheckSum { get; set; }

    public int? LokKimball2CheckSum { get; set; }

    public string? LokNazwa { get; set; }

    public string? LokOpis { get; set; }

    public string? LokOrgAtrId { get; set; }

    public string LokOrgId { get; set; } = null!;

    public string? LokOrgParId { get; set; }

    public string? LokParCleanOrgId { get; set; }

    public string? LokParDirtyOrgId { get; set; }

    public int? LokParId { get; set; }

    public int? LokPoprzednikId { get; set; }

    public int? LokRowId { get; set; }

    public byte[] LokRowVersion { get; set; } = null!;

    public int? LokSubTransformationId { get; set; }

    public string? LokSymbol { get; set; }

    public DateTime LokTsinsert { get; set; }

    public DateTime LokTsupdate { get; set; }

    public int? LokWymFirma { get; set; }

    public int? LokWymTyp { get; set; }

    public int LokZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
