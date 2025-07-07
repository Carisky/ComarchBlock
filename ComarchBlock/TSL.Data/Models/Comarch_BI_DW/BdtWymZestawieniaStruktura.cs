using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymZestawieniaStruktura
{
    public int ZszRowId { get; set; }

    public int ZszId { get; set; }

    public int ZszZrodgid { get; set; }

    public string ZszOrgId { get; set; } = null!;

    public string ZszDirtyOrgId { get; set; } = null!;

    public string? ZszNazwa { get; set; }

    public string? ZszOpis { get; set; }

    public string? ZszParDirtyOrgId { get; set; }

    public string? ZszParCleanOrgId { get; set; }

    public int? ZszParGid { get; set; }

    public DateTime ZszTsinsert { get; set; }

    public DateTime ZszTsupdate { get; set; }

    public DateTime ZszTimeFrom { get; set; }

    public DateTime? ZszTimeTo { get; set; }

    public int ZszChecksumKimball1 { get; set; }

    public int ZszChecksumKimball2 { get; set; }

    public int ZszUpdateSubTransformationId { get; set; }

    public int? ZszUpdateTransformationId { get; set; }

    public int ZszInsertSubTransformationId { get; set; }

    public int? ZszInsertTransformationId { get; set; }

    public byte[] ZszRowVersion { get; set; } = null!;

    public int? ZszAktywny { get; set; }

    public string? ZszNumeracja { get; set; }

    public string? ZszPoziom { get; set; }

    public int? ZszPoziomNr { get; set; }

    public string? ZszPozycjaChar { get; set; }

    public decimal? ZszPozycjaNr { get; set; }

    public string? ZszRodzaj { get; set; }

    public string? ZszZestawienie { get; set; }

    public int? ZszZknNumer { get; set; }

    public int? BudgetMemberId { get; set; }

    public virtual WymZrodloDanych ZszZrodg { get; set; } = null!;
}
