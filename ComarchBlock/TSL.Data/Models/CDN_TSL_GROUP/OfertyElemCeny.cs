using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class OfertyElemCeny
{
    public int OfCOfCid { get; set; }

    public int? OfCOfLid { get; set; }

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

    public virtual OfertyElem? OfCOfL { get; set; }
}
