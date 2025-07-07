using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class UstawieniaCustomizacji
{
    public int UcuUcuId { get; set; }

    public int UcuWidok { get; set; }

    public int UcuUstawienie { get; set; }

    public int? UcuOperator { get; set; }

    public string UcuNazwa { get; set; } = null!;

    public string UcuWartosc { get; set; } = null!;
}
