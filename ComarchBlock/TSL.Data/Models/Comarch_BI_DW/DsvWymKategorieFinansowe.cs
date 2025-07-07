using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymKategorieFinansowe
{
    public string? KatFinAktualneOrgId { get; set; }

    public string? KatFinAktualneOrgParId { get; set; }

    public int? KatFinAktywny { get; set; }

    public string? KatFinArchiwalny { get; set; }

    public string? KatFinCustomRollup { get; set; }

    public int? KatFinDataDo { get; set; }

    public int? KatFinDataOd { get; set; }

    public string? KatFinDirtyOrgId { get; set; }

    public int KatFinId { get; set; }

    public int? KatFinKategoria { get; set; }

    public int? KatFinKimball1CheckSum { get; set; }

    public int? KatFinKimball2CheckSum { get; set; }

    public string? KatFinKonto { get; set; }

    public string? KatFinNazwa { get; set; }

    public string? KatFinOpis { get; set; }

    public string? KatFinOrgAtrId { get; set; }

    public string KatFinOrgId { get; set; } = null!;

    public string? KatFinOrgParId { get; set; }

    public string? KatFinOrgWart { get; set; }

    public string? KatFinParDirtyOrgId { get; set; }

    public int? KatFinParId { get; set; }

    public int? KatFinPoprzednikId { get; set; }

    public int? KatFinRowId { get; set; }

    public byte[] KatFinRowVersion { get; set; } = null!;

    public int? KatFinSubTransformationId { get; set; }

    public DateTime KatFinTsinsert { get; set; }

    public DateTime KatFinTsupdate { get; set; }

    public int? KatFinTyp { get; set; }

    public int? KatFinWymFirma { get; set; }

    public int? KatFinWymTyp { get; set; }

    public int KatFinZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
