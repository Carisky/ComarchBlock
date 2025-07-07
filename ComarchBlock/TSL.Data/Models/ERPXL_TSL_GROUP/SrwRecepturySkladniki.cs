using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwRecepturySkladniki
{
    public int SrsId { get; set; }

    public int? SrsSrcId { get; set; }

    public int? SrsSreId { get; set; }

    public short? SrsTwrTyp { get; set; }

    public int? SrsTwrNumer { get; set; }

    public string? SrsTwrNazwa { get; set; }

    public byte? SrsSprzedazKoszt { get; set; }

    public string? SrsOpis { get; set; }

    public decimal? SrsIlosc { get; set; }

    public short? SrsLp { get; set; }

    public int? SrsMagZnumer { get; set; }

    public byte? SrsCzescZamienna { get; set; }

    public virtual TwrKarty? SrsTwrNumerNavigation { get; set; }
}
