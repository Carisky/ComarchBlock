using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrsWyposazenium
{
    public int SsWId { get; set; }

    public int? SsWParId { get; set; }

    public short? SsWSobTyp { get; set; }

    public int? SsWSobFirma { get; set; }

    public int? SsWSobNumer { get; set; }

    public short? SsWSobLp { get; set; }

    public int? SsWRodzajId { get; set; }

    public short? SsWTwrTyp { get; set; }

    public int? SsWTwrFirma { get; set; }

    public int? SsWTwrNumer { get; set; }

    public short? SsWTwrLp { get; set; }

    public string? SsWKod { get; set; }

    public string? SsWNazwa { get; set; }

    public string? SsWModel { get; set; }

    public string? SsWNrSeryjny { get; set; }

    public string? SsWNumer { get; set; }

    public int? SsWRokProdukcji { get; set; }

    public int? SsWDataInstalacji { get; set; }

    public int? SsWDataGwarancji { get; set; }

    public byte? SsWPrzegladAktywne { get; set; }

    public int? SsWDataOstatniegoPrzegladu { get; set; }

    public int? SsWDataNastepnegoPrzegladu { get; set; }

    public int? SsWDataWaznosciLegalizacji { get; set; }

    public int? SsWCharakterystykaId { get; set; }

    public int? SsWProducentId { get; set; }

    public int? SsWRodzajPaliwaId { get; set; }

    public int? SsWTypLiczydlaId { get; set; }

    public int? SsWRodzajVrsid { get; set; }

    public int? SsWTypUrzadzeniaId { get; set; }

    public string? SsWProcesor { get; set; }

    public string? SsWPamiec { get; set; }

    public string? SsWDysk { get; set; }

    public string? SsWMonitor { get; set; }

    public string? SsWNrModFiskalnego { get; set; }

    public string? SsWNrLicencji { get; set; }

    public string? SsWNrWersji { get; set; }

    public string? SsWDrukarka { get; set; }

    public string? SsWPlytaGlowna { get; set; }

    public string? SsWKartaGraficzna { get; set; }

    public string? SsWKartaModem { get; set; }

    public string? SsWKartaPortow { get; set; }

    public string? SsWKartaUps { get; set; }

    public string? SsWKartaInterfejs { get; set; }

    public string? SsWWersjaOprogramowania { get; set; }

    public string? SsWNrUdt { get; set; }

    public int? SsWDefId { get; set; }

    public string? SsWWartosc1 { get; set; }

    public string? SsWWartosc2 { get; set; }

    public string? SsWWartosc3 { get; set; }

    public string? SsWWartosc4 { get; set; }

    public string? SsWWartosc5 { get; set; }

    public string? SsWWartosc6 { get; set; }

    public string? SsWWartosc7 { get; set; }

    public string? SsWWartosc8 { get; set; }

    public string? SsWWartosc9 { get; set; }

    public string? SsWWartosc10 { get; set; }

    public string? SsWWartosc11 { get; set; }

    public string? SsWWartosc12 { get; set; }

    public string? SsWWartosc13 { get; set; }

    public string? SsWWartosc14 { get; set; }

    public string? SsWWartosc15 { get; set; }

    public string? SsWOpis { get; set; }

    public short? SsWKntTyp { get; set; }

    public int? SsWKntFirma { get; set; }

    public int? SsWKntNumer { get; set; }

    public short? SsWKntLp { get; set; }

    public int? SsWWymId { get; set; }

    public string? SsWCecha { get; set; }

    public int? SsWTstamp { get; set; }

    public short? SsWOpeTyp { get; set; }

    public int? SsWOpeFirma { get; set; }

    public int? SsWOpeNumer { get; set; }

    public short? SsWOpeLp { get; set; }

    public virtual KntKarty? SsWKntNumerNavigation { get; set; }
}
