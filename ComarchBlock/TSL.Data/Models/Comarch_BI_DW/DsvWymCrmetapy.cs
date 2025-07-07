using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymCrmetapy
{
    public string? CrmetapAkcja { get; set; }

    public string? CrmetapAktualneOrgId { get; set; }

    public string? CrmetapAktualneOrgParId { get; set; }

    public int? CrmetapAktywny { get; set; }

    public int? CrmetapDataDo { get; set; }

    public int? CrmetapDataOd { get; set; }

    public string CrmetapDirtyOrgId { get; set; } = null!;

    public int CrmetapId { get; set; }

    public int? CrmetapKampaniaId { get; set; }

    public int? CrmetapKimball1CheckSum { get; set; }

    public int? CrmetapKimball2CheckSum { get; set; }

    public string? CrmetapKod { get; set; }

    public string? CrmetapNazwa { get; set; }

    public string? CrmetapOpis { get; set; }

    public string? CrmetapOrgAtrId { get; set; }

    public string CrmetapOrgId { get; set; } = null!;

    public string? CrmetapOrgParId { get; set; }

    public string? CrmetapParCleanOrgId { get; set; }

    public string? CrmetapParDirtyOrgId { get; set; }

    public int? CrmetapParId { get; set; }

    public int? CrmetapPoprzednikId { get; set; }

    public int? CrmetapPozycja { get; set; }

    public int? CrmetapRowId { get; set; }

    public byte[] CrmetapRowVersion { get; set; } = null!;

    public int? CrmetapSubTransformationId { get; set; }

    public int? CrmetapSzansa { get; set; }

    public DateTime CrmetapTsinsert { get; set; }

    public DateTime CrmetapTsupdate { get; set; }

    public string? CrmetapUrl { get; set; }

    public string? CrmetapWymaganaAkcja { get; set; }

    public string? CrmetapWymaganaTransakcja { get; set; }

    public int? CrmetapWymFirma { get; set; }

    public int? CrmetapWymTyp { get; set; }

    public int CrmetapZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
