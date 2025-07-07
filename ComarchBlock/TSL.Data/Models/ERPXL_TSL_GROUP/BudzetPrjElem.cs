using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class BudzetPrjElem
{
    public int BpeId { get; set; }

    public string? BpeKod { get; set; }

    public string? BpeNazwa { get; set; }

    public int? BpeNadrzedny { get; set; }

    public int? BpeLp { get; set; }

    public int? BpeBpnid { get; set; }

    public int? BpePrjId { get; set; }

    public string? BpeOpis { get; set; }

    public string? BpeUrl { get; set; }

    public int? BpeDataM { get; set; }

    public int? BpeDataW { get; set; }

    public int? BpeOpeMnumer { get; set; }

    public int? BpeOpeWnumer { get; set; }

    public short? BpeKntTyp { get; set; }

    public int? BpeKntNumer { get; set; }

    public int? BpeUmNid { get; set; }

    public byte? BpePokazZpodrzednych { get; set; }

    public byte? BpeOfertowac { get; set; }

    public byte? BpeFakturowac { get; set; }

    public byte? BpeRodzajSkladnika { get; set; }

    public string? BpeRodzajSkladnikaInny { get; set; }

    public int? BpeTwrTyp { get; set; }

    public int? BpeTwrNumer { get; set; }

    public int? BpeFunkcja { get; set; }

    public byte? BpeTwrUmw { get; set; }

    public int? BpeTwrUmwPozycja { get; set; }

    public string? BpeSkladnikJm { get; set; }

    public decimal? BpeIlosc { get; set; }

    public int? BpeIloscCzas { get; set; }

    public byte? BpeIloscCzasJm { get; set; }

    public decimal? BpeStawka { get; set; }

    public decimal? BpeStawkaWaluta { get; set; }

    public int? BpeStawkaCzas { get; set; }

    public byte? BpeStawkaCzasJm { get; set; }

    public decimal? BpeWartoscPrzedNarzutem { get; set; }

    public decimal? BpeNarzut { get; set; }

    public decimal? BpeWartoscPoNarzucie { get; set; }

    public decimal? BpeUmowaProcent { get; set; }

    public decimal? BpeWartoscUmowy { get; set; }

    public decimal? BpeWartoscUmowyPoProc { get; set; }

    public decimal? BpeWartoscBudzetu { get; set; }

    public decimal? BpeWartoscKontraktu { get; set; }

    public decimal? BpePrzychodyInne { get; set; }

    public decimal? BpePrzychodyPlan { get; set; }

    public decimal? BpeKosztyInne { get; set; }

    public decimal? BpeKosztyWyrazen { get; set; }

    public decimal? BpeRealizacjaPracProc { get; set; }

    public decimal? BpeRealizacjaPracProcBiez { get; set; }

    public int? BpeDataRozpoczecia { get; set; }

    public int? BpeDataZakonczenia { get; set; }

    public int? BpeCzasTrwania { get; set; }

    public byte? BpeCzasTrwaniaJedn { get; set; }

    public int? BpeOpeOdpowiedzialny { get; set; }

    public byte? BpeRodzajPracy { get; set; }

    public byte? BpeWyjety { get; set; }

    public int? BpeRezygnacjaId { get; set; }

    public string? BpeKosztSql { get; set; }

    public byte? BpeDzialanieBudzet { get; set; }

    public byte? BpeDzialanieKontrakt { get; set; }

    public decimal? BpeRabat { get; set; }

    public decimal? BpeStawkaPoRabacie { get; set; }

    public decimal? BpeWartoscPoRabacie { get; set; }

    public short? BpeKntTypSpr { get; set; }

    public int? BpeKntNumerSpr { get; set; }

    public int? BpeUmNidSpr { get; set; }

    public decimal? BpeUmowaProcentSpr { get; set; }

    public decimal? BpeWartoscUmowySpr { get; set; }

    public decimal? BpeWartoscUmowyPoProcSpr { get; set; }

    public byte? BpeRodzajNarzutu { get; set; }

    public decimal? BpePrzychodyPlanowaneSpr { get; set; }

    public decimal? BpePrzychodyPlanowaneEdycjaSpr { get; set; }

    public string? BpeWyrazenie { get; set; }

    public string? BpeWaluta { get; set; }

    public decimal? BpeKursM { get; set; }

    public decimal? BpeKursL { get; set; }

    public int? BpeTwrTypSpr { get; set; }

    public int? BpeTwrNumerSpr { get; set; }

    public virtual BudzetPrjNag? BpeBpn { get; set; }

    public virtual ICollection<BudzetPrjElemDzialanium> BudzetPrjElemDzialania { get; set; } = new List<BudzetPrjElemDzialanium>();

    public virtual ICollection<BudzetPrjElemOkresy> BudzetPrjElemOkresies { get; set; } = new List<BudzetPrjElemOkresy>();

    public virtual ICollection<BudzetPrjElemDzialanium> BpepBpeds { get; set; } = new List<BudzetPrjElemDzialanium>();
}
