using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdTechnologium
{
    public int PteId { get; set; }

    public string? PteKod { get; set; }

    public string? PteNazwa { get; set; }

    public int? PteWersja { get; set; }

    public string? PteOpisWersji { get; set; }

    public int? PteProjekt { get; set; }

    public short? PteTwrTyp { get; set; }

    public int? PteTwrNumer { get; set; }

    public short? PteKntTyp { get; set; }

    public int? PteKntNumer { get; set; }

    public short? PteKnDtyp { get; set; }

    public int? PteKnDnumer { get; set; }

    public int? PteDataOd { get; set; }

    public int? PteDataDo { get; set; }

    public int? PteDataZatw { get; set; }

    public int? PteCzasModyfikacji { get; set; }

    public short? PteZatwTyp { get; set; }

    public int? PteZatwNumer { get; set; }

    public int? PteOpwnumer { get; set; }

    public int? PteOpmnumer { get; set; }

    public byte? PteArchiwalny { get; set; }

    public int? PteOpanumer { get; set; }

    public int? PteDataArchiw { get; set; }

    public decimal? PteIlosc { get; set; }

    public decimal? PteIloscMin { get; set; }

    public decimal? PteIloscProd { get; set; }

    public decimal? PteIloscPlan { get; set; }

    public string? PteJednostka { get; set; }

    public int? PteOddzial { get; set; }

    public string? PteOpis { get; set; }

    public short? PteRok { get; set; }

    public byte? PteMiesiac { get; set; }

    public string? PteSeria { get; set; }

    public int? PteNumer { get; set; }

    public decimal? PteStawkaStala { get; set; }

    public int? PteStawkaStalaAtr { get; set; }

    public decimal? PteStawkaIlosc { get; set; }

    public int? PteStawkaIloscAtr { get; set; }

    public decimal? PteStawkaIloscM { get; set; }

    public decimal? PteStawkaCzas { get; set; }

    public int? PteStawkaCzasAtr { get; set; }

    public int? PteStawkaCzasM { get; set; }

    public byte? PteStawkaCzasMjedn { get; set; }

    public int? PteFrsId { get; set; }

    public byte? PteGenerujZapisWterminarzu { get; set; }

    public int? PtePrjId { get; set; }

    public short? PteZrdTyp { get; set; }

    public int? PteZrdNumer { get; set; }

    public decimal? PteCenaKosztorysu { get; set; }

    public byte? PteCzynnoscZeZlecenia { get; set; }

    public int? PteFrmNumer { get; set; }

    public short? PteTyp { get; set; }

    public byte? PteKopiowacZalacznikiNaZp { get; set; }

    public int? PteAktywny { get; set; }

    public byte? PtePolaczOperacjeTpZpolprod { get; set; }

    public byte? PteWymagajPodaniaStanuOperacji { get; set; }

    public virtual ICollection<ProdKalkulacjaKosztu> ProdKalkulacjaKosztus { get; set; } = new List<ProdKalkulacjaKosztu>();

    public virtual ICollection<ProdTechnologiaTerminy> ProdTechnologiaTerminies { get; set; } = new List<ProdTechnologiaTerminy>();

    public virtual ICollection<ProdTechnologieDomyslne> ProdTechnologieDomyslnes { get; set; } = new List<ProdTechnologieDomyslne>();
}
