using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymSamochod
{
    public int SamId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? SamRowId { get; set; }

    public string? SamBadaniaDataWaznosci { get; set; }

    public string? SamPolisaDataWaznosci { get; set; }

    public string? SamPolisa { get; set; }

    public int? SamRokProdukcji { get; set; }

    public string? SamLadownosc { get; set; }

    public string? SamMarka { get; set; }

    public string? SamNrRejestracyjny { get; set; }

    public byte[] SamRowVersion { get; set; } = null!;

    public int? SamInsertSubTransformationId { get; set; }

    public int SamInsertTransformationId { get; set; }

    public int? SamUpdateSubTransformationId { get; set; }

    public int SamUpdateTransformationId { get; set; }

    public int SamChecksumKimball2 { get; set; }

    public int SamChecksumKimball1 { get; set; }

    public DateTime? SamTimeTo { get; set; }

    public DateTime SamTimeFrom { get; set; }

    public DateTime SamTsupdate { get; set; }

    public DateTime SamTsinsert { get; set; }

    public int? SamParGid { get; set; }

    public string? SamParCleanOrgId { get; set; }

    public string? SamParDirtyOrgId { get; set; }

    public string? SamOpis { get; set; }

    public string SamNazwa { get; set; } = null!;

    public string SamDirtyOrgId { get; set; } = null!;

    public string SamOrgId { get; set; } = null!;

    public int SamZrodgid { get; set; }

    public string? SamOrgAtrId { get; set; }
}
