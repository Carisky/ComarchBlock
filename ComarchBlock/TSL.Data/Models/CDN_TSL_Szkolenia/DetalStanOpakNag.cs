using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DetalStanOpakNag
{
    public int DsonDsonid { get; set; }

    public int DsonOptimaId { get; set; }

    public byte DsonNieaktywny { get; set; }

    public string DsonKod { get; set; } = null!;

    public string DsonNazwa { get; set; } = null!;

    public int DsonStanDetalId { get; set; }

    public DateTime DsonTsMod { get; set; }

    public virtual ICollection<DetalStanOpakElem> DetalStanOpakElems { get; set; } = new List<DetalStanOpakElem>();
}
