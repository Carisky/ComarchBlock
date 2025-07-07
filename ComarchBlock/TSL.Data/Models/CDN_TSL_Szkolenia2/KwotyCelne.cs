using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KwotyCelne
{
    public int KceKceId { get; set; }

    public string KceNazwa { get; set; } = null!;

    public short KceImport { get; set; }

    public short KceWnt { get; set; }

    public short KceWplywNaWartoscVat { get; set; }

    public short KceWplywNaPlatnosc { get; set; }
}
