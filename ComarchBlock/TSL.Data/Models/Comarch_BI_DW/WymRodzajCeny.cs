using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Rodzaj ceny
/// </summary>
public partial class WymRodzajCeny
{
    public int RodzCenRowId { get; set; }

    public int RodzCenId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int RodzCenZrodgid { get; set; }

    public string RodzCenOrgId { get; set; } = null!;

    public string RodzCenDirtyOrgId { get; set; } = null!;

    public string RodzCenNazwa { get; set; } = null!;

    public string? RodzCenOpis { get; set; }

    public string? RodzCenParDirtyOrgId { get; set; }

    public string? RodzCenParCleanOrgId { get; set; }

    public int? RodzCenParGid { get; set; }

    public DateTime RodzCenTsinsert { get; set; }

    public DateTime RodzCenTsupdate { get; set; }

    public DateTime RodzCenTimeFrom { get; set; }

    public DateTime? RodzCenTimeTo { get; set; }

    public int RodzCenChecksumKimball1 { get; set; }

    public int RodzCenChecksumKimball2 { get; set; }

    public int RodzCenUpdateSubTransformationId { get; set; }

    public int? RodzCenUpdateTransformationId { get; set; }

    public int RodzCenInsertSubTransformationId { get; set; }

    public int? RodzCenInsertTransformationId { get; set; }

    public byte[] RodzCenRowVersion { get; set; } = null!;

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual WymZrodloDanych RodzCenZrodg { get; set; } = null!;
}
