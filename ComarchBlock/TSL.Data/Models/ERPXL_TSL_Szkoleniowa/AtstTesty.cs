using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class AtstTesty
{
    public int AttTestId { get; set; }

    public string? AttNazwaTestu { get; set; }

    public int? AttOpoznienieNag { get; set; }

    public int? AttOpoznienieElem { get; set; }

    public string? AttPlikLog { get; set; }

    public byte? AttAkcjaPoZakonczeniu { get; set; }

    public virtual ICollection<AtstNag> AtstNags { get; set; } = new List<AtstNag>();
}
