using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktUmowyDokPowiazane
{
    public int DopAdrKndId { get; set; }

    public int DopAlokacjaId { get; set; }

    public int DopBudzetId { get; set; }

    public int DopCzdid { get; set; }

    public string DopDirtyOrgId { get; set; } = null!;

    public int DopDokNumerId { get; set; }

    public int DopId { get; set; }

    public int DopInsertSubTransformationId { get; set; }

    public int? DopInsertTransformationId { get; set; }

    public int DopKndId { get; set; }

    public int DopKntId { get; set; }

    public decimal? DopMkosztNetto { get; set; }

    public decimal? DopMprocent { get; set; }

    public decimal? DopMprzychodNetto { get; set; }

    public decimal? DopMwartoscNetto { get; set; }

    public int DopObzid { get; set; }

    public int DopOpeid { get; set; }

    public int DopOpiekunId { get; set; }

    public string? DopOpis { get; set; }

    public string DopOrgAtrId { get; set; } = null!;

    public string DopOrgId { get; set; } = null!;

    public int DopProdId { get; set; }

    public int DopSvatid { get; set; }

    public DateTime DopTsinsert { get; set; }

    public DateTime DopTsupdate { get; set; }

    public int DopUmeid { get; set; }

    public int DopUmnid { get; set; }

    public int DopUpdateSubTransformationId { get; set; }

    public int? DopUpdateTransformationId { get; set; }

    public int DopWalutaId { get; set; }

    public int DopWygId { get; set; }

    public int DopZrodgid { get; set; }
}
