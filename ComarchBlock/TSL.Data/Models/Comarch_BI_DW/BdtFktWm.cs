using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktWm
{
    public int WmsfProdGid { get; set; }

    public int WmsfOpeepgid { get; set; }

    public int WmsfStrFrmGid { get; set; }

    public int WmsfProjektGid { get; set; }

    public int? WmsfWmsssgid { get; set; }

    public int? WmsfDokNumerErp { get; set; }

    public int WmsfOpegid { get; set; }

    public int WmsfKntGid { get; set; }

    public int? WmsfWmssdgid { get; set; }

    public int WmsfWmsmsgid { get; set; }

    public int? WmsfWmssnadGid { get; set; }

    public int? WmsfWmssgid { get; set; }

    public int? WmsfWmsemzgid { get; set; }

    public int WmsfStrPrwGid { get; set; }

    public int WmsfWmsmgid { get; set; }

    public int? WmsfWmsmcgid { get; set; }

    public int WmsfCzdzgid { get; set; }

    public int WmsfBudzetGid { get; set; }

    public int? WmsfCzdergid { get; set; }

    public int? WmsfCzdewgid { get; set; }

    public int WmsfAlokacjaGid { get; set; }

    public int WmsfKatRynGid { get; set; }

    public int WmsfId { get; set; }

    public int WmsfZrodgid { get; set; }

    public int WmsfCzdgid { get; set; }

    public string WmsfOrgId { get; set; } = null!;

    public string? WmsfDirtyOrgId { get; set; }

    public string? WmsfOpis { get; set; }

    public DateTime WmsfTsinsert { get; set; }

    public DateTime WmsfTsupdate { get; set; }

    public int WmsfUpdateSubTransformationId { get; set; }

    public int? WmsfUpdateTransformationId { get; set; }

    public int WmsfInsertSubTransformationId { get; set; }

    public int? WmsfInsertTransformationId { get; set; }

    public DateTime? WmsfDataRealizacjiElementu { get; set; }

    public DateTime? WmsfDataUtworzeniaElementu { get; set; }

    public int? WmsfDokNumerGid { get; set; }

    public string? WmsfDokumentWms { get; set; }

    public string? WmsfJednostkaLogistyczna { get; set; }

    public string? WmsfJednostkaLogistycznaDocelowa { get; set; }

    public string? WmsfLoginOperatora { get; set; }

    public decimal? WmsfMilosc { get; set; }

    public decimal? WmsfMiloscPoczatkowa { get; set; }

    public decimal? WmsfMiloscZrealizowana { get; set; }

    public decimal? WmsfMprocentRealizacjiPozycji { get; set; }

    public decimal? WmsfMwagaBrutto { get; set; }

    public decimal? WmsfMwagaNetto { get; set; }

    public string? WmsfStatusPozycji { get; set; }

    public string? WmsfStatusPozycjiId { get; set; }

    public string? WmsfTypDyspozycjiId { get; set; }
}
