using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdKalkulacjaKosztuElem
{
    public int PksId { get; set; }

    public int? PksPkk { get; set; }

    public string? PksKod { get; set; }

    public string? PksNazwa { get; set; }

    public decimal? PksIlosc { get; set; }

    public decimal? PksKoszt1 { get; set; }

    public decimal? PksCena1 { get; set; }

    public decimal? PksKoszt2 { get; set; }

    public decimal? PksCena2 { get; set; }

    public decimal? PksKosztorys { get; set; }

    public string? PksTermin { get; set; }

    public string? PksCzasTrwania { get; set; }

    public int? PksKolejnosc { get; set; }

    public int? PksKolejnoscMin { get; set; }

    public int? PksObjectId { get; set; }

    public int? PksPtcOjciec { get; set; }

    public short? PksPoziom { get; set; }

    public int? PksLp { get; set; }

    public short? PksTyp { get; set; }

    public byte? PksZmieniono { get; set; }

    public byte? PksKosztPoliczony { get; set; }

    public byte? PksEwidencyjny { get; set; }

    public decimal? PksIloscWgTech { get; set; }

    public int? PksPtzTechnologiaZasob { get; set; }

    public int? PksTerminLong { get; set; }

    public int? PksCzasTrwaniaLong { get; set; }

    public int? PksIdCzynKolejnosciMin { get; set; }

    public int? PksLpSprawdzKolejnosci { get; set; }

    public byte? PksUstawionyNrCzyn { get; set; }

    public byte? PksBylo { get; set; }

    public int? PksPolprodukt { get; set; }

    public byte? PksKosztDodatkowyRodzaj { get; set; }

    public decimal? PksKosztDodatkowyWartoscOrg { get; set; }

    public int? PksZaznaczonyPoprzedniStan { get; set; }

    public int? PksTwrNumer { get; set; }

    public int? PksIdUnikatowy { get; set; }

    public string? PksIdentyfikator { get; set; }

    public int? PksNrKolejnyListy { get; set; }

    public byte? PksPtzkoszt { get; set; }

    public int? PksTwrProdTechnologia { get; set; }

    public int? PksProduktZtechnologiiDomyslnej { get; set; }

    public int? PksTechnologiaPolproduktu { get; set; }

    public int? PksNalezyDoTechDomyslnej { get; set; }

    public int? PksNalezyDoTechPolproduktu { get; set; }

    public int? PksTechnologia { get; set; }

    public int? PksTimeStamp { get; set; }

    public string? PksJednostka { get; set; }

    public decimal? PksIloscPom { get; set; }

    public string? PksJednostkaPom { get; set; }

    public virtual ProdKalkulacjaKosztu? PksPkkNavigation { get; set; }
}
