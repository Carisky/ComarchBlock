using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SrsCyklElem
{
    public int SrESrEid { get; set; }

    public int SrESrWid { get; set; }

    public int SrETyp { get; set; }

    public int SrELp { get; set; }

    public int? SrETwrId { get; set; }

    public int? SrEKatId { get; set; }

    public string SrETwrKod { get; set; } = null!;

    public string SrETwrNazwa { get; set; } = null!;

    public string SrETwrEan { get; set; } = null!;

    public string SrEOpis { get; set; } = null!;

    public byte SrEFakturowac { get; set; }

    public byte SrETypCeny { get; set; }

    public byte SrECenaZczteremaMiejscami { get; set; }

    public decimal SrECenaNetto { get; set; }

    public decimal SrECenaBrutto { get; set; }

    public decimal SrEIlosc { get; set; }

    public decimal SrEIloscJm { get; set; }

    public string SrEJm { get; set; } = null!;

    public string SrEJmz { get; set; } = null!;

    public decimal SrEJmprzelicznikL { get; set; }

    public int SrEJmprzelicznikM { get; set; }

    public decimal SrEWartoscNetto { get; set; }

    public decimal SrEWartoscBrutto { get; set; }

    public int? SrESerwisantTyp { get; set; }

    public int? SrESerwisantId { get; set; }

    public int? SrEMagId { get; set; }

    public int? SrEAtr1DeAid { get; set; }

    public string SrEAtr1Kod { get; set; } = null!;

    public string SrEAtr1Wartosc { get; set; } = null!;

    public int? SrEAtr2DeAid { get; set; }

    public string SrEAtr2Kod { get; set; } = null!;

    public string SrEAtr2Wartosc { get; set; } = null!;

    public int? SrEAtr3DeAid { get; set; }

    public string SrEAtr3Kod { get; set; } = null!;

    public string SrEAtr3Wartosc { get; set; } = null!;

    public int? SrEAtr4DeAid { get; set; }

    public string SrEAtr4Kod { get; set; } = null!;

    public string SrEAtr4Wartosc { get; set; } = null!;

    public int? SrEAtr5DeAid { get; set; }

    public string SrEAtr5Kod { get; set; } = null!;

    public string SrEAtr5Wartosc { get; set; } = null!;

    public int SrEUstawAtrSql { get; set; }

    public virtual Kategorie? SrEKat { get; set; }

    public virtual SrsCyklNag SrESrW { get; set; } = null!;
}
