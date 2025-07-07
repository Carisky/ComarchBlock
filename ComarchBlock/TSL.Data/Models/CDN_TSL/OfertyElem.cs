using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class OfertyElem
{
    public int OfLOfLid { get; set; }

    public int OfLOfDid { get; set; }

    public int OfLLp { get; set; }

    public int OfLTwrId { get; set; }

    public string OfLTwrKod { get; set; } = null!;

    public string OfLTwrNazwa { get; set; } = null!;

    public string OfLTwrOpis { get; set; } = null!;

    public int OfLCenyKontrahenta { get; set; }

    public int? OfLAtr1DeAid { get; set; }

    public string OfLAtr1Kod { get; set; } = null!;

    public string OfLAtr1Wartosc { get; set; } = null!;

    public int? OfLAtr2DeAid { get; set; }

    public string OfLAtr2Kod { get; set; } = null!;

    public string OfLAtr2Wartosc { get; set; } = null!;

    public int? OfLAtr3DeAid { get; set; }

    public string OfLAtr3Kod { get; set; } = null!;

    public string OfLAtr3Wartosc { get; set; } = null!;

    public int? OfLAtr4DeAid { get; set; }

    public string OfLAtr4Kod { get; set; } = null!;

    public string OfLAtr4Wartosc { get; set; } = null!;

    public int? OfLAtr5DeAid { get; set; }

    public string OfLAtr5Kod { get; set; } = null!;

    public string OfLAtr5Wartosc { get; set; } = null!;

    public int OfLAtrUtworzony { get; set; }

    public int? OfCTwrId { get; set; }

    public int? OfCKntId { get; set; }

    public byte OfCTypNb { get; set; }

    public decimal OfCCena0 { get; set; }

    public decimal OfCRabat { get; set; }

    public decimal OfCCenaW { get; set; }

    public decimal OfCCena0Wd { get; set; }

    public decimal OfCCenaWwd { get; set; }

    public decimal OfCKosztKgo { get; set; }

    public string OfCWaluta { get; set; } = null!;

    public int OfCKursNumer { get; set; }

    public decimal OfCKursL { get; set; }

    public decimal OfCKursM { get; set; }

    public decimal OfCCenaT { get; set; }

    public decimal OfCIlosc { get; set; }

    public string OfCJm { get; set; } = null!;

    public string OfCJmZ { get; set; } = null!;

    public byte OfCJmCalkowite { get; set; }

    public decimal OfCJmprzelicznikL { get; set; }

    public decimal OfCJmprzelicznikM { get; set; }

    public decimal OfCIloscJm { get; set; }

    public decimal OfCWartoscNetto { get; set; }

    public decimal OfCWartoscBrutto { get; set; }

    public decimal OfCWartoscNettoWal { get; set; }

    public decimal OfCWartoscBruttoWal { get; set; }

    public decimal OfCStawka { get; set; }

    public short OfCFlaga { get; set; }

    public byte OfcCenaZczteremaMiejscami { get; set; }

    public virtual OfertyDok OfLOfD { get; set; } = null!;

    public virtual ICollection<OfertyElemCeny> OfertyElemCenies { get; set; } = new List<OfertyElemCeny>();
}
