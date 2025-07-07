using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktProdukcjaZleceniaKoszty
{
    public int? PrzCzdzakId { get; set; }

    public int PzkAlokacjaId { get; set; }

    public int? PzkBudzetId { get; set; }

    public int PzkCzdanId { get; set; }

    public int? PzkCzdid { get; set; }

    public int? PzkCzdplanWproId { get; set; }

    public int? PzkCzdplanZakId { get; set; }

    public int PzkCzdprzypisaniaKosztuId { get; set; }

    public int? PzkCzdwproId { get; set; }

    public string PzkDirtyOrgId { get; set; } = null!;

    public int? PzkDokNumerId { get; set; }

    public int PzkZamDokNumerId { get; set; }

    public int? PzkFirmaId { get; set; }

    public long PzkId { get; set; }

    public int? PzkInsertSubTransformationId { get; set; }

    public int PzkInsertTransformationId { get; set; }

    public int PzkKatFinId { get; set; }

    public int? PzkKierunek { get; set; }

    public int? PzkKndId { get; set; }

    public int? PzkKntId { get; set; }

    public int? PzkLokId { get; set; }

    public decimal? PzkMkosztRealizacji { get; set; }

    public decimal? PzkMkosztRealizacjiMat { get; set; }

    public int PzkOddid { get; set; }

    public string? PzkOpis { get; set; }

    public string? PzkOrgAtrId { get; set; }

    public string PzkOrgId { get; set; } = null!;

    public string? PzkOrgWymId { get; set; }

    public int? PzkProdId { get; set; }

    public int? PzkProjektId { get; set; }

    public int? PzkRejonId { get; set; }

    public int? PzkRodzKosztId { get; set; }

    public int? PzkStpid { get; set; }

    public int? PzkStrFrmId { get; set; }

    public int PzkTchid { get; set; }

    public DateTime PzkTsinsert { get; set; }

    public DateTime PzkTsupdate { get; set; }

    public int? PzkTypKwoty { get; set; }

    public int? PzkUpdateSubTransformationId { get; set; }

    public int PzkUpdateTransformationId { get; set; }

    public int? PzkWymObjGidLp { get; set; }

    public int PzkZrodgid { get; set; }
}
