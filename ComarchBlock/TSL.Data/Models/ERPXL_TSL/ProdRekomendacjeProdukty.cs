using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdRekomendacjeProdukty
{
    public int PrepId { get; set; }

    public int? PrepPreid { get; set; }

    public int? PrepTwrNumer { get; set; }

    public decimal? PrepIloscWgPp { get; set; }

    public decimal? PrepIlosc { get; set; }

    public decimal? PrepIloscZrealizowano { get; set; }

    public int? PrepMagNumer { get; set; }

    public int? PrepTerminRozpoczecia { get; set; }

    public int? PrepTerminZakonczenia { get; set; }

    public byte? PrepTwrTyp { get; set; }

    public virtual ProdRekomendacje? PrepPre { get; set; }

    public virtual TwrKarty? PrepTwrNumerNavigation { get; set; }

    public virtual ICollection<ProdRekomendacjeDokumenty> ProdRekomendacjeDokumenties { get; set; } = new List<ProdRekomendacjeDokumenty>();
}
