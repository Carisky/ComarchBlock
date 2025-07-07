using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class SrsCzynnosci
{
    public int SrYSrYid { get; set; }

    public int SrYSrZid { get; set; }

    public int SrYLp { get; set; }

    public int? SrYTwrId { get; set; }

    public int? SrYKatId { get; set; }

    public string SrYTwrKod { get; set; } = null!;

    public string SrYTwrNazwa { get; set; } = null!;

    public string SrYTwrEan { get; set; } = null!;

    public string SrYOpis { get; set; } = null!;

    public int SrYSerwisantTyp { get; set; }

    public int SrYSerwisantId { get; set; }

    public byte SrYZakonczona { get; set; }

    public byte SrYFakturowac { get; set; }

    public int SrYDokument { get; set; }

    public byte SrYRealizacja { get; set; }

    public byte SrYPoprzedniaOk { get; set; }

    public DateTime? SrYDataWykonania { get; set; }

    public DateTime SrYTerminOd { get; set; }

    public DateTime SrYTerminDo { get; set; }

    public byte SrYRezerwujCzas { get; set; }

    public byte SrYPrzypomnienie { get; set; }

    public DateTime SrYCzasPrzypomnienia { get; set; }

    public DateTime SrYCzasTrwania { get; set; }

    public int? SrYCzasTrwaniaInt { get; set; }

    public int SrYTwCnumer { get; set; }

    public byte SrYCenaZczteremaMiejscami { get; set; }

    public decimal SrYCena0 { get; set; }

    public decimal SrYRabat { get; set; }

    public decimal SrYCenaNetto { get; set; }

    public decimal SrYCenaBrutto { get; set; }

    public decimal SrYIlosc { get; set; }

    public decimal SrYIloscDisp { get; set; }

    public decimal SrYIloscJm { get; set; }

    public string SrYJm { get; set; } = null!;

    public string SrYJmz { get; set; } = null!;

    public decimal SrYJmprzelicznikL { get; set; }

    public int SrYJmprzelicznikM { get; set; }

    public decimal SrYWartoscNetto { get; set; }

    public decimal SrYWartoscBrutto { get; set; }

    public decimal SrYWartoscNettoWylicz { get; set; }

    public decimal SrYWartoscBruttoWylicz { get; set; }

    public decimal SrYKosztUslugi { get; set; }

    public decimal SrYCena0Pln { get; set; }

    public decimal SrYCenaNettoPln { get; set; }

    public decimal SrYCenaBruttoPln { get; set; }

    public decimal SrYWartoscNettoPln { get; set; }

    public decimal SrYWartoscBruttoPln { get; set; }

    public string SrYWaluta { get; set; } = null!;

    public decimal SrYStawka { get; set; }

    public short SrYFlagaVat { get; set; }

    public decimal SrYZrodlowa { get; set; }

    public byte SrYStawkaOss { get; set; }

    public int? SrYAtr1DeAid { get; set; }

    public string SrYAtr1Kod { get; set; } = null!;

    public string SrYAtr1Wartosc { get; set; } = null!;

    public int? SrYAtr2DeAid { get; set; }

    public string SrYAtr2Kod { get; set; } = null!;

    public string SrYAtr2Wartosc { get; set; } = null!;

    public int? SrYAtr3DeAid { get; set; }

    public string SrYAtr3Kod { get; set; } = null!;

    public string SrYAtr3Wartosc { get; set; } = null!;

    public int? SrYAtr4DeAid { get; set; }

    public string SrYAtr4Kod { get; set; } = null!;

    public string SrYAtr4Wartosc { get; set; } = null!;

    public int? SrYAtr5DeAid { get; set; }

    public string SrYAtr5Kod { get; set; } = null!;

    public string SrYAtr5Wartosc { get; set; } = null!;

    public int SrYUstawAtrSql { get; set; }

    public virtual Kategorie? SrYKat { get; set; }

    public virtual SrsZlecenium SrYSrZ { get; set; } = null!;
}
