using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class ProdElem
{
    public int PdEPdEid { get; set; }

    public int PdETrEid { get; set; }

    public int? PdEZwrId { get; set; }

    public short PdELp { get; set; }

    public DateTime PdEDataWys { get; set; }

    public DateTime PdEDataOpe { get; set; }

    public int? PdETwrId { get; set; }

    public int? PdEMagId { get; set; }

    public int? PdETrEidRws { get; set; }

    public decimal PdEIlosc { get; set; }

    public string PdEJm { get; set; } = null!;

    public short PdEJmCalkowite { get; set; }

    public decimal PdEJmprzelicznikL { get; set; }

    public decimal PdEJmprzelicznikM { get; set; }

    public decimal PdEIloscJm { get; set; }

    public decimal PdEWartoscZakupu { get; set; }

    public byte? PdEWyborDostaw { get; set; }

    public byte PdETwrTyp { get; set; }

    public virtual Magazyny? PdEMag { get; set; }

    public virtual TraElem PdETrE { get; set; } = null!;

    public virtual Towary? PdETwr { get; set; }
}
