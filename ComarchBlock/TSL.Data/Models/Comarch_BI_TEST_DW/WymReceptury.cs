using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

/// <summary>
/// Lista receptur kompletacji i dekompletacji
/// </summary>
public partial class WymReceptury
{
    /// <summary>
    /// Relation to dimension Produkt. Produkt w nagłówku receptury.
    /// </summary>
    public int RecProdGid { get; set; }

    public int RecRowId { get; set; }

    public int RecId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int RecZrodgid { get; set; }

    public string RecOrgId { get; set; } = null!;

    public string RecDirtyOrgId { get; set; } = null!;

    public string RecNazwa { get; set; } = null!;

    public string? RecOpis { get; set; }

    public string? RecParDirtyOrgId { get; set; }

    public string? RecParCleanOrgId { get; set; }

    public int? RecParGid { get; set; }

    public DateTime RecTsinsert { get; set; }

    public DateTime RecTsupdate { get; set; }

    public DateTime RecTimeFrom { get; set; }

    public DateTime? RecTimeTo { get; set; }

    public int RecChecksumKimball1 { get; set; }

    public int RecChecksumKimball2 { get; set; }

    public int RecUpdateSubTransformationId { get; set; }

    public int? RecUpdateTransformationId { get; set; }

    public int RecInsertSubTransformationId { get; set; }

    public int? RecInsertTransformationId { get; set; }

    public byte[] RecRowVersion { get; set; } = null!;

    /// <summary>
    /// Czy receptura domyślna.
    /// </summary>
    public int? RecDomyslna { get; set; }

    /// <summary>
    /// Jednostka miary produktu na recepturze
    /// </summary>
    public string? RecJmProduktu { get; set; }

    /// <summary>
    /// Atrybuty nagłówka receptury
    /// </summary>
    public string? RecOrgAtrId { get; set; }

    public string? RecSymbol { get; set; }

    /// <summary>
    /// 0 – receptura kompletacji, 1- receptura dekompletacji
    /// </summary>
    public int? RecTyp { get; set; }

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjas { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual WymProdukt RecProdG { get; set; } = null!;

    public virtual WymZrodloDanych RecZrodg { get; set; } = null!;
}
