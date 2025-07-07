using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPaczki
{
    public int PczId { get; set; }

    public int PczZrodgid { get; set; }

    public int PczCzdgid { get; set; }

    public string PczOrgId { get; set; } = null!;

    public string PczDirtyOrgId { get; set; } = null!;

    public string? PczOpis { get; set; }

    public int? PczUpdateTransformationId { get; set; }

    public int PczUpdateSubTransformationId { get; set; }

    public int? PczInsertTransformationId { get; set; }

    public int PczInsertSubTransformationId { get; set; }

    public DateTime PczTsinsert { get; set; }

    public DateTime PczTsupdate { get; set; }

    public int PczAlokacjaGid { get; set; }

    public int PczBudzetGid { get; set; }

    public int PczWysygid { get; set; }

    public int PczTragid { get; set; }

    public int PczDokNumerGid { get; set; }

    public int PczAdrGid { get; set; }

    public int PczKntDostGid { get; set; }

    public int PczProdGid { get; set; }

    public int PczKntDokGid { get; set; }

    public int PczPaczgid { get; set; }

    public int PczOsogid { get; set; }

    public decimal? PczMdlugosc { get; set; }

    public decimal? PczMszerokosc { get; set; }

    public decimal? PczMwysokosc { get; set; }

    public decimal? PczMwagaNetto { get; set; }

    public decimal? PczMwagaBrutto { get; set; }

    public decimal? PczMobjetosc { get; set; }

    public decimal? PczMnettoWartosc { get; set; }

    public decimal? PczMbruttoWartosc { get; set; }

    public decimal? PczMkoszt { get; set; }

    public decimal? PczMilosc { get; set; }

    public int PczDokNumerPaczkiGid { get; set; }

    public int PczDokNumerWysylkiGid { get; set; }

    public int PczStrPrwGid { get; set; }
}
