using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymCzasTrwaniaTel
{
    public int CztrwaniaId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? CztrwaniaRowId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? CztrwaniaWymTyp { get; set; }

    public int? CztrwaniaWymFirma { get; set; }

    public string CztrwaniaTypOrgId { get; set; } = null!;

    public int? CztrwaniaPoprzednikId { get; set; }

    public string? CztrwaniaOrgParId { get; set; }

    public string? CztrwaniaOrgAtrId { get; set; }

    public string? CztrwaniaOpis { get; set; }

    public int? CztrwaniaOd { get; set; }

    public string? CztrwaniaNazwa { get; set; }

    public int? CztrwaniaDo { get; set; }

    public int? CztrwaniaAktywny { get; set; }

    public string? CztrwaniaAktualneOrgParId { get; set; }

    public string? CztrwaniaAktualneOrgId { get; set; }

    public int? CztrwaniaTypId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int CztrwaniaZrodgid { get; set; }

    public DateTime CztrwaniaTsupdate { get; set; }

    public DateTime CztrwaniaTsinsert { get; set; }

    public int? CztrwaniaSubTransformationId { get; set; }

    public byte[] CztrwaniaRowVersion { get; set; } = null!;

    public int? CztrwaniaParId { get; set; }

    public string? CztrwaniaParDirtyOrgId { get; set; }

    public string? CztrwaniaParCleanOrgId { get; set; }

    public string? CztrwaniaOrgId { get; set; }

    public int? CztrwaniaKimball2CheckSum { get; set; }

    public int? CztrwaniaKimball1CheckSum { get; set; }

    public string CztrwaniaDirtyOrgId { get; set; } = null!;

    public int? CztrwaniaDataOd { get; set; }

    public int? CztrwaniaDataDo { get; set; }
}
