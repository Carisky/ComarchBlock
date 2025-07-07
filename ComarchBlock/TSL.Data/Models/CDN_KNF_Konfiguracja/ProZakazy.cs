using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class ProZakazy
{
    public int PzaPzaId { get; set; }

    public int? PzaOpeId { get; set; }

    public int? PzaProcId { get; set; }

    public byte PzaMaskaFormy { get; set; }

    public virtual Operatorzy? PzaOpe { get; set; }
}
