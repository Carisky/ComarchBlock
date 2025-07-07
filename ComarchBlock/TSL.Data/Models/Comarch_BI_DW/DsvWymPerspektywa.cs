using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymPerspektywa
{
    public string? PerspektywaAktualneOrgId { get; set; }

    public string? PerspektywaAktualneOrgParId { get; set; }

    public string? PerspektywaAktualnyNazwa { get; set; }

    public int? PerspektywaAktywny { get; set; }

    public int? PerspektywaDataDo { get; set; }

    public int? PerspektywaDataOd { get; set; }

    public string PerspektywaDirtyOrgId { get; set; } = null!;

    public int PerspektywaId { get; set; }

    public int? PerspektywaKimball1CheckSum { get; set; }

    public int? PerspektywaKimball2CheckSum { get; set; }

    public string? PerspektywaNazwa { get; set; }

    public string? PerspektywaOpis { get; set; }

    public string? PerspektywaOrgAtrId { get; set; }

    public string PerspektywaOrgId { get; set; } = null!;

    public string? PerspektywaOrgParId { get; set; }

    public string? PerspektywaParDirtyOrgId { get; set; }

    public int? PerspektywaParId { get; set; }

    public int? PerspektywaPoprzednikId { get; set; }

    public int? PerspektywaRowId { get; set; }

    public byte[] PerspektywaRowVersion { get; set; } = null!;

    public int? PerspektywaSubTransformationId { get; set; }

    public DateTime PerspektywaTsinsert { get; set; }

    public DateTime PerspektywaTsupdate { get; set; }

    public int? PerspektywaWymFirma { get; set; }

    public int? PerspektywaWymTyp { get; set; }

    public int PerspektywaZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
