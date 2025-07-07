using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class TwrDost
{
    public int TwdId { get; set; }

    public short? TwdTwrTyp { get; set; }

    public int? TwdTwrFirma { get; set; }

    public int? TwdTwrNumer { get; set; }

    public short? TwdTwrLp { get; set; }

    public short? TwdKodTyp { get; set; }

    public int? TwdKodFirma { get; set; }

    public int? TwdKodNumer { get; set; }

    public short? TwdKodLp { get; set; }

    public short? TwdKntTyp { get; set; }

    public int? TwdKntFirma { get; set; }

    public int? TwdKntNumer { get; set; }

    public short? TwdKntLp { get; set; }

    public short? TwdKlasaKnt { get; set; }

    public decimal? TwdCena { get; set; }

    public string? TwdWaluta { get; set; }

    public short? TwdNrKursu { get; set; }

    public int? TwdDataAkt { get; set; }

    public int? TwdCzas { get; set; }

    public string? TwdNotatki { get; set; }

    public short? TwdPozycja { get; set; }

    public string? TwdKodDodatkowyKnt { get; set; }

    public string? TwdNazwaKnt { get; set; }

    public int? TwdOplataSpozZakup { get; set; }

    public decimal? TwdMrpEoq { get; set; }

    public decimal? TwdIloscZam { get; set; }

    public virtual TwrKarty? TwdTwrNumerNavigation { get; set; }

    public virtual ICollection<TwrDostCeny> TwrDostCenies { get; set; } = new List<TwrDostCeny>();
}
