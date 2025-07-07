using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymWojewodztwo
{
    public int? SubWsadInsertId { get; set; }

    public string? WojAktualneOrgId { get; set; }

    public string? WojAktualneOrgParId { get; set; }

    public int? WojAktywny { get; set; }

    public int? WojDataDo { get; set; }

    public int? WojDataOd { get; set; }

    public string WojDirtyOrgId { get; set; } = null!;

    public int WojId { get; set; }

    public int? WojKimball1CheckSum { get; set; }

    public int? WojKimball2CheckSum { get; set; }

    public string? WojNazwa { get; set; }

    public string? WojOpis { get; set; }

    public string? WojOrgAtrId { get; set; }

    public string WojOrgId { get; set; } = null!;

    public string? WojOrgParId { get; set; }

    public string? WojParCleanOrgId { get; set; }

    public string? WojParDirtyOrgId { get; set; }

    public int? WojParId { get; set; }

    public int? WojPoprzednikId { get; set; }

    public int? WojRowId { get; set; }

    public byte[] WojRowVersion { get; set; } = null!;

    public int? WojSubTransformationId { get; set; }

    public DateTime WojTsinsert { get; set; }

    public DateTime WojTsupdate { get; set; }

    public int? WojWymFirma { get; set; }

    public int? WojWymTyp { get; set; }

    public int WojZrodgid { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
