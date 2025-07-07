using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymDekretBufor
{
    public int? DtbufDataDo { get; set; }

    public int? DtbufDataOd { get; set; }

    public string DtbufDirtyOrgId { get; set; } = null!;

    public int DtbufId { get; set; }

    public int? DtbufKimball1CheckSum { get; set; }

    public int? DtbufKimball2CheckSum { get; set; }

    public string DtbufOrgId { get; set; } = null!;

    public string? DtbufOrgParId { get; set; }

    public string? DtbufParDirtyOrgId { get; set; }

    public int? DtbufParId { get; set; }

    public int DtbufRowId { get; set; }

    public byte[] DtbufRowVersion { get; set; } = null!;

    public int? DtbufSubTransformationId { get; set; }

    public DateTime DtbufTsinsert { get; set; }

    public DateTime DtbufTsupdate { get; set; }

    public int DtbufZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? DtbufAktualneOrgId { get; set; }

    public string? DtbufAktualneOrgParId { get; set; }

    public int? DtbufAktywny { get; set; }

    public string? DtbufNazwa { get; set; }

    public string? DtbufOpis { get; set; }

    public string? DtbufOrgAtrId { get; set; }

    public int? DtbufPoprzednikId { get; set; }

    public int? DtbufWymFirma { get; set; }

    public int? DtbufWymTyp { get; set; }

    public virtual WymZrodloDanych DtbufZrodg { get; set; } = null!;

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();
}
