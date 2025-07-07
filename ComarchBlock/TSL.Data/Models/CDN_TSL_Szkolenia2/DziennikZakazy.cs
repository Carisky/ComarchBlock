using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DziennikZakazy
{
    public int DzZDzZid { get; set; }

    public int DzZDziId { get; set; }

    public int DzZOpeId { get; set; }

    public byte DzZDodawanie { get; set; }

    public byte DzZPodglad { get; set; }

    public byte DzZZmianaWlas { get; set; }

    public byte DzZZmianaInne { get; set; }

    public byte DzZKasowanieWlas { get; set; }

    public byte DzZKasowanieInne { get; set; }

    public virtual Dzienniki DzZDzi { get; set; } = null!;
}
