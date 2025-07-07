using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Teryt
{
    public int TrtTrtId { get; set; }

    public string TrtNazwa { get; set; } = null!;

    public short TrtWojewodztwo { get; set; }

    public short? TrtPowiat { get; set; }

    public short? TrtGmina { get; set; }
}
