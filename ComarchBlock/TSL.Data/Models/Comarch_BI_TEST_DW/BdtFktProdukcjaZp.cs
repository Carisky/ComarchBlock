using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktProdukcjaZp
{
    public int PzpCzdzakGid { get; set; }

    public int PzpMagGid { get; set; }

    public int PzpDokNumerZp { get; set; }

    public int PzpDokNumerPw { get; set; }

    public int PzpDokNumerRw { get; set; }

    public int PzpOddgid { get; set; }

    public int PzpMatGid { get; set; }

    public int PzpProdGid { get; set; }

    public int PzpKntGid { get; set; }

    public int PzpTchgid { get; set; }

    public int PzpKntDocGid { get; set; }

    public int PzpPpcgid { get; set; }

    public int PzpLokGid { get; set; }

    public int PzpAlokacjaGid { get; set; }

    public int PzpCzdrozpGid { get; set; }

    public int PzpBudzetGid { get; set; }

    public int PzpProjektGid { get; set; }

    public int PzpStrFrmGid { get; set; }

    public int PzpCzngid { get; set; }

    public int PzpRodzKosztGid { get; set; }

    public int PzpId { get; set; }

    public int PzpCzdgid { get; set; }

    public int PzpZrodgid { get; set; }

    public string PzpOrgId { get; set; } = null!;

    public string PzpDirtyOrgId { get; set; } = null!;

    public string? PzpOpis { get; set; }

    public DateTime PzpTsinsert { get; set; }

    public DateTime PzpTsupdate { get; set; }

    public int PzpUpdateSubTransformationId { get; set; }

    public int? PzpUpdateTransformationId { get; set; }

    public int PzpInsertSubTransformationId { get; set; }

    public int? PzpInsertTransformationId { get; set; }

    public decimal? PzpIloscMatZp { get; set; }

    public decimal? PzpIloscMatDok { get; set; }

    public decimal? PzpIloscMatTech { get; set; }

    public decimal? PzpIloscProdZp { get; set; }

    public decimal? PzpIloscProdDok { get; set; }

    public decimal? PzpIloscProdTech { get; set; }

    public decimal? PzpKosztMatZp { get; set; }

    public decimal? PzpKosztMatDok { get; set; }

    public decimal? PzpKosztMatTech { get; set; }

    public decimal? PzpKosztCalkowity { get; set; }

    public decimal? PzpKosztProdDok { get; set; }

    public int PzpKprdgid { get; set; }

    public int PzpRdzubgid { get; set; }

    public int PzpStrPrwGid { get; set; }

    public int PzpMagGidpw { get; set; }

    public string? PzpOrgAtrNagId { get; set; }

    public string? PzpOrgAtrEleId { get; set; }

    public int PzpPartgid { get; set; }

    public int PzpJpom { get; set; }

    public string? PzpOrgAtrId { get; set; }

    public int PzpDokNumerNadZlec { get; set; }

    public decimal? PzpIloscProdDokJmp { get; set; }

    public decimal? PzpIloscProdZpjmp { get; set; }

    public decimal? PzpIloscProdTechJmp { get; set; }

    public int PzpCzdzamknieciaGid { get; set; }

    public decimal? PzpIloscProdPlan { get; set; }

    public int PzpCzdwystGid { get; set; }

    public int PzpCzdaktywnosciDoId { get; set; }

    public int PzpCzdaktywnosciOdId { get; set; }
}
