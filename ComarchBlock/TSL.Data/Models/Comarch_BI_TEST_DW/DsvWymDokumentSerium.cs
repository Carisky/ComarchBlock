using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymDokumentSerium
{
    public string? DokSerAktualneOrgId { get; set; }

    public string? DokSerAktualneOrgParId { get; set; }

    public int? DokSerAktywny { get; set; }

    public int? DokSerDataDo { get; set; }

    public int? DokSerDataOd { get; set; }

    public string DokSerDirtyOrgId { get; set; } = null!;

    public int DokSerId { get; set; }

    public int? DokSerKimball1CheckSum { get; set; }

    public int? DokSerKimball2CheckSum { get; set; }

    public string? DokSerNazwa { get; set; }

    public string? DokSerOpis { get; set; }

    public string? DokSerOrgAtrId { get; set; }

    public string DokSerOrgId { get; set; } = null!;

    public string? DokSerOrgParId { get; set; }

    public string? DokSerParCleanOrgId { get; set; }

    public string? DokSerParDirtyOrgId { get; set; }

    public int? DokSerParId { get; set; }

    public int? DokSerPoprzednikId { get; set; }

    public int? DokSerRowId { get; set; }

    public byte[] DokSerRowVersion { get; set; } = null!;

    public int? DokSerSubTransformationId { get; set; }

    public DateTime DokSerTsinsert { get; set; }

    public DateTime DokSerTsupdate { get; set; }

    public int? DokSerTyp { get; set; }

    public string? DokSerTypRejestru { get; set; }

    public string? DokSerWalutaRejestru { get; set; }

    public int? DokSerWymFirma { get; set; }

    public int? DokSerWymTyp { get; set; }

    public int DokSerZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
