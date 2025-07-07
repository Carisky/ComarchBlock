using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymStazKlientaTyp
{
    public string? StazTypAktualneOrgId { get; set; }

    public string? StazTypAktualneOrgParId { get; set; }

    public int? StazTypAktywny { get; set; }

    public int? StazTypDataDo { get; set; }

    public int? StazTypDataOd { get; set; }

    public string StazTypDirtyOrgId { get; set; } = null!;

    public int StazTypId { get; set; }

    public int? StazTypKimball1CheckSum { get; set; }

    public int? StazTypKimball2CheckSum { get; set; }

    public string? StazTypNazwa { get; set; }

    public string? StazTypOpis { get; set; }

    public string? StazTypOrgAtrId { get; set; }

    public string StazTypOrgId { get; set; } = null!;

    public string? StazTypOrgParId { get; set; }

    public string? StazTypParDirtyOrgId { get; set; }

    public int? StazTypParId { get; set; }

    public int? StazTypPoprzednikId { get; set; }

    public int? StazTypRowId { get; set; }

    public byte[] StazTypRowVersion { get; set; } = null!;

    public int? StazTypSubTransformationId { get; set; }

    public DateTime StazTypTsinsert { get; set; }

    public DateTime StazTypTsupdate { get; set; }

    public int? StazTypWsadDeleteId { get; set; }

    public int? StazTypWymFirma { get; set; }

    public int? StazTypWymTyp { get; set; }

    public int StazTypZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
