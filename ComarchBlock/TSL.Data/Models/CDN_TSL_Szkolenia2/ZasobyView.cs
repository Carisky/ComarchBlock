using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ZasobyView
{
    public int TwZvRpT2id { get; set; }

    public int TwZvTwrId { get; set; }

    public byte TwZvTwrTyp { get; set; }

    public short TwZvProdukt { get; set; }

    public string TwZvKod { get; set; } = null!;

    public string TwZvNumerKat { get; set; } = null!;

    public string TwZvNazwa { get; set; } = null!;

    public string? TwZvGrupa { get; set; }

    public int? TwZvKatId { get; set; }

    public string TwZvKategoria { get; set; } = null!;

    public int? TwZvKatZakId { get; set; }

    public string TwZvOpis { get; set; } = null!;

    public string TwZvJm { get; set; } = null!;

    public string TwZvJmZ { get; set; } = null!;

    public int TwZvTwCnumer { get; set; }

    public int? TwZvMagId { get; set; }

    public DateTime? TwZvData { get; set; }

    public decimal? TwZvIlosc { get; set; }

    public decimal? TwZvBraki { get; set; }

    public decimal? TwZvRezerwacje { get; set; }

    public decimal? TwZvZamowienia { get; set; }

    public decimal? TwZvWartosc { get; set; }

    public decimal? TwZvCena { get; set; }

    public string? TwZvWaluta { get; set; }

    public int? TwZvTwIid { get; set; }
}
