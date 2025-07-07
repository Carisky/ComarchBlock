using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktPracownikLimityNieobecnosci
{
    public int? PloPrcGid { get; set; }

    public int PloLimgid { get; set; }

    public int PloId { get; set; }

    public int PloCzdgid { get; set; }

    public int PloZrodgid { get; set; }

    public string PloOrgId { get; set; } = null!;

    public string PloDirtyOrgId { get; set; } = null!;

    public string? PloOpis { get; set; }

    public DateTime PloTsinsert { get; set; }

    public DateTime PloTsupdate { get; set; }

    public int PloUpdateSubTransformationId { get; set; }

    public int? PloUpdateTransformationId { get; set; }

    public int PloInsertSubTransformationId { get; set; }

    public int? PloInsertTransformationId { get; set; }

    public int PloCzdido { get; set; }

    public int PloCzdidwaznyOd { get; set; }

    public int? PloMdodatkowyLimit { get; set; }

    public decimal? PloMnalezneGodziny { get; set; }

    public decimal? PloMnalezneDni { get; set; }

    public decimal? PloMproporcjonalnyDni { get; set; }

    public decimal? PloMproporcjonalnyGodziny { get; set; }

    public decimal? PloMprzeniesienieDni { get; set; }

    public decimal? PloMprzeniesienieGodziny { get; set; }

    public decimal? PloMkorektaDni { get; set; }

    public decimal? PloMkorektaGodziny { get; set; }

    public decimal? PloMnalezneLacznieDni { get; set; }

    public decimal? PloMnalezneLacznieGodziny { get; set; }

    public decimal? PloMwykorzystaneDni { get; set; }

    public decimal? PloMwykorzystaneGodziny { get; set; }

    public decimal? PloMplanowanyDni { get; set; }

    public decimal? PloMplanowanyGodziny { get; set; }

    public decimal? PloMekwiwalentDni { get; set; }

    public decimal? PloMekwiwalentGodziny { get; set; }

    public decimal? PloMpozostaloDni { get; set; }

    public decimal? PloMpozostaloGodziny { get; set; }

    public long? PloMnaZadanie { get; set; }

    public int PloAlokacjaId { get; set; }

    public int PloPerspektywaId { get; set; }

    public int PloBudzetId { get; set; }

    public int PloStrFrmId { get; set; }
}
