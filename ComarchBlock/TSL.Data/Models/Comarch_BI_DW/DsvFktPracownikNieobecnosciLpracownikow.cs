using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktPracownikNieobecnosciLpracownikow
{
    public int? PnoPrcGid { get; set; }

    public int PnoNobgid { get; set; }

    public int PnoId { get; set; }

    public int PnoCzdgid { get; set; }

    public int PnoZrodgid { get; set; }

    public string PnoOrgId { get; set; } = null!;

    public string PnoDirtyOrgId { get; set; } = null!;

    public string? PnoOpis { get; set; }

    public DateTime PnoTsinsert { get; set; }

    public DateTime PnoTsupdate { get; set; }

    public int PnoUpdateSubTransformationId { get; set; }

    public int? PnoUpdateTransformationId { get; set; }

    public int PnoInsertSubTransformationId { get; set; }

    public int? PnoInsertTransformationId { get; set; }

    public int? PnoMliczbaDni { get; set; }

    public decimal? PnoMliczbaGodzin { get; set; }

    public int? PnoCzdgiddo { get; set; }

    public int? PnoMusprawiedliwione { get; set; }

    public int? PnoMnieusprawiedliwione { get; set; }

    public int? PnoMurlop { get; set; }

    public int? PnoMzwolnienieZus { get; set; }

    public int? PnoMnaZadanie { get; set; }

    public int PnoAlokacjaId { get; set; }

    public int PnoBudzetId { get; set; }

    public int PnoPerspektywaId { get; set; }

    public int PnoStrFrmId { get; set; }

    public int PnoCzdgidod { get; set; }
}
