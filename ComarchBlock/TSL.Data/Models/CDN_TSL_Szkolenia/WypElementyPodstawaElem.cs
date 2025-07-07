using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class WypElementyPodstawaElem
{
    public int WeeWeeId { get; set; }

    public int WeeWepId { get; set; }

    public string WeeNazwa { get; set; } = null!;

    public string WeeNumerPelny { get; set; } = null!;

    public byte WeeWlicz { get; set; }

    public byte WeeWliczMetoda { get; set; }

    public byte WeeRodzajElem { get; set; }

    public decimal WeeKwota1 { get; set; }

    public decimal WeeKwota2 { get; set; }

    public string WeeWspolczynnik { get; set; } = null!;

    public decimal WeeKwota3 { get; set; }

    public string WeeGodzDni { get; set; } = null!;

    public DateTime? WeeOkresOd { get; set; }

    public DateTime? WeeOkresDo { get; set; }

    public int WeeIloscMies { get; set; }

    public string? WeeImportRowId { get; set; }

    public virtual WypElementyPodstawa WeeWep { get; set; } = null!;
}
