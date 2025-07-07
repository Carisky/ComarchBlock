using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymRozmowcaRodzajTel
{
    public int? RzmRodzDataDo { get; set; }

    public int? RzmRodzDataOd { get; set; }

    public string RzmRodzDirtyOrgId { get; set; } = null!;

    public int RzmRodzId { get; set; }

    public int? RzmRodzKimball1CheckSum { get; set; }

    public int? RzmRodzKimball2CheckSum { get; set; }

    public string RzmRodzOrgId { get; set; } = null!;

    public string? RzmRodzOrgParId { get; set; }

    public string? RzmRodzParDirtyOrgId { get; set; }

    public int? RzmRodzParId { get; set; }

    public int RzmRodzRowId { get; set; }

    public byte[] RzmRodzRowVersion { get; set; } = null!;

    public int? RzmRodzSubTransformationId { get; set; }

    public DateTime RzmRodzTsinsert { get; set; }

    public DateTime RzmRodzTsupdate { get; set; }

    public int RzmRodzZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? RzmRodzAktualneOrgId { get; set; }

    public string? RzmRodzAktualneOrgParId { get; set; }

    public int? RzmRodzAktywny { get; set; }

    public string? RzmRodzNazwa { get; set; }

    public string? RzmRodzOpis { get; set; }

    public string? RzmRodzOrgAtrId { get; set; }

    public int? RzmRodzPoprzednikId { get; set; }

    public string? RzmRodzRodzaj { get; set; }

    public int? RzmRodzWymFirma { get; set; }

    public int? RzmRodzWymTyp { get; set; }

    public virtual WymZrodloDanych RzmRodzZrodg { get; set; } = null!;

    public virtual ICollection<WymRozmowcaNazwaTel> WymRozmowcaNazwaTels { get; set; } = new List<WymRozmowcaNazwaTel>();
}
