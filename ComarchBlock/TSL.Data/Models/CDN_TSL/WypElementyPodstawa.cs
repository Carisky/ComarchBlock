using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class WypElementyPodstawa
{
    public int WepWepId { get; set; }

    public int? WepWpeId { get; set; }

    public int WepPraId { get; set; }

    public string WepNazwa { get; set; } = null!;

    public string WepNumerPelny { get; set; } = null!;

    public byte WepWlicz { get; set; }

    public byte WepWliczMetoda { get; set; }

    public byte WepRodzajElem { get; set; }

    public decimal WepKwota1 { get; set; }

    public decimal WepKwota2 { get; set; }

    public decimal WepWspolczynnik { get; set; }

    public decimal WepKwota3 { get; set; }

    public string WepGodzDni { get; set; } = null!;

    public DateTime? WepNormaGodz { get; set; }

    public int? WepIloscMies { get; set; }

    public DateTime? WepOkresOd { get; set; }

    public DateTime? WepOkresDo { get; set; }

    public int? WepParentId { get; set; }

    public decimal WepStawkaGodz { get; set; }

    public decimal WepProcentWalor { get; set; }

    public string? WepImportRowId { get; set; }

    public virtual WypElementy? WepWpe { get; set; }

    public virtual ICollection<WypElementyPodstawaElem> WypElementyPodstawaElems { get; set; } = new List<WypElementyPodstawaElem>();
}
