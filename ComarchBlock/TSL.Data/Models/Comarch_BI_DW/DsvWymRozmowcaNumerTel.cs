using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymRozmowcaNumerTel
{
    public string? RzmNrAktualneOrgId { get; set; }

    public string? RzmNrAktualneOrgParId { get; set; }

    public int? RzmNrAktywny { get; set; }

    public int? RzmNrDataDo { get; set; }

    public int? RzmNrDataOd { get; set; }

    public string RzmNrDirtyOrgId { get; set; } = null!;

    public int RzmNrId { get; set; }

    public int? RzmNrKimball1CheckSum { get; set; }

    public int? RzmNrKimball2CheckSum { get; set; }

    public string? RzmNrNazwa { get; set; }

    public string? RzmNrNumerTel { get; set; }

    public string? RzmNrOpis { get; set; }

    public string? RzmNrOrgAtrId { get; set; }

    public string RzmNrOrgId { get; set; } = null!;

    public string? RzmNrOrgParId { get; set; }

    public string? RzmNrParDirtyOrgId { get; set; }

    public int? RzmNrParId { get; set; }

    public int? RzmNrPoprzednikId { get; set; }

    public int? RzmNrRowId { get; set; }

    public byte[] RzmNrRowVersion { get; set; } = null!;

    public int? RzmNrRzmNzwId { get; set; }

    public int? RzmNrSubTransformationId { get; set; }

    public DateTime RzmNrTsinsert { get; set; }

    public DateTime RzmNrTsupdate { get; set; }

    public int? RzmNrWymFirma { get; set; }

    public int? RzmNrWymTyp { get; set; }

    public int RzmNrZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
