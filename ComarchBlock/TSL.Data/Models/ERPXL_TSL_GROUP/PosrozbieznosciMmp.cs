using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PosrozbieznosciMmp
{
    public int PrbId { get; set; }

    public short? PrbDokTyp { get; set; }

    public int? PrbDokFirma { get; set; }

    public int? PrbDokNumer { get; set; }

    public short? PrbDokLp { get; set; }

    public int? PrbTwrNumer { get; set; }

    public int? PrbTpaId { get; set; }

    public decimal? PrbIloscWydana { get; set; }

    public string? PrbJmzWydana { get; set; }

    public decimal? PrbIloscPrzyjeta { get; set; }

    public string? PrbJmzPrzyjeta { get; set; }

    public virtual TraNag? PrbDokNumerNavigation { get; set; }

    public virtual TwrPartie? PrbTpa { get; set; }

    public virtual TwrKarty? PrbTwrNumerNavigation { get; set; }
}
