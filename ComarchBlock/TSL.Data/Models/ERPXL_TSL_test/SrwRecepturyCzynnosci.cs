using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SrwRecepturyCzynnosci
{
    public int SrcId { get; set; }

    public int? SrcSreid { get; set; }

    public short? SrcLp { get; set; }

    public short? SrcTwrTyp { get; set; }

    public int? SrcTwrNumer { get; set; }

    public string? SrcTwrNazwa { get; set; }

    public byte? SrcGenerujZadaniaWterminarzu { get; set; }

    public byte? SrcSprzedazKoszt { get; set; }

    public string? SrcOpis { get; set; }

    public int? SrcCzasWykonania { get; set; }

    public byte? SrcCzasWykonaniaJedn { get; set; }

    public decimal? SrcIlosc { get; set; }

    public virtual TwrKarty? SrcTwrNumerNavigation { get; set; }
}
