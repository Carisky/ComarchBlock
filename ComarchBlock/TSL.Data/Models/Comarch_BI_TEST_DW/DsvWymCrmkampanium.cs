using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymCrmkampanium
{
    public string? CrmkampAktualneOrgId { get; set; }

    public string? CrmkampAktualneOrgParId { get; set; }

    public int? CrmkampAktywny { get; set; }

    public int? CrmkampDataDo { get; set; }

    public int? CrmkampDataOd { get; set; }

    public string CrmkampDirtyOrgId { get; set; } = null!;

    public int CrmkampId { get; set; }

    public string? CrmkampKategoria { get; set; }

    public int? CrmkampKimball1CheckSum { get; set; }

    public int? CrmkampKimball2CheckSum { get; set; }

    public string? CrmkampKod { get; set; }

    public string? CrmkampNazwa { get; set; }

    public string? CrmkampOpis { get; set; }

    public string? CrmkampOrgAtrId { get; set; }

    public string CrmkampOrgId { get; set; } = null!;

    public string? CrmkampOrgParId { get; set; }

    public string? CrmkampParCleanOrgId { get; set; }

    public string? CrmkampParDirtyOrgId { get; set; }

    public int? CrmkampParId { get; set; }

    public int? CrmkampPoprzednikId { get; set; }

    public int? CrmkampRowId { get; set; }

    public byte[] CrmkampRowVersion { get; set; } = null!;

    public string? CrmkampStan { get; set; }

    public int? CrmkampSubTransformationId { get; set; }

    public DateTime CrmkampTsinsert { get; set; }

    public DateTime CrmkampTsupdate { get; set; }

    public string? CrmkampTyp { get; set; }

    public string? CrmkampUrl { get; set; }

    public int? CrmkampWymFirma { get; set; }

    public int? CrmkampWymTyp { get; set; }

    public string? CrmkampZakres { get; set; }

    public int CrmkampZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
