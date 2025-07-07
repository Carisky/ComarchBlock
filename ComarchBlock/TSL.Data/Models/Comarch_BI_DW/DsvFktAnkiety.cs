using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktAnkiety
{
    public int AntAlokacjaId { get; set; }

    public int AntAnkid { get; set; }

    public int AntBudzetId { get; set; }

    public int AntCrmetapId { get; set; }

    public int AntCzdgid { get; set; }

    public string AntDirtyOrgId { get; set; } = null!;

    public int AntId { get; set; }

    public int AntInsertSubTransformationId { get; set; }

    public int? AntInsertTransformationId { get; set; }

    public int AntKntId { get; set; }

    public string? AntMlank { get; set; }

    public int? AntModpowiedz { get; set; }

    public decimal? AntMpunktacja { get; set; }

    public int AntOdpid { get; set; }

    public string? AntOpis { get; set; }

    public string AntOrgId { get; set; } = null!;

    public int AntPrcId { get; set; }

    public int AntProdId { get; set; }

    public int AntPytid { get; set; }

    public DateTime AntTsinsert { get; set; }

    public DateTime AntTsupdate { get; set; }

    public int AntUpdateSubTransformationId { get; set; }

    public int? AntUpdateTransformationId { get; set; }

    public int AntWelId { get; set; }

    public int AntWzwId { get; set; }

    public int AntZrodgid { get; set; }
}
