using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktPromocjeLimitowane
{
    public int PrmltStrFrmGid { get; set; }

    public int PrmltFormPlatGid { get; set; }

    public int PrmltMagGid { get; set; }

    public int PrmltStrPrwGid { get; set; }

    public int PrmltOpemgid { get; set; }

    public int PrmltOpewgid { get; set; }

    public int PrmltDocKntGid { get; set; }

    public int PrmltLtgid { get; set; }

    public int PrmltPlatGid { get; set; }

    public int PrmltRdzgid { get; set; }

    public int PrmltJmGid { get; set; }

    public int PrmltAlokacjaGid { get; set; }

    public int PrmltBudzetGid { get; set; }

    public int PrmltProdGid { get; set; }

    public int PrmltFirmaGid { get; set; }

    public int PrmltCechaGid { get; set; }

    public int PrmltWalutaGid { get; set; }

    public int PrmltKntGid { get; set; }

    public int PrmltPrmGid { get; set; }

    public int PrmltDokNumerGid { get; set; }

    public int PrmltOpezgid { get; set; }

    public int PrmltOpegid { get; set; }

    public int PrmltId { get; set; }

    public int PrmltZrodgid { get; set; }

    public int PrmltCzdgid { get; set; }

    public string PrmltOrgId { get; set; } = null!;

    public string PrmltDirtyOrgId { get; set; } = null!;

    public string? PrmltOpis { get; set; }

    public DateTime PrmltTsinsert { get; set; }

    public DateTime PrmltTsupdate { get; set; }

    public int PrmltUpdateSubTransformationId { get; set; }

    public int? PrmltUpdateTransformationId { get; set; }

    public int PrmltInsertSubTransformationId { get; set; }

    public int? PrmltInsertTransformationId { get; set; }

    public int? PrmltPaczka { get; set; }

    public int? PrmltCzyNagl { get; set; }

    public decimal? PrmltMlimit { get; set; }

    public decimal? PrmltMwykorzystanyLimit { get; set; }

    public decimal? PrmltMpozostaje { get; set; }
}
