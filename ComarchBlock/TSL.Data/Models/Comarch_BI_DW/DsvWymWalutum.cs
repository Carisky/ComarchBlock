using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymWalutum
{
    public int? SubWsadInsertId { get; set; }

    public string? WalutaAktualneOrgId { get; set; }

    public string? WalutaAktualneOrgParId { get; set; }

    public int? WalutaAktywny { get; set; }

    public int? WalutaDataDo { get; set; }

    public int? WalutaDataOd { get; set; }

    public string WalutaDirtyOrgId { get; set; } = null!;

    public int WalutaId { get; set; }

    public int? WalutaKimball1CheckSum { get; set; }

    public int? WalutaKimball2CheckSum { get; set; }

    public string? WalutaNazwa { get; set; }

    public string? WalutaOpis { get; set; }

    public string? WalutaOrgAtrId { get; set; }

    public string WalutaOrgId { get; set; } = null!;

    public string? WalutaOrgParId { get; set; }

    public string? WalutaParDirtyOrgId { get; set; }

    public int? WalutaParId { get; set; }

    public int? WalutaPoprzednikId { get; set; }

    public int? WalutaRowId { get; set; }

    public byte[] WalutaRowVersion { get; set; } = null!;

    public int? WalutaSubTransformationId { get; set; }

    public string? WalutaSymbol { get; set; }

    public int? WalutaSystemowa { get; set; }

    public DateTime WalutaTsinsert { get; set; }

    public DateTime WalutaTsupdate { get; set; }

    public int? WalutaWymFirma { get; set; }

    public int? WalutaWymTyp { get; set; }

    public int WalutaZrodgid { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
