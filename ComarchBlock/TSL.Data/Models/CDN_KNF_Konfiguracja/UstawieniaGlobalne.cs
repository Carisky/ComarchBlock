using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class UstawieniaGlobalne
{
    public int UglUglId { get; set; }

    public int? UglOperator { get; set; }

    public string UglNazwa { get; set; } = null!;

    public string UglWartosc { get; set; } = null!;
}
