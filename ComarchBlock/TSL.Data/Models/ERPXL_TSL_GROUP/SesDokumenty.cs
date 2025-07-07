using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SesDokumenty
{
    public int SdoId { get; set; }

    public int SdoLp { get; set; }

    public string? SdoRodzajDokumentu { get; set; }

    public string? SdoNumerDokumentu { get; set; }

    public string? SdoKategoria { get; set; }

    public string? SdoKod { get; set; }

    public string? SdoTypSad { get; set; }
}
