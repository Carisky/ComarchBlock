using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymSposobDostawy
{
    public int SpdId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? SpdRowId { get; set; }

    public int? SpdWymTyp { get; set; }

    public int? SpdWymFirma { get; set; }

    public int? SpdPoprzednikId { get; set; }

    public string? SpdOrgParId { get; set; }

    public string? SpdOrgAtrId { get; set; }

    public string? SpdOpis { get; set; }

    public string? SpdNazwa { get; set; }

    public int? SpdAktywny { get; set; }

    public string? SpdAktualneOrgParId { get; set; }

    public string? SpdAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int SpdZrodgid { get; set; }

    public DateTime SpdTsupdate { get; set; }

    public DateTime SpdTsinsert { get; set; }

    public int? SpdSubTransformationId { get; set; }

    public byte[] SpdRowVersion { get; set; } = null!;

    public int? SpdParId { get; set; }

    public string? SpdParDirtyOrgId { get; set; }

    public string? SpdParCleanOrgId { get; set; }

    public string SpdOrgId { get; set; } = null!;

    public int? SpdKimball2CheckSum { get; set; }

    public int? SpdKimball1CheckSum { get; set; }

    public string SpdDirtyOrgId { get; set; } = null!;

    public int? SpdDataOd { get; set; }

    public int? SpdDataDo { get; set; }
}
