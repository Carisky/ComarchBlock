using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class AtrybutyKlasyAltumView
{
    public string AtkNazwa { get; set; } = null!;

    public byte AtkTyp { get; set; }

    public string AtkFormat { get; set; } = null!;

    public byte AtkNieaktywny { get; set; }

    public string? AtkImportRowId { get; set; }

    public byte AtkSynchronizowanyAltum { get; set; }
}
