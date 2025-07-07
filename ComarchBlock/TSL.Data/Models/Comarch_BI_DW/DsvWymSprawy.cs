using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymSprawy
{
    public string? SprawyAktualneOrgId { get; set; }

    public string? SprawyAktualneOrgParId { get; set; }

    public int? SprawyAktywny { get; set; }

    public int? SprawyDataDo { get; set; }

    public int? SprawyDataOd { get; set; }

    public string SprawyDirtyOrgId { get; set; } = null!;

    public int SprawyId { get; set; }

    public int? SprawyKimball1CheckSum { get; set; }

    public int? SprawyKimball2CheckSum { get; set; }

    public string SprawyNazwa { get; set; } = null!;

    public string? SprawyNumer { get; set; }

    public string? SprawyNumerSeryjny { get; set; }

    public string? SprawyOpis { get; set; }

    public string? SprawyOrgAtrId { get; set; }

    public string SprawyOrgId { get; set; } = null!;

    public string? SprawyOrgParId { get; set; }

    public string? SprawyParCleanOrgId { get; set; }

    public string? SprawyParDirtyOrgId { get; set; }

    public int? SprawyParId { get; set; }

    public int? SprawyPoprzednikId { get; set; }

    public int? SprawyPriorytet { get; set; }

    public int? SprawyRowId { get; set; }

    public byte[] SprawyRowVersion { get; set; } = null!;

    public string? SprawyRozliczenie { get; set; }

    public string? SprawyStatus { get; set; }

    public string? SprawyStreszczenie { get; set; }

    public int? SprawySubTransformationId { get; set; }

    public DateTime SprawyTsinsert { get; set; }

    public DateTime SprawyTsupdate { get; set; }

    public int? SprawyWymFirma { get; set; }

    public int? SprawyWymTyp { get; set; }

    public int SprawyZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
