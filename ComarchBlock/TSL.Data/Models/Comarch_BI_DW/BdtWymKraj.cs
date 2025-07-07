using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymKraj
{
    public int KrajId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? KrajRowId { get; set; }

    public int? KrajWymTyp { get; set; }

    public int? KrajWymFirma { get; set; }

    public int? KrajPoprzednikId { get; set; }

    public string? KrajOrgParId { get; set; }

    public string? KrajOrgAtrId { get; set; }

    public string? KrajOpis { get; set; }

    public string? KrajNazwaEng { get; set; }

    public string? KrajNazwa { get; set; }

    public string? KrajKod { get; set; }

    public string? KrajGrupa { get; set; }

    public int? KrajAktywny { get; set; }

    public string? KrajAktualneOrgParId { get; set; }

    public string? KrajAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int KrajZrodgid { get; set; }

    public DateTime KrajTsupdate { get; set; }

    public DateTime KrajTsinsert { get; set; }

    public int? KrajSubTransformationId { get; set; }

    public byte[] KrajRowVersion { get; set; } = null!;

    public int? KrajParId { get; set; }

    public string? KrajParDirtyOrgId { get; set; }

    public string? KrajParCleanOrgId { get; set; }

    public string KrajOrgId { get; set; } = null!;

    public int? KrajKimball2CheckSum { get; set; }

    public int? KrajKimball1CheckSum { get; set; }

    public string KrajDirtyOrgId { get; set; } = null!;

    public int? KrajDataOd { get; set; }

    public int? KrajDataDo { get; set; }
}
