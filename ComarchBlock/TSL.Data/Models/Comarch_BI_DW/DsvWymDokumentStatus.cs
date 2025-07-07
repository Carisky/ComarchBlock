using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymDokumentStatus
{
    public string? DokStatAktualneOrgId { get; set; }

    public string? DokStatAktualneOrgParId { get; set; }

    public int? DokStatAktywny { get; set; }

    public int? DokStatDataDo { get; set; }

    public int? DokStatDataOd { get; set; }

    public string DokStatDirtyOrgId { get; set; } = null!;

    public int DokStatId { get; set; }

    public int? DokStatKimball1CheckSum { get; set; }

    public int? DokStatKimball2CheckSum { get; set; }

    public string? DokStatNazwa { get; set; }

    public string? DokStatOpis { get; set; }

    public string? DokStatOrgAtrId { get; set; }

    public string DokStatOrgId { get; set; } = null!;

    public string? DokStatOrgParId { get; set; }

    public string? DokStatParDirtyOrgId { get; set; }

    public int? DokStatParId { get; set; }

    public int? DokStatPoprzednikId { get; set; }

    public int? DokStatRowId { get; set; }

    public byte[] DokStatRowVersion { get; set; } = null!;

    public int? DokStatSubTransformationId { get; set; }

    public DateTime DokStatTsinsert { get; set; }

    public DateTime DokStatTsupdate { get; set; }

    public int? DokStatWymFirma { get; set; }

    public int? DokStatWymTyp { get; set; }

    public int DokStatZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
