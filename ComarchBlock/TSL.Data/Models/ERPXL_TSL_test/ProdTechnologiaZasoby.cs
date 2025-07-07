using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdTechnologiaZasoby
{
    public int PtzId { get; set; }

    public int? PtzTechnologiaCzynnosc { get; set; }

    public int? PtzZamiennik { get; set; }

    public string? PtzKod { get; set; }

    public string? PtzNazwa { get; set; }

    public int? PtzTechnologiaZasob { get; set; }

    public byte? PtzZrodloZasobu { get; set; }

    public short? PtzTwrTyp { get; set; }

    public int? PtzTwrNumer { get; set; }

    public decimal? PtzIlosc { get; set; }

    public int? PtzIloscAtr { get; set; }

    public decimal? PtzIloscMin { get; set; }

    public int? PtzIloscMinAtr { get; set; }

    public decimal? PtzIloscMax { get; set; }

    public int? PtzIloscMaxAtr { get; set; }

    public string? PtzJednostka { get; set; }

    public short? PtzPropIlosc { get; set; }

    public decimal? PtzIloscPom { get; set; }

    public int? PtzIloscPomAtr { get; set; }

    public decimal? PtzIloscPomMin { get; set; }

    public int? PtzIloscPomMinAtr { get; set; }

    public decimal? PtzIloscPomMax { get; set; }

    public int? PtzIloscPomMaxAtr { get; set; }

    public string? PtzJednostkaPom { get; set; }

    public short? PtzPropIloscPom { get; set; }

    public byte? PtzTypZasobu { get; set; }

    public int? PtzMagNumer { get; set; }

    public byte? PtzKoszt { get; set; }

    public decimal? PtzCena { get; set; }

    public int? PtzCenaAtr { get; set; }

    public int? PtzKlasaCechy { get; set; }

    public string? PtzCecha { get; set; }

    public short? PtzEdycjaCechy { get; set; }

    public decimal? PtzWagaKosztu { get; set; }

    public byte? PtzWagaIlosc { get; set; }

    public byte? PtzIloscFormat { get; set; }

    public int? PtzLp { get; set; }

    public decimal? PtzDopasowanieIlosci { get; set; }

    public byte? PtzPlanowanyCalosciowo { get; set; }

    public short? PtzKopTyp { get; set; }

    public int? PtzKopNumer { get; set; }

    public byte? PtzFakturowac { get; set; }

    public decimal? PtzCenaKosztorysu { get; set; }

    public int? PtzCenaKosztorysuAtr { get; set; }

    public byte? PtzIloscDomyslna { get; set; }

    public byte? PtzIloscTechnologiczna { get; set; }

    public byte? PtzTyp { get; set; }

    public byte? PtzWymagajSurowca { get; set; }

    public int? PtzDefPytWyborId { get; set; }

    public int? PtzDefPytCechaId { get; set; }

    public byte? PtzPlanujStrategicznie { get; set; }

    public byte? PtzUsuwajNiewykorzystane { get; set; }

    public int? PtzRodzajUbocznego { get; set; }

    public byte? PtzPlanujUboczne { get; set; }

    public byte? PtzEdycjaMagazynuPrzyRealizacji { get; set; }

    public byte? PtzPodstawowaTechnologiaDlaProduktu { get; set; }

    public int? PtzCzasTrwaniaProdukcji { get; set; }

    public byte? PtzCzasTrwaniaProdukcjiJedn { get; set; }

    public byte? PtzPrzeliczajWgIlosciProduktu { get; set; }

    public byte? PtzCzasTrwaniaWyliczony { get; set; }

    public byte? PtzPodlegaKj { get; set; }

    public byte? PtzRodzajKj { get; set; }

    public int? PtzIdProduktNiezgodny { get; set; }

    public int? PtzIdMagazynNiezgodny { get; set; }

    public byte? PtzCzyUbocznyNiezgodny { get; set; }

    public string? PtzOpisKj { get; set; }

    public byte? PtzNiezaleznaOdJedPod { get; set; }

    public byte? PtzPrzeliczajWgPomocniczej { get; set; }

    public byte? PtzPrzeliczajIloscPomWgPodst { get; set; }

    public byte? PtzUwzglednijWnrSeryjnym { get; set; }

    public int? PtzIdWzorcaNrPartii { get; set; }

    public byte? PtzMaterialKanban { get; set; }

    public virtual ICollection<ProdTechnologiaZasobyTwX> ProdTechnologiaZasobyTwXes { get; set; } = new List<ProdTechnologiaZasobyTwX>();

    public virtual ProdTechnologiaCzynnosci? PtzTechnologiaCzynnoscNavigation { get; set; }
}
