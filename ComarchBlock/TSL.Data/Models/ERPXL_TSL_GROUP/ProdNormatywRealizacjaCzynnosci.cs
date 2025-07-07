using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdNormatywRealizacjaCzynnosci
{
    public int NrcId { get; set; }

    public int? NrcNormatywId { get; set; }

    public int? NrcQId { get; set; }

    public int? NrcPtcOjciec { get; set; }

    public string? NrcKod { get; set; }

    public string? NrcNazwa { get; set; }

    public int? NrcLp { get; set; }

    public int? NrcPoziom { get; set; }

    public int? NrcTyp { get; set; }

    public decimal? NrcIlosc { get; set; }

    public string? NrcJednostka { get; set; }

    public byte? NrcFiltr { get; set; }

    public string? NrcKodKop { get; set; }

    public int? NrcZamiennik { get; set; }

    public byte? NrcPodrzedne { get; set; }

    public int? NrcPolprodukt { get; set; }

    public byte? NrcTypOperacjiKtp { get; set; }

    public byte? NrcTypMaterialuKtp { get; set; }

    public string? NrcZamiennikKod { get; set; }

    public decimal? NrcZamiennikIlosc { get; set; }

    public string? NrcZamiennikJm { get; set; }

    public string? NrcNrInstrukcji { get; set; }

    public int? NrcKolor { get; set; }

    public int? NrcKolejnosc { get; set; }

    public decimal? NrcIloscPom { get; set; }

    public string? NrcJmPom { get; set; }

    public int? NrcTimeStamp { get; set; }

    public virtual ProdNormatywRealizacja? NrcNormatyw { get; set; }
}
