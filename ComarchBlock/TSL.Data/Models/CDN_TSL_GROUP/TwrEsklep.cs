using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TwrEsklep
{
    public int TwesTwesId { get; set; }

    public int TwesEsklepId { get; set; }

    public int TwesUdostepnij { get; set; }

    public int TwesTwrId { get; set; }

    public short TwesEsklepBezRabatu { get; set; }

    public short TwesEsklepStatus { get; set; }

    public short TwesEsklepDostepnosc { get; set; }

    public byte TwesEsklepKalkulacjaDostaw { get; set; }

    public decimal TwesEsklepKalkulacjaDostawWartosc { get; set; }

    public byte TwesEsklepFlagaNowosc { get; set; }

    public byte TwesEsklepFlagaPromocja { get; set; }

    public byte TwesEsklepFlagaProduktzGazetki { get; set; }

    public byte TwesEsklepFlagaProduktPolecany { get; set; }

    public byte TwesEsklepFlagaWyprzedaz { get; set; }

    public byte TwesEsklepFlagaSuperJakosc { get; set; }

    public byte TwesEsklepFlagaSuperCena { get; set; }

    public byte TwesEsklepFlagaNajlepiejOceniany { get; set; }

    public byte TwesEsklepFlagaRekomendacjaSprzedawcy { get; set; }

    public byte TwesEsklepFlagaNagroda { get; set; }

    public int TwesTwGgidnumer { get; set; }

    public short TwesEsklepZapytajOcene { get; set; }

    public short TwesEsklepNieKontrolujStanow { get; set; }

    public short TwesEsklepDostepnyOd { get; set; }

    public DateTime TwesEsklepDataDostepnosci { get; set; }

    public short TwesSynchroUdostepnij { get; set; }

    public virtual ESklepStanowiska TwesEsklep { get; set; } = null!;

    public virtual Towary TwesTwr { get; set; } = null!;
}
