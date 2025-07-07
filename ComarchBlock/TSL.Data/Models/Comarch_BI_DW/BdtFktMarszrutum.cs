using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktMarszrutum
{
    public int PmrszAlokacjaGid { get; set; }

    public int PmrszDataZamknieciaDokGid { get; set; }

    public int PmrszDokNumerGid { get; set; }

    public int PmrszPfugid { get; set; }

    public int PmrszZasgid { get; set; }

    public int PmrszBudzetGid { get; set; }

    public int PmrszOddgniazdoGid { get; set; }

    public int PmrszJczgid { get; set; }

    public int PmrszOddzasobGid { get; set; }

    public int PmrszProjektGid { get; set; }

    public int PmrszStrFrmGid { get; set; }

    public int PmrszKntGid { get; set; }

    public int PmrszCzngid { get; set; }

    public int PrmszTzakonRzeczZasobuCzdgid { get; set; }

    public int PrmszTrozRzeczZasobuCzdgid { get; set; }

    public int PrmszTzakonPlanCzynnosciCzdgid { get; set; }

    public int PmrszKntDocGid { get; set; }

    public int PrmszTzakonPlanZasobuCzdgid { get; set; }

    public int PrmszTrozPlanZasobuCzdgid { get; set; }

    public int PmrszTchgid { get; set; }

    public int PmrszProdGid { get; set; }

    public int PmrszOddzpgid { get; set; }

    public int PrmszTrozPlanCzynnosciCzdgid { get; set; }

    public int PrmszTzakonRzeczCzynnosciCzdgid { get; set; }

    public int PmrszTrozRzeczCzynnosciCzdgid { get; set; }

    public int PmrszId { get; set; }

    public int PmrszBudzetId { get; set; }

    public int PmrszCzdgid { get; set; }

    public int PmrszZrodgid { get; set; }

    public string PmrszOrgId { get; set; } = null!;

    public string PmrszDirtyOrgId { get; set; } = null!;

    public string? PmrszOpis { get; set; }

    public DateTime PmrszTsinsert { get; set; }

    public DateTime PmrszTsupdate { get; set; }

    public int PmrszUpdateSubTransformationId { get; set; }

    public int? PmrszUpdateTransformationId { get; set; }

    public int PmrszInsertSubTransformationId { get; set; }

    public int? PmrszInsertTransformationId { get; set; }

    public int? PmrszMczasRealizacjiRzeczywistyZasobu { get; set; }

    public int? PmrszMczasRealizacjiPlanowanyZasobu { get; set; }

    public int? PmrszMczasRozliczeniowyRzeczywistyZasobu { get; set; }

    public int? PmrszMczasRozliczeniowyPlanowanyZasobu { get; set; }

    public int? PmrszMczasRealizacjiRzeczywistyCzynnosci { get; set; }

    public int? PmrszMczasRealizacjiPlanowanyCzynnosci { get; set; }

    public int? PmrszMczasRozliczeniowyRzeczywistyCzynnosci { get; set; }

    public int? PmrszMczasRozliczeniowyPlanowanyCzynnosci { get; set; }

    public int? PmrszMwzorcowyCzas { get; set; }

    public int? PmrszTerminOd { get; set; }

    public int? PmrszTerminDo { get; set; }

    public int PmrszCzdaktywnosciOdId { get; set; }

    public int PmrszCzdaktywnosciDoId { get; set; }
}
