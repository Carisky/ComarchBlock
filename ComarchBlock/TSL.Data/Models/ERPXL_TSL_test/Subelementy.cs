using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Subelementy
{
    public int? Idpaczki { get; set; }

    public decimal? ProcentZsubelementow { get; set; }

    public int? KsprCzdOrgId { get; set; }

    public string? KsprOrgId { get; set; }

    public string? KsprDokNumerOrgId { get; set; }

    public string? KsprDokWysylkiOrgId { get; set; }

    public int? KsprPozycjaOrgId { get; set; }

    public int? KsprSubPozycjaOrgId { get; set; }
}
