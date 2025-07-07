using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DzialZakazy
{
    public int DzaDzaId { get; set; }

    public int DzaDzlId { get; set; }

    public int DzaOpeId { get; set; }

    public byte DzaEdycja { get; set; }

    public byte DzaPodglad { get; set; }

    public byte DzaUsuwanie { get; set; }

    public byte DzaWyplatyInsDel { get; set; }

    public byte DzaWyplatyView { get; set; }

    public byte DzaWyplatyEdit { get; set; }

    public byte DzaDeklaracjeInsDel { get; set; }

    public byte DzaDeklaracjeView { get; set; }

    public byte DzaDeklaracjeEdit { get; set; }

    public byte DzaPracIns { get; set; }

    public byte DzaPracDel { get; set; }

    public byte DzaPracEdit { get; set; }

    public byte DzaPracView { get; set; }

    public byte DzaPracEtat { get; set; }

    public byte DzaPracUmowy { get; set; }

    public byte DzaPracDodatki { get; set; }

    public byte DzaRptKadry { get; set; }

    public byte DzaRptPlace { get; set; }

    public byte DzaPracPlace { get; set; }

    public byte DzaPracKadry { get; set; }

    public byte DzaListyPlac { get; set; }

    public virtual Dzialy DzaDzl { get; set; } = null!;
}
