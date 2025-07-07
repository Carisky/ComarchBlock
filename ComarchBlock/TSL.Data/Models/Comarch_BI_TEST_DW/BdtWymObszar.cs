using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymObszar
{
    public int ObszarId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ObszarRowId { get; set; }

    public int? ObszarWymTyp { get; set; }

    public int? ObszarWymFirma { get; set; }

    public int? ObszarPoprzednikId { get; set; }

    public string? ObszarOrgAtrId { get; set; }

    public string? ObszarOpis { get; set; }

    public string? ObszarNazwa { get; set; }

    public int? ObszarAktywny { get; set; }

    public string? ObszarAktualneOrgParId { get; set; }

    public string? ObszarAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int ObszarZrodgid { get; set; }

    public DateTime ObszarTsupdate { get; set; }

    public DateTime ObszarTsinsert { get; set; }

    public int? ObszarSubTransformationId { get; set; }

    public byte[] ObszarRowVersion { get; set; } = null!;

    public int? ObszarParId { get; set; }

    public string? ObszarParDirtyOrgId { get; set; }

    public string? ObszarOrgParId { get; set; }

    public string ObszarOrgId { get; set; } = null!;

    public int? ObszarKimball2CheckSum { get; set; }

    public int? ObszarKimball1CheckSum { get; set; }

    public string ObszarDirtyOrgId { get; set; } = null!;

    public int? ObszarDataOd { get; set; }

    public int? ObszarDataDo { get; set; }
}
