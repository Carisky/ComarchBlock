using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymStawkiVat
{
    public int SvatChecksumKimball1 { get; set; }

    public int SvatChecksumKimball2 { get; set; }

    public string SvatDirtyOrgId { get; set; } = null!;

    public string? SvatGrupa { get; set; }

    public int SvatId { get; set; }

    public int? SvatInsertSubTransformationId { get; set; }

    public int? SvatInsertTransformationId { get; set; }

    public string SvatNazwa { get; set; } = null!;

    public string? SvatOpis { get; set; }

    public string SvatOrgId { get; set; } = null!;

    public string? SvatParCleanOrgId { get; set; }

    public string? SvatParDirtyOrgId { get; set; }

    public int? SvatParGid { get; set; }

    public int? SvatRowId { get; set; }

    public byte[] SvatRowVersion { get; set; } = null!;

    public string? SvatStawka { get; set; }

    public DateTime SvatTimeFrom { get; set; }

    public DateTime? SvatTimeTo { get; set; }

    public DateTime SvatTsinsert { get; set; }

    public DateTime SvatTsupdate { get; set; }

    public int? SvatUpdateSubTransformationId { get; set; }

    public int? SvatUpdateTransformationId { get; set; }

    public int SvatZrodgid { get; set; }
}
