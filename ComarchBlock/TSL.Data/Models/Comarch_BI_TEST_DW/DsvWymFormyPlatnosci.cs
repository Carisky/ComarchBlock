using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymFormyPlatnosci
{
    public string? FormPlatAktualneOrgId { get; set; }

    public string? FormPlatAktualneOrgParId { get; set; }

    public int? FormPlatAktywny { get; set; }

    public int? FormPlatDataDo { get; set; }

    public int? FormPlatDataOd { get; set; }

    public string FormPlatDirtyOrgId { get; set; } = null!;

    public int FormPlatId { get; set; }

    public int? FormPlatKimball1CheckSum { get; set; }

    public int? FormPlatKimball2CheckSum { get; set; }

    public string? FormPlatNazwa { get; set; }

    public string? FormPlatOpis { get; set; }

    public string? FormPlatOrgAtrId { get; set; }

    public string FormPlatOrgId { get; set; } = null!;

    public string? FormPlatOrgParDirtyOrgId { get; set; }

    public string? FormPlatOrgParId { get; set; }

    public int? FormPlatParId { get; set; }

    public int? FormPlatPlatnosciTypId { get; set; }

    public int? FormPlatPoprzednikId { get; set; }

    public decimal? FormPlatRabat { get; set; }

    public string? FormPlatRejestr { get; set; }

    public int? FormPlatRowId { get; set; }

    public byte[] FormPlatRowVersion { get; set; } = null!;

    public int? FormPlatSubTransformationId { get; set; }

    public int? FormPlatTermin { get; set; }

    public DateTime FormPlatTsinsert { get; set; }

    public DateTime FormPlatTsupdate { get; set; }

    public int? FormPlatWymFirma { get; set; }

    public int? FormPlatWymTyp { get; set; }

    public int FormPlatZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
