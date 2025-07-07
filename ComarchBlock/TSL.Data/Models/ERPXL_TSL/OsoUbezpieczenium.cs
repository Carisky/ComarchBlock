using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class OsoUbezpieczenium
{
    public int OubId { get; set; }

    public int? OubGidnumer { get; set; }

    public int? OubDataOd { get; set; }

    public int? OubDataDo { get; set; }

    public int? OubOsoNumer { get; set; }

    public int? OubPrawoDoEmerRenty { get; set; }

    public int? OubEmeryturaOd { get; set; }

    public int? OubRentaOd { get; set; }

    public int? OubRentaDo { get; set; }

    public int? OubKodNiepelnosprawnosci { get; set; }

    public string? OubKodPrWszczegolWarunkach { get; set; }

    public int? OubOkresOd { get; set; }

    public int? OubOkresDo { get; set; }

    public int? OubOddzialNfz { get; set; }

    public string? OubZbiegiTytUbezp { get; set; }

    public int? OubZabiegiTytUbezpOd { get; set; }

    public int? OubZabiegiTytUbezpDo { get; set; }

    public byte? OubSpoleczne { get; set; }

    public byte? OubZdrowotne { get; set; }

    public int? OubKodWyksztalcenia { get; set; }

    public byte? OubMiejsceZamieszkania { get; set; }

    public int? OubDataWiekuEmeryt { get; set; }

    public int? OubTytulUbezpieczenia { get; set; }

    public string? OubKodUbezpieczeniaCz1 { get; set; }

    public string? OubKodUbezpieczeniaCz2 { get; set; }

    public string? OubKodUbezpieczeniaCz3 { get; set; }

    public int? OubDataObowUbezpSpol { get; set; }

    public byte? OubPodObowUbezpieczeniu { get; set; }

    public int? OubDataObowUbezpZdr { get; set; }

    public byte? OubSklZdrOgr { get; set; }

    public byte? OubNieNaliczacFp { get; set; }

    public byte? OubNieNaliczacFgsp { get; set; }

    public byte? OubDobrowolneUbezp { get; set; }

    public int? OubDobUbezpEmDataOd { get; set; }

    public int? OubDobUbezpRentDataOd { get; set; }

    public int? OubDobUbezpChorDataOd { get; set; }

    public int? OubDataZglDoDobUbezp { get; set; }

    public decimal? OubKwotaPierwszejSkl { get; set; }

    public byte? OubWyrejestrowanieZm { get; set; }

    public int? OubTytulUbezpieczenia1 { get; set; }

    public string? OubKodUbezpieczenia1Cz1 { get; set; }

    public string? OubKodUbezpieczenia1Cz2 { get; set; }

    public string? OubKodUbezpieczenia1Cz3 { get; set; }

    public int? OubKodPrzyWyrejestrowania { get; set; }

    public int? OubDataOdPrzyWyrejestrowania { get; set; }

    public int? OubUmowa { get; set; }

    public byte? OubRownoczesnaUmowaOprc { get; set; }

    public int? OubOpeWnumer { get; set; }

    public int? OubCzasWprowadzenia { get; set; }

    public int? OubOpeMnumer { get; set; }

    public int? OubCzasModyfikacji { get; set; }

    public byte? OubZmianaDanychDz { get; set; }

    public int? OubFep { get; set; }

    public int? OubFepokresOd { get; set; }

    public int? OubFepokresDo { get; set; }

    public virtual PrcKarty? OubOsoNumerNavigation { get; set; }
}
