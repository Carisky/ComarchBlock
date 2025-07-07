using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymProjekt
{
    public int ProjektId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ProjektRowId { get; set; }

    public string? ProjektArchiwalny { get; set; }

    public int? ProjektWymTyp { get; set; }

    public int? ProjektWymFirma { get; set; }

    public string? ProjektUrl { get; set; }

    public int? ProjektTyp { get; set; }

    public string? ProjektSymbol { get; set; }

    public int? ProjektPoprzednikId { get; set; }

    public string? ProjektOrgAtrId { get; set; }

    public string? ProjektOpis { get; set; }

    public string? ProjektNazwa { get; set; }

    public string? ProjektKonto { get; set; }

    public string? ProjektKod { get; set; }

    public int? ProjektKategoria { get; set; }

    public string? ProjektCustomRollup { get; set; }

    public int? ProjektAktywny { get; set; }

    public string? ProjektAktualneOrgParId { get; set; }

    public string? ProjektAktualneOrgId { get; set; }

    public int? ProjektPracownikId { get; set; }

    public int? ProjektKntId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int ProjektZrodgid { get; set; }

    public DateTime ProjektTsupdate { get; set; }

    public DateTime ProjektTsinsert { get; set; }

    public int? ProjektSubTransformationId { get; set; }

    public byte[] ProjektRowVersion { get; set; } = null!;

    public int? ProjektParId { get; set; }

    public string? ProjektParDirtyOrgId { get; set; }

    public string? ProjektOrgParId { get; set; }

    public string ProjektOrgId { get; set; } = null!;

    public int? ProjektKimball2CheckSum { get; set; }

    public int? ProjektKimball1CheckSum { get; set; }

    public string ProjektDirtyOrgId { get; set; } = null!;

    public int? ProjektDataOd { get; set; }

    public int? ProjektDataDo { get; set; }

    public string? Hierarchy7Level1Name { get; set; }

    public string? Hierarchy7Level1OrgId { get; set; }

    public int? Hierarchy7Level1Id { get; set; }

    public string? Hierarchy7Level2Name { get; set; }

    public string? Hierarchy7Level2OrgId { get; set; }

    public int? Hierarchy7Level2Id { get; set; }
}
