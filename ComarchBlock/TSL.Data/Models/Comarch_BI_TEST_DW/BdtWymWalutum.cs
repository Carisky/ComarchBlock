using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymWalutum
{
    public int WalutaId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? WalutaRowId { get; set; }

    public int? WalutaWymTyp { get; set; }

    public int? WalutaWymFirma { get; set; }

    public int? WalutaSystemowa { get; set; }

    public string? WalutaSymbol { get; set; }

    public int? WalutaPoprzednikId { get; set; }

    public string? WalutaOrgAtrId { get; set; }

    public string? WalutaOpis { get; set; }

    public string? WalutaNazwa { get; set; }

    public int? WalutaAktywny { get; set; }

    public string? WalutaAktualneOrgParId { get; set; }

    public string? WalutaAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int WalutaZrodgid { get; set; }

    public DateTime WalutaTsupdate { get; set; }

    public DateTime WalutaTsinsert { get; set; }

    public int? WalutaSubTransformationId { get; set; }

    public byte[] WalutaRowVersion { get; set; } = null!;

    public int? WalutaParId { get; set; }

    public string? WalutaParDirtyOrgId { get; set; }

    public string? WalutaOrgParId { get; set; }

    public string WalutaOrgId { get; set; } = null!;

    public int? WalutaKimball2CheckSum { get; set; }

    public int? WalutaKimball1CheckSum { get; set; }

    public string WalutaDirtyOrgId { get; set; } = null!;

    public int? WalutaDataOd { get; set; }

    public int? WalutaDataDo { get; set; }

    public int? SubWsadInsertId { get; set; }
}
