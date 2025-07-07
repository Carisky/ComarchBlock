using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktRaportyWizytLraportow
{
    public int RaweId { get; set; }

    public int RaweAlokacjaId { get; set; }

    public int RaweRawid { get; set; }

    public int? RaweEktid { get; set; }

    public decimal? RaweMobecny { get; set; }

    public decimal? RaweMfacing { get; set; }

    public decimal? RaweMcena { get; set; }

    public decimal? RaweMilosc { get; set; }

    public DateTime RaweTsupdate { get; set; }

    public DateTime RaweTsinsert { get; set; }

    public int? RaweInsertSubTransformationId { get; set; }

    public int RaweInsertTransformationId { get; set; }

    public int? RaweUpdateSubTransformationId { get; set; }

    public int RaweUpdateTransformationId { get; set; }

    public string? RaweOpis { get; set; }

    public string RaweDirtyOrgId { get; set; } = null!;

    public string RaweOrgId { get; set; } = null!;

    public int RaweCzdgid { get; set; }

    public int RaweZrodgid { get; set; }

    public int RaweBudzetId { get; set; }

    public int RaweProdId { get; set; }

    public int RaweRejonid { get; set; }

    public int RaweSamid { get; set; }

    public int RaweCzdid { get; set; }

    public int RaweWelId { get; set; }

    public int RaweWzwId { get; set; }

    public int RaweKntId { get; set; }

    public int RawePrcId { get; set; }
}
