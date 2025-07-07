using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymStrukturaFirmy
{
    public int StrFrmId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? StrFrmRowId { get; set; }

    public string? Gid { get; set; }

    public string? StrFrmNazwaPar { get; set; }

    public int? StrFrmWymTyp { get; set; }

    public int? StrFrmWymFirma { get; set; }

    public string? StrFrmUrl { get; set; }

    public int? StrFrmTyp { get; set; }

    public int? StrFrmPoprzednikId { get; set; }

    public string? StrFrmOrgAtrId { get; set; }

    public string? StrFrmOpis { get; set; }

    public string? StrFrmOlapSecurity { get; set; }

    public string? StrFrmNazwa { get; set; }

    public string? StrFrmKonto { get; set; }

    public int? StrFrmAktywny { get; set; }

    public string? StrFrmAktualneOrgParId { get; set; }

    public string? StrFrmAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int StrFrmZrodgid { get; set; }

    public DateTime StrFrmTsupdate { get; set; }

    public DateTime StrFrmTsinsert { get; set; }

    public int? StrFrmSubTransformationId { get; set; }

    public byte[] StrFrmRowVersion { get; set; } = null!;

    public int? StrFrmParId { get; set; }

    public string? StrFrmParDirtyOrgId { get; set; }

    public string? StrFrmOrgParId { get; set; }

    public string StrFrmOrgId { get; set; } = null!;

    public int? StrFrmKimball2CheckSum { get; set; }

    public int? StrFrmKimball1CheckSum { get; set; }

    public string StrFrmDirtyOrgId { get; set; } = null!;

    public int? StrFrmDataOd { get; set; }

    public int? StrFrmDataDo { get; set; }

    public int? StrFrmOptimaId { get; set; }

    public string? Hierarchy5Level1Name { get; set; }

    public string? Hierarchy5Level1OrgId { get; set; }

    public int? Hierarchy5Level1Id { get; set; }

    public string? Hierarchy5Level2Name { get; set; }

    public string? Hierarchy5Level2OrgId { get; set; }

    public int? Hierarchy5Level2Id { get; set; }

    public string? Hierarchy5Level3Name { get; set; }

    public string? Hierarchy5Level3OrgId { get; set; }

    public int? Hierarchy5Level3Id { get; set; }
}
