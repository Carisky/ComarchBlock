using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymRozmowcaNazwaTel
{
    public int? RzmNzwDataDo { get; set; }

    public int? RzmNzwDataOd { get; set; }

    public string RzmNzwDirtyOrgId { get; set; } = null!;

    public int RzmNzwId { get; set; }

    public int? RzmNzwKimball1CheckSum { get; set; }

    public int? RzmNzwKimball2CheckSum { get; set; }

    public string RzmNzwOrgId { get; set; } = null!;

    public string? RzmNzwOrgParId { get; set; }

    public string? RzmNzwParDirtyOrgId { get; set; }

    public int? RzmNzwParId { get; set; }

    public int RzmNzwRowId { get; set; }

    public byte[] RzmNzwRowVersion { get; set; } = null!;

    public int? RzmNzwSubTransformationId { get; set; }

    public DateTime RzmNzwTsinsert { get; set; }

    public DateTime RzmNzwTsupdate { get; set; }

    public int RzmNzwZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? RzmNzwRzmRodzId { get; set; }

    public string? RzmNzwAktualneOrgId { get; set; }

    public string? RzmNzwAktualneOrgParId { get; set; }

    public int? RzmNzwAktywny { get; set; }

    public string? RzmNzwNazwa { get; set; }

    public string? RzmNzwOpis { get; set; }

    public string? RzmNzwOrgAtrId { get; set; }

    public int? RzmNzwPoprzednikId { get; set; }

    public int? RzmNzwWymFirma { get; set; }

    public int? RzmNzwWymTyp { get; set; }

    public virtual WymRozmowcaRodzajTel? RzmNzwRzmRodz { get; set; }

    public virtual WymZrodloDanych RzmNzwZrodg { get; set; } = null!;

    public virtual ICollection<WymRozmowcaNumerTel> WymRozmowcaNumerTels { get; set; } = new List<WymRozmowcaNumerTel>();
}
