using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymRozmowcaRodzajTel
{
    public int RzmRodzId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RzmRodzRowId { get; set; }

    public int? RzmRodzWymTyp { get; set; }

    public int? RzmRodzWymFirma { get; set; }

    public string? RzmRodzRodzaj { get; set; }

    public int? RzmRodzPoprzednikId { get; set; }

    public string? RzmRodzOrgAtrId { get; set; }

    public string? RzmRodzOpis { get; set; }

    public string? RzmRodzNazwa { get; set; }

    public int? RzmRodzAktywny { get; set; }

    public string? RzmRodzAktualneOrgParId { get; set; }

    public string? RzmRodzAktualneOrgId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int RzmRodzZrodgid { get; set; }

    public DateTime RzmRodzTsupdate { get; set; }

    public DateTime RzmRodzTsinsert { get; set; }

    public int? RzmRodzSubTransformationId { get; set; }

    public byte[] RzmRodzRowVersion { get; set; } = null!;

    public int? RzmRodzParId { get; set; }

    public string? RzmRodzParDirtyOrgId { get; set; }

    public string? RzmRodzOrgParId { get; set; }

    public string RzmRodzOrgId { get; set; } = null!;

    public int? RzmRodzKimball2CheckSum { get; set; }

    public int? RzmRodzKimball1CheckSum { get; set; }

    public string RzmRodzDirtyOrgId { get; set; } = null!;

    public int? RzmRodzDataOd { get; set; }

    public int? RzmRodzDataDo { get; set; }
}
