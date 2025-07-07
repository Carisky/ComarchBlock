using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymRezerwacjaNumer
{
    public int RenRowId { get; set; }

    public int RenId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int RenZrodgid { get; set; }

    public string RenOrgId { get; set; } = null!;

    public string RenDirtyOrgId { get; set; } = null!;

    public string RenNazwa { get; set; } = null!;

    public string? RenOpis { get; set; }

    public string? RenParDirtyOrgId { get; set; }

    public string? RenParCleanOrgId { get; set; }

    public int? RenParGid { get; set; }

    public DateTime RenTsinsert { get; set; }

    public DateTime RenTsupdate { get; set; }

    public DateTime RenTimeFrom { get; set; }

    public DateTime? RenTimeTo { get; set; }

    public int RenChecksumKimball1 { get; set; }

    public int RenChecksumKimball2 { get; set; }

    public int? RenUpdateSubTransformationId { get; set; }

    public int? RenUpdateTransformationId { get; set; }

    public int? RenInsertSubTransformationId { get; set; }

    public int? RenInsertTransformationId { get; set; }

    public byte[] RenRowVersion { get; set; } = null!;

    public string? RenPelnyNumer { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int RenOpegid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentTyp
    /// </summary>
    public int RenDokTypGid { get; set; }

    public string? RenCzyAktualny { get; set; }

    public string? RenRodzaj { get; set; }

    public byte? RenPriorytet { get; set; }

    public int? FaktyRez { get; set; }

    public int? RenReTid { get; set; }

    public virtual WymDokumentTyp RenDokTypG { get; set; } = null!;

    public virtual WymOperator RenOpeg { get; set; } = null!;

    public virtual WymRezerwacjaTyp? RenReT { get; set; }

    public virtual WymZrodloDanych RenZrodg { get; set; } = null!;
}
