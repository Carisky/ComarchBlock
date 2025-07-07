using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymCzasTrwaniaTypTel
{
    public int CztrwaniaTypId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? CztrwaniaTypRowId { get; set; }

    public int? CztrwaniaTypWymTyp { get; set; }

    public int? CztrwaniaTypWymFirma { get; set; }

    public int? CztrwaniaTypPoprzednikId { get; set; }

    public string? CztrwaniaTypOrgAtrId { get; set; }

    public string? CztrwaniaTypOpis { get; set; }

    public string? CztrwaniaTypNazwa { get; set; }

    public int? CztrwaniaTypAktywny { get; set; }

    public string? CztrwaniaTypAktualneOrgParId { get; set; }

    public string? CztrwaniaTypAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int CztrwaniaTypZrodgid { get; set; }

    public DateTime CztrwaniaTypTsupdate { get; set; }

    public DateTime CztrwaniaTypTsinsert { get; set; }

    public int? CztrwaniaTypSubTransformationId { get; set; }

    public byte[] CztrwaniaTypRowVersion { get; set; } = null!;

    public int? CztrwaniaTypParId { get; set; }

    public string? CztrwaniaTypParDirtyOrgId { get; set; }

    public string? CztrwaniaTypOrgParId { get; set; }

    public string CztrwaniaTypOrgId { get; set; } = null!;

    public int? CztrwaniaTypKimball2CheckSum { get; set; }

    public int? CztrwaniaTypKimball1CheckSum { get; set; }

    public string CztrwaniaTypDirtyOrgId { get; set; } = null!;

    public int? CztrwaniaTypDataOd { get; set; }

    public int? CztrwaniaTypDataDo { get; set; }
}
