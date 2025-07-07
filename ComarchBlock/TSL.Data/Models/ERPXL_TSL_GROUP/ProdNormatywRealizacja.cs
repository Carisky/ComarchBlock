using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdNormatywRealizacja
{
    public int NrzId { get; set; }

    public int? NrzTechnologia { get; set; }

    public int? NrzProdukt { get; set; }

    public short? NrzRok { get; set; }

    public byte? NrzMiesiac { get; set; }

    public string? NrzSeria { get; set; }

    public int? NrzNumer { get; set; }

    public int? NrzFrsId { get; set; }

    public string? NrzOpis { get; set; }

    public string? NrzUrl { get; set; }

    public int? NrzDataWystawienia { get; set; }

    public int? NrzOpWnumer { get; set; }

    public int? NrzDataZatwierdzenia { get; set; }

    public int? NrzOpZnumer { get; set; }

    public int? NrzDataModyfikacji { get; set; }

    public int? NrzOpMnumer { get; set; }

    public int? NrzDataArchiwizacji { get; set; }

    public int? NrzOpAnumer { get; set; }

    public byte? NrzZatwierdzono { get; set; }

    public decimal? NrzZuzycieNaIlosc { get; set; }

    public int? NrzZpOkresOd { get; set; }

    public int? NrzZpOkresDo { get; set; }

    public byte? NrzZakresZp { get; set; }

    public byte? NrzPorownujMinZuzycieMat { get; set; }

    public byte? NrzPorownujSredZuzycieMat { get; set; }

    public byte? NrzPorownujMaxZuzycieMat { get; set; }

    public byte? NrzPorownujMinZuzycieCzas { get; set; }

    public byte? NrzPorownujSredZuzycieCzas { get; set; }

    public byte? NrzPorownujMaxZuzycieCzas { get; set; }

    public int? NrzProgZuzyciaCzas { get; set; }

    public int? NrzProgZuzyciaMat { get; set; }

    public int? NrzKolorProguPonizejMat { get; set; }

    public int? NrzKolorProguRownyMat { get; set; }

    public int? NrzKolorProguPowyzejMat { get; set; }

    public int? NrzKolorProguPonizejCzas { get; set; }

    public int? NrzKolorProguRownyCzas { get; set; }

    public int? NrzKolorProguPowyzejCzas { get; set; }

    public int? NrzFiltrowanyTypProduktu { get; set; }

    public byte? NrzFiltrCzasTylkoRoznice { get; set; }

    public byte? NrzFiltrIloscTylkoRoznice { get; set; }

    public byte? NrzFiltrMaterialyNietechnologiczne { get; set; }

    public byte? NrzFiltrMaterialyNiewykorzystaneNaZp { get; set; }

    public virtual ICollection<ProdNormatywRealizacjaCzynnosci> ProdNormatywRealizacjaCzynnoscis { get; set; } = new List<ProdNormatywRealizacjaCzynnosci>();

    public virtual ICollection<ProdNormatywRealizacjaElem> ProdNormatywRealizacjaElems { get; set; } = new List<ProdNormatywRealizacjaElem>();

    public virtual ICollection<ProdNormatywRealizacjaOperElem> ProdNormatywRealizacjaOperElems { get; set; } = new List<ProdNormatywRealizacjaOperElem>();

    public virtual ICollection<ProdNormatywZlecenium> ProdNormatywZlecenia { get; set; } = new List<ProdNormatywZlecenium>();
}
