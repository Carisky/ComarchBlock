using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymDokumentTyp
{
    public string? DokTypAktualneOrgId { get; set; }

    public string? DokTypAktualneOrgParId { get; set; }

    public int? DokTypAktywny { get; set; }

    public int? DokTypDataDo { get; set; }

    public int? DokTypDataOd { get; set; }

    public string DokTypDirtyOrgId { get; set; } = null!;

    public int DokTypId { get; set; }

    public int? DokTypKimball1CheckSum { get; set; }

    public int? DokTypKimball2CheckSum { get; set; }

    public string? DokTypNazwa { get; set; }

    public string? DokTypOpis { get; set; }

    public string? DokTypOrgAtrId { get; set; }

    public string DokTypOrgId { get; set; } = null!;

    public string? DokTypOrgParId { get; set; }

    public string? DokTypParCleanOrgId { get; set; }

    public string? DokTypParDirtyOrgId { get; set; }

    public int? DokTypParId { get; set; }

    public int? DokTypPoprzednikId { get; set; }

    public int? DokTypRowId { get; set; }

    public byte[] DokTypRowVersion { get; set; } = null!;

    public string? DokTypSkrot { get; set; }

    public int? DokTypSubTransformationId { get; set; }

    public DateTime DokTypTsinsert { get; set; }

    public DateTime DokTypTsupdate { get; set; }

    public int? DokTypTyp { get; set; }

    public int? DokTypWymFirma { get; set; }

    public int? DokTypWymTyp { get; set; }

    public int DokTypZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
