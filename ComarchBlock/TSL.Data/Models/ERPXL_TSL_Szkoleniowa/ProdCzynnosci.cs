using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdCzynnosci
{
    public int PczId { get; set; }

    public int? PczRealizuje { get; set; }

    public int? PczProces { get; set; }

    public int? PczOddzial { get; set; }

    public int? PczTechnologiaCzynnosc { get; set; }

    public string? PczOpis { get; set; }

    public decimal? PczIlosc { get; set; }

    public int? PczTerminRozpoczecia { get; set; }

    public int? PczCzasRealizacji { get; set; }

    public byte? PczCzasRealizacjiJedn { get; set; }

    public int? PczTerminZakonczenia { get; set; }

    public int? PczCzasRozliczeniowy { get; set; }

    public byte? PczCzasRozliczeniowyJedn { get; set; }

    public decimal? PczKoszt { get; set; }

    public decimal? PczKosztProcesu { get; set; }

    public int? PczDataAktywacjiRez { get; set; }

    public int? PczDataWaznosciRez { get; set; }

    public byte? PczPriorytetZlc { get; set; }

    public byte? PczGenerujZapisWterminarzu { get; set; }

    public int? PczOpMnumer { get; set; }

    public int? PczCzasModyfikacji { get; set; }

    public byte? PczEtap { get; set; }

    public byte? PczPlanZgrubnie { get; set; }

    public int? PczWzorcowyCzasRealizacji { get; set; }

    public byte? PczZamrozona { get; set; }

    public byte? PczUruchomiona { get; set; }

    public int? PczPlanowacOd { get; set; }

    public decimal? PczIloscZrealizowana { get; set; }

    public int? PczPzlid { get; set; }

    public string? PczStatus { get; set; }

    public string? PczNrInstrukcji { get; set; }

    public byte? PczKontrolaJakosci { get; set; }

    public int? PczPzepartia { get; set; }

    public int? PczStan { get; set; }

    public int? PczOpUnumer { get; set; }

    public int? PczPolprodPartia { get; set; }

    public virtual ICollection<ProdCzynnosciObiekty> ProdCzynnosciObiekties { get; set; } = new List<ProdCzynnosciObiekty>();

    public virtual ICollection<ProdCzynnosciTerminy> ProdCzynnosciTerminies { get; set; } = new List<ProdCzynnosciTerminy>();

    public virtual ICollection<ProdOperacjePauzy> ProdOperacjePauzies { get; set; } = new List<ProdOperacjePauzy>();

    public virtual ICollection<ProdZasoby> ProdZasobies { get; set; } = new List<ProdZasoby>();

    public virtual ICollection<ProdZleceniaZabiegi> ProdZleceniaZabiegis { get; set; } = new List<ProdZleceniaZabiegi>();
}
