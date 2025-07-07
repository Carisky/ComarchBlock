using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymKierunekTel
{
    public string? KierunekAktualneOrgId { get; set; }

    public string? KierunekAktualneOrgParId { get; set; }

    public int? KierunekAktywny { get; set; }

    public int? KierunekDataDo { get; set; }

    public int? KierunekDataOd { get; set; }

    public string KierunekDirtyOrgId { get; set; } = null!;

    public int KierunekId { get; set; }

    public int? KierunekKimball1CheckSum { get; set; }

    public int? KierunekKimball2CheckSum { get; set; }

    public string? KierunekNazwa { get; set; }

    public string? KierunekOpis { get; set; }

    public string? KierunekOrgAtrId { get; set; }

    public string KierunekOrgId { get; set; } = null!;

    public string? KierunekOrgParId { get; set; }

    public string? KierunekParDirtyOrgId { get; set; }

    public int? KierunekParId { get; set; }

    public int? KierunekPoprzednikId { get; set; }

    public int? KierunekRowId { get; set; }

    public byte[] KierunekRowVersion { get; set; } = null!;

    public int? KierunekSubTransformationId { get; set; }

    public DateTime KierunekTsinsert { get; set; }

    public DateTime KierunekTsupdate { get; set; }

    public int? KierunekWymFirma { get; set; }

    public int? KierunekWymTyp { get; set; }

    public int KierunekZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
