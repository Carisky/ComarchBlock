using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class VWymWizyty
{
    public int WzwRowId { get; set; }

    public int WzwId { get; set; }

    public int WzwZrodgid { get; set; }

    public string WzwOrgId { get; set; } = null!;

    public string WzwDirtyOrgId { get; set; } = null!;

    public string WzwNazwa { get; set; } = null!;

    public string? WzwOpis { get; set; }

    public string? WzwParDirtyOrgId { get; set; }

    public string? WzwParCleanOrgId { get; set; }

    public int? WzwParGid { get; set; }

    public DateTime WzwTsinsert { get; set; }

    public DateTime WzwTsupdate { get; set; }

    public DateTime WzwTimeFrom { get; set; }

    public DateTime? WzwTimeTo { get; set; }

    public int WzwChecksumKimball1 { get; set; }

    public int WzwChecksumKimball2 { get; set; }

    public int WzwUpdateTransformationId { get; set; }

    public int? WzwUpdateSubTransformationId { get; set; }

    public int WzwInsertTransformationId { get; set; }

    public int? WzwInsertSubTransformationId { get; set; }

    public byte[] WzwRowVersion { get; set; } = null!;

    public int? WzwCechaTransakcjiId { get; set; }

    public int? WzwKodFiaskaId { get; set; }

    public int? WzwSposobDostawyId { get; set; }

    public int? WzwDokStatusId { get; set; }

    public int? WzwOperatorId { get; set; }

    public int? WzwDokTypId { get; set; }

    public int? WzwDokSeriaId { get; set; }

    public string? WzwTyp { get; set; }

    public string? WzwOrgAtrId { get; set; }

    public string? WzwPelnyNumer { get; set; }

    public string? WzwSpiOrgId { get; set; }

    public string? WzwGrupowanie { get; set; }

    public int? WzwAktywny { get; set; }

    public string? WzwKosztUstalono { get; set; }

    public string? WzwDataDokumentu { get; set; }

    public string? WzwGodzRozpPlan { get; set; }

    public string? WzwGodzRozpRzecz { get; set; }

    public string? WzwGodzZakPlan { get; set; }

    public string? WzwGodzZakRzecz { get; set; }

    public string? WzwWzorzec { get; set; }

    public string? Gid { get; set; }
}
