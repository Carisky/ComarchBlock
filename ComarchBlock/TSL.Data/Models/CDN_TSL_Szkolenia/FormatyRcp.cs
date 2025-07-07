using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class FormatyRcp
{
    public int ForForId { get; set; }

    public string ForKatalog { get; set; } = null!;

    public byte ForNieaktywny { get; set; }

    public byte ForRodzajImportu { get; set; }

    public byte ForWgObecnosci { get; set; }

    public string ForNazwa { get; set; } = null!;

    public string ForFormat { get; set; } = null!;

    public string ForWejscie { get; set; } = null!;

    public int? ForWejscieDstId { get; set; }

    public byte ForWeWyStrefaPlan { get; set; }

    public string ForWyjscie { get; set; } = null!;

    public string ForWejscieSluzb { get; set; } = null!;

    public int? ForWejscieSluzbDstId { get; set; }

    public string ForWyjscieSluzb { get; set; } = null!;

    public byte ForWeWySstrefaPlan { get; set; }
}
