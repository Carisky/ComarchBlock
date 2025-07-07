using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class ProdSkladniki
{
    public int PdSPdSid { get; set; }

    public int PdSPdRid { get; set; }

    public int PdSProdId { get; set; }

    public int? PdSTwrId { get; set; }

    public int? PdSMagId { get; set; }

    public decimal PdSIlosc { get; set; }

    public string PdSJm { get; set; } = null!;

    public byte PdSJmcalkowite { get; set; }

    public decimal PdSJmprzelicznikL { get; set; }

    public decimal PdSJmprzelicznikM { get; set; }

    public decimal PdSIloscJm { get; set; }

    public int? PdSLp { get; set; }

    public virtual Magazyny? PdSMag { get; set; }

    public virtual ProdReceptury PdSPdR { get; set; } = null!;

    public virtual Towary? PdSTwr { get; set; }
}
