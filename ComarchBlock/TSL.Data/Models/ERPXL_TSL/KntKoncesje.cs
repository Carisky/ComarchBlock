using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KntKoncesje
{
    public int KkoId { get; set; }

    public short? KkoKntTyp { get; set; }

    public int? KkoKntNumer { get; set; }

    public int? KkoKoncesja { get; set; }

    public int? KkoWaznaDo { get; set; }

    public int? KkoCzasUtworzenia { get; set; }

    public int? KkoOpeUtworzyl { get; set; }

    public int? KkoCzasModyfikacji { get; set; }

    public int? KkoOpeModyfikowal { get; set; }
}
