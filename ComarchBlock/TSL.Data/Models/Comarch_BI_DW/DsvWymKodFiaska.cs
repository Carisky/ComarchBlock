using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymKodFiaska
{
    public string? KdfAktualneOrgId { get; set; }

    public string? KdfAktualneOrgParId { get; set; }

    public int? KdfAktywny { get; set; }

    public int? KdfDataDo { get; set; }

    public int? KdfDataOd { get; set; }

    public string KdfDirtyOrgId { get; set; } = null!;

    public int KdfId { get; set; }

    public int? KdfKimball1CheckSum { get; set; }

    public int? KdfKimball2CheckSum { get; set; }

    public string? KdfNazwa { get; set; }

    public string? KdfOpis { get; set; }

    public string? KdfOrgAtrId { get; set; }

    public string KdfOrgId { get; set; } = null!;

    public string? KdfOrgParId { get; set; }

    public string? KdfParCleanOrgId { get; set; }

    public string? KdfParDirtyOrgId { get; set; }

    public int? KdfParId { get; set; }

    public int? KdfPoprzednikId { get; set; }

    public int? KdfRowId { get; set; }

    public byte[] KdfRowVersion { get; set; } = null!;

    public int? KdfSubTransformationId { get; set; }

    public DateTime KdfTsinsert { get; set; }

    public DateTime KdfTsupdate { get; set; }

    public int? KdfWymFirma { get; set; }

    public int? KdfWymTyp { get; set; }

    public int KdfZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? KdfRodzaj { get; set; }
}
