using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdZasoby
{
    public int PzaId { get; set; }

    public int? PzaCzynnosc { get; set; }

    public int? PzaTechnologiaZasob { get; set; }

    public decimal? PzaIlosc { get; set; }

    public decimal? PzaIloscPom { get; set; }

    public decimal? PzaKoszt { get; set; }

    public byte? PzaTypKosztu { get; set; }

    public byte? PzaKosztUstalony { get; set; }

    public decimal? PzaKosztSurowca { get; set; }

    public int? PzaTermin { get; set; }

    public int? PzaMagNumer { get; set; }

    public string? PzaNumerSeryjny { get; set; }

    public string? PzaCecha { get; set; }

    public int? PzaKlasaCechy { get; set; }

    public byte? PzaTypZasobu { get; set; }

    public short? PzaTwrTyp { get; set; }

    public int? PzaTwrNumer { get; set; }

    public int? PzaZasob { get; set; }

    public short? PzaKopTyp { get; set; }

    public int? PzaKopNumer { get; set; }

    public decimal? PzaWagaKosztu { get; set; }

    public byte? PzaWagaIlosc { get; set; }

    public decimal? PzaCena { get; set; }

    public decimal? PzaIloscTechnologiczna { get; set; }

    public byte? PzaPlanowany { get; set; }

    public int? PzaRodzajUbocznego { get; set; }

    public int? PzaKodNiezgodnosci { get; set; }

    public string? PzaOpis { get; set; }

    public int? PzaPzlid { get; set; }

    public byte? PzaPrzeliczajWgPomocniczej { get; set; }

    public string? PzaJednostkaPom { get; set; }

    public byte? PzaPodlegaKj { get; set; }

    public int? PzaPkjnid { get; set; }

    public int? PzaIdWzorcaNrPartii { get; set; }

    public virtual ICollection<ProdPkjza> ProdPkjzas { get; set; } = new List<ProdPkjza>();

    public virtual ProdCzynnosci? PzaCzynnoscNavigation { get; set; }
}
