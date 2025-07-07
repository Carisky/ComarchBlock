using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymCzasMinutum
{
    public int CzminId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? CzminRowId { get; set; }

    public int? CzminWymTyp { get; set; }

    public int? CzminWymFirma { get; set; }

    public int? CzminPoprzednikId { get; set; }

    public string? CzminOrgParId { get; set; }

    public string? CzminOrgAtrId { get; set; }

    public string? CzminOpis { get; set; }

    public string? CzminNazwa { get; set; }

    public int? CzminMinuta { get; set; }

    public int? CzminAktywny { get; set; }

    public string? CzminAktualneOrgParId { get; set; }

    public string? CzminAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int CzminZrodgid { get; set; }

    public DateTime CzminTsupdate { get; set; }

    public DateTime CzminTsinsert { get; set; }

    public int? CzminSubTransformationId { get; set; }

    public byte[] CzminRowVersion { get; set; } = null!;

    public int? CzminParId { get; set; }

    public string? CzminParDirtyOrgId { get; set; }

    public string? CzminParCleanOrgId { get; set; }

    public string CzminOrgId { get; set; } = null!;

    public int? CzminKimball2CheckSum { get; set; }

    public int? CzminKimball1CheckSum { get; set; }

    public string? CzminDirtyOrgId { get; set; }

    public int? CzminDataOd { get; set; }

    public int? CzminDataDo { get; set; }
}
