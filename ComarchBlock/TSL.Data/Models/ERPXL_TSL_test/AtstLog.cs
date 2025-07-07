using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class AtstLog
{
    public int AtlId { get; set; }

    public string? AtlKomputer { get; set; }

    public string? AtlData { get; set; }

    public int? AtlCzas { get; set; }

    public string? AtlStatus { get; set; }

    public int? AtlBlad { get; set; }

    public int? AtlZagniezdzenie { get; set; }

    public short? AtlDokumentTyp { get; set; }

    public string? AtlDokumentNumer { get; set; }

    public int? AtlIloscDokumentow { get; set; }

    public int? AtlIloscPozycji { get; set; }
}
