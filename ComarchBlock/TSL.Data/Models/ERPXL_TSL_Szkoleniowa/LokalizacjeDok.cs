using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class LokalizacjeDok
{
    public int LoDId { get; set; }

    public short? LoDDokTyp { get; set; }

    public int? LoDDokFirma { get; set; }

    public int? LoDDokNumer { get; set; }

    public short? LoDDokLp { get; set; }

    public string? LoDUrl { get; set; }

    public string? LoDOpis { get; set; }

    public virtual SrsObiekty? LoDDokNumerNavigation { get; set; }
}
