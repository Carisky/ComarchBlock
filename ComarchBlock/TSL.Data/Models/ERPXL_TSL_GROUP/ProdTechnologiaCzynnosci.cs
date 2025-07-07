using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdTechnologiaCzynnosci
{
    public int PtcId { get; set; }

    public int? PtcOjciec { get; set; }

    public int? PtcLp { get; set; }

    public int? PtcTechnologia { get; set; }

    public string? PtcKod { get; set; }

    public string? PtcNazwa { get; set; }

    public string? PtcNrInstrukcji { get; set; }

    public string? PtcOpis { get; set; }

    public int? PtcCzasPrzygotowawczy { get; set; }

    public byte? PtcCzasPrzygotowawczyJedn { get; set; }

    public int? PtcCzasPlanowany { get; set; }

    public byte? PtcCzasPlanowanyJedn { get; set; }

    public int? PtcCzasRozliczeniowy { get; set; }

    public byte? PtcCzasRozliczeniowyJedn { get; set; }

    public int? PtcCzasRozliczeniowyAtr { get; set; }

    public int? PtcCzasPrzygotowawczyRozliczeniowy { get; set; }

    public byte? PtcCzasPrzygotowawczyRozliczeniowyJedn { get; set; }

    public byte? PtcWymagana { get; set; }

    public byte? PtcPlanowana { get; set; }

    public byte? PtcDowolneZasoby { get; set; }

    public short? PtcTwrTyp { get; set; }

    public int? PtcTwrNumer { get; set; }

    public decimal? PtcIlosc { get; set; }

    public int? PtcIloscAtr { get; set; }

    public decimal? PtcIloscMin { get; set; }

    public int? PtcIloscMinAtr { get; set; }

    public decimal? PtcIloscMax { get; set; }

    public int? PtcIloscMaxAtr { get; set; }

    public decimal? PtcIloscPlan { get; set; }

    public decimal? PtcIloscPlanAtr { get; set; }

    public string? PtcJednostka { get; set; }

    public int? PtcOddzial { get; set; }

    public decimal? PtcStawkaStala { get; set; }

    public int? PtcStawkaStalaAtr { get; set; }

    public decimal? PtcStawkaCzas { get; set; }

    public int? PtcStawkaCzasAtr { get; set; }

    public int? PtcStawkaCzasM { get; set; }

    public byte? PtcStawkaCzasMjedn { get; set; }

    public decimal? PtcStawkaIlosc { get; set; }

    public int? PtcStawkailoscAtr { get; set; }

    public decimal? PtcStawkaIloscM { get; set; }

    public int? PtcAkord { get; set; }

    public short? PtcAkordOpis { get; set; }

    public byte? PtcWieleTerminow { get; set; }

    public byte? PtcGenerujZapisWterminarzu { get; set; }

    public byte? PtcKooperacja { get; set; }

    public byte? PtcEtap { get; set; }

    public int? PtcOdstepPo { get; set; }

    public byte? PtcOdstepPoJm { get; set; }

    public int? PtcOdstepPrzed { get; set; }

    public byte? PtcOdstepPrzedJm { get; set; }

    public decimal? PtcNarzuty { get; set; }

    public byte? PtcTyp { get; set; }

    public int? PtcWzorzec { get; set; }

    public int? PtcDefPytId { get; set; }

    public byte? PtcTypOperacjiKtp { get; set; }

    public string? PtcWarunekOperacjiKtp { get; set; }

    public int? PtcGrupaOperacjiKtp { get; set; }

    public byte? PtcRozneOkresy { get; set; }

    public int? PtcPrzesunieciePrzed { get; set; }

    public byte? PtcPrzesunieciePrzedJm { get; set; }

    public int? PtcPrzesunieciePo { get; set; }

    public byte? PtcPrzesunieciePoJm { get; set; }

    public byte? PtcStalyCzas { get; set; }

    public decimal? PtcStalyCzasDla { get; set; }

    public byte? PtcDowolneZasobyProd { get; set; }

    public byte? PtcKontrolaJakosci { get; set; }

    public int? PtcCzasPlanowanyAtr { get; set; }

    public byte? PtcWymagajPodaniaStanuOperacji { get; set; }

    public byte? PtcNiePlanujWpartiachGdyNastOpeWpartiach { get; set; }

    public virtual ICollection<ProdObiektyDoPlanu> ProdObiektyDoPlanus { get; set; } = new List<ProdObiektyDoPlanu>();

    public virtual ICollection<ProdTechnologiaFunkcje> ProdTechnologiaFunkcjes { get; set; } = new List<ProdTechnologiaFunkcje>();

    public virtual ICollection<ProdTechnologiaZasoby> ProdTechnologiaZasobies { get; set; } = new List<ProdTechnologiaZasoby>();

    public virtual ICollection<ProdTechnologieZasobyGniazd> ProdTechnologieZasobyGniazds { get; set; } = new List<ProdTechnologieZasobyGniazd>();

    public virtual ICollection<ProdZabiegiOperacji> ProdZabiegiOperacjis { get; set; } = new List<ProdZabiegiOperacji>();
}
