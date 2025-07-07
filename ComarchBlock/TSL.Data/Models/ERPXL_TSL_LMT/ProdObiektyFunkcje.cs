using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdObiektyFunkcje
{
    public int PofId { get; set; }

    public int? PofLp { get; set; }

    public int? PofObiekt { get; set; }

    public short? PofObiTyp { get; set; }

    public int? PofFunkcja { get; set; }

    public int? PofGrupa { get; set; }

    public int? PofOddzial { get; set; }

    public decimal? PofMinIlosc { get; set; }

    public decimal? PofMaxIlosc { get; set; }

    public string? PofJednostka { get; set; }

    public decimal? PofWydajnoscIlosc { get; set; }

    public int? PofWydajnoscCzas { get; set; }

    public byte? PofWydajnoscCzasJedn { get; set; }

    public int? PofCzas { get; set; }

    public byte? PofCzasJedn { get; set; }

    public byte? PofCzyStawki { get; set; }

    public decimal? PofStawkaStala { get; set; }

    public int? PofStawkaStalaAtr { get; set; }

    public decimal? PofStawkaCzas { get; set; }

    public int? PofStawkaCzasAtr { get; set; }

    public int? PofStawkaCzasM { get; set; }

    public byte? PofStawkaCzasMjedn { get; set; }

    public decimal? PofStawkaIlosc { get; set; }

    public int? PofStawkaIloscAtr { get; set; }

    public decimal? PofStawkaIloscM { get; set; }

    public int? PofCzasPrzygotowania { get; set; }

    public byte? PofCzasPrzygotowaniaJedn { get; set; }

    public decimal? PofStawkaPrzygotowania { get; set; }

    public int? PofStawkaPrzygotowaniaAtr { get; set; }

    public int? PofCzasZakonczenia { get; set; }

    public byte? PofCzasZakonczeniaJedn { get; set; }

    public decimal? PofStawkaZakonczenia { get; set; }

    public int? PofStawkaZakonczeniaAtr { get; set; }

    public byte? PofDomyslneDlaZasobu { get; set; }

    public byte? PofWidocznosc { get; set; }
}
