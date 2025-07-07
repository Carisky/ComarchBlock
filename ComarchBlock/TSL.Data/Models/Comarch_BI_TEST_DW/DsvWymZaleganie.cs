using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymZaleganie
{
    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? ZaleganieAktualneOrgId { get; set; }

    public string? ZaleganieAktualneOrgParId { get; set; }

    public int? ZaleganieAktywny { get; set; }

    public int? ZaleganieDataDo { get; set; }

    public int? ZaleganieDataOd { get; set; }

    public string ZaleganieDirtyOrgId { get; set; } = null!;

    public int? ZaleganieDo { get; set; }

    public int ZaleganieId { get; set; }

    public int? ZaleganieKimball1CheckSum { get; set; }

    public int? ZaleganieKimball2CheckSum { get; set; }

    public string? ZaleganieNazwa { get; set; }

    public int? ZaleganieOd { get; set; }

    public string? ZaleganieOpis { get; set; }

    public string? ZaleganieOrgAtrId { get; set; }

    public string ZaleganieOrgId { get; set; } = null!;

    public string? ZaleganieOrgParId { get; set; }

    public string? ZaleganieParCleanOrgId { get; set; }

    public string? ZaleganieParDirtyOrgId { get; set; }

    public int? ZaleganieParId { get; set; }

    public int? ZaleganiePoprzednikId { get; set; }

    public int? ZaleganieRowId { get; set; }

    public byte[] ZaleganieRowVersion { get; set; } = null!;

    public int? ZaleganieSubTransformationId { get; set; }

    public DateTime ZaleganieTsinsert { get; set; }

    public DateTime ZaleganieTsupdate { get; set; }

    public int? ZaleganieTypId { get; set; }

    public string ZaleganieTypOrgId { get; set; } = null!;

    public int? ZaleganieWymFirma { get; set; }

    public int? ZaleganieWymTyp { get; set; }

    public int ZaleganieZrodgid { get; set; }
}
