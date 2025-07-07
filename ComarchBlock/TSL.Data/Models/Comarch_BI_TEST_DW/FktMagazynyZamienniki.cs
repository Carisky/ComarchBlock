using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktMagazynyZamienniki
{
    public string MgrOrgId { get; set; } = null!;

    public int MgrZrodgid { get; set; }

    public int? MgrCzdid { get; set; }

    public int? MgrCzmid { get; set; }

    public int MgrDstId { get; set; }

    public int MgrMagId { get; set; }

    public int MgrJmId { get; set; }

    public int MgrKntId { get; set; }

    public int MgrFirmaId { get; set; }

    public int MgrJmPid { get; set; }

    public int? MgrCechaId { get; set; }

    public int MgrStrFrmId { get; set; }

    public int MgrProjektId { get; set; }

    public int? MgrProdId { get; set; }

    public int MgrBudzetId { get; set; }

    public int MgrAlokacjaId { get; set; }

    public int MgrLokId { get; set; }

    public decimal? MgrMiloscKsRuchPomoc { get; set; }

    public decimal? MgrMiloscKsRuchPodst { get; set; }

    public decimal? MgrMkoszt { get; set; }

    public decimal? MgrMiloscMagRuch { get; set; }

    public decimal? MgrMstanIlosc { get; set; }

    public decimal? MgrMstanIloscPom { get; set; }

    public decimal? MgrMstanWartosc { get; set; }

    public decimal? MgrMstanIloscBie { get; set; }

    public decimal? MgrMstanIloscPomBie { get; set; }

    public decimal? MgrMstanWartoscBie { get; set; }

    public decimal? MgrMstanMagIlosc { get; set; }

    public decimal? MgrMstanMagIloscBie { get; set; }

    public int MgrPrmgid { get; set; }
}
