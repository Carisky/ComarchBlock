using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Zmienne i szablony zestawień księgowych
/// </summary>
public partial class WymZestawieniaZmienne
{
    /// <summary>
    /// Relation to dimension OkresyObrachunkowe
    /// </summary>
    public int ZsrOkrgid { get; set; }

    /// <summary>
    /// Relation to dimension ZestawieniaStruktura
    /// </summary>
    public int ZsrZszgid { get; set; }

    public int ZsrRowId { get; set; }

    public int ZsrId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int ZsrZrodgid { get; set; }

    public string ZsrOrgId { get; set; } = null!;

    public string ZsrDirtyOrgId { get; set; } = null!;

    public string ZsrNazwa { get; set; } = null!;

    public string? ZsrOpis { get; set; }

    public string? ZsrParDirtyOrgId { get; set; }

    public string? ZsrParCleanOrgId { get; set; }

    public int? ZsrParGid { get; set; }

    public DateTime ZsrTsinsert { get; set; }

    public DateTime ZsrTsupdate { get; set; }

    public DateTime ZsrTimeFrom { get; set; }

    public DateTime? ZsrTimeTo { get; set; }

    public int ZsrChecksumKimball1 { get; set; }

    public int ZsrChecksumKimball2 { get; set; }

    public int ZsrUpdateSubTransformationId { get; set; }

    public int? ZsrUpdateTransformationId { get; set; }

    public int ZsrInsertSubTransformationId { get; set; }

    public int? ZsrInsertTransformationId { get; set; }

    public byte[] ZsrRowVersion { get; set; } = null!;

    public string? ZsrTytul { get; set; }

    public string? ZsrZakres { get; set; }

    public int? ZsrZknNumer { get; set; }

    public string? ZsrZmienna { get; set; }

    public virtual WymOkresyObrachunkowe ZsrOkrg { get; set; } = null!;

    public virtual WymZrodloDanych ZsrZrodg { get; set; } = null!;

    public virtual WymZestawieniaStruktura ZsrZszg { get; set; } = null!;
}
