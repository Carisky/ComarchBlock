using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymPromocjeTyp
{
    public string? PrtAktualneOrgId { get; set; }

    public string? PrtAktualneOrgParId { get; set; }

    public int? PrtAktywny { get; set; }

    public int? PrtDataDo { get; set; }

    public int? PrtDataOd { get; set; }

    public string PrtDirtyOrgId { get; set; } = null!;

    public int PrtId { get; set; }

    public int? PrtKimball1CheckSum { get; set; }

    public int? PrtKimball2CheckSum { get; set; }

    public string? PrtNazwa { get; set; }

    public string? PrtOpis { get; set; }

    public string? PrtOrgAtrId { get; set; }

    public string PrtOrgId { get; set; } = null!;

    public string? PrtOrgParId { get; set; }

    public string? PrtParDirtyOrgId { get; set; }

    public int? PrtParId { get; set; }

    public int? PrtPoprzednikId { get; set; }

    public int? PrtRowId { get; set; }

    public byte[] PrtRowVersion { get; set; } = null!;

    public int? PrtSubTransformationId { get; set; }

    public DateTime PrtTsinsert { get; set; }

    public DateTime PrtTsupdate { get; set; }

    public int? PrtWymFirma { get; set; }

    public int? PrtWymTyp { get; set; }

    public int PrtZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
