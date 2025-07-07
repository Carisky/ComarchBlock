using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PlaceElementyWyplat
{
    public int PewId { get; set; }

    public int? PewGidnumer { get; set; }

    public int? PewDataOd { get; set; }

    public int? PewDataDo { get; set; }

    public int? PewPredefiniowany { get; set; }

    public byte? PewArchiwalny { get; set; }

    public int? PewPegid { get; set; }

    public int? PewKolejnosc { get; set; }

    public string? PewNazwa { get; set; }

    public string? PewSkrot { get; set; }

    public int? PewLpltyp { get; set; }

    public byte? PewOkresWyplaty { get; set; }

    public byte? PewPorownajDoMinimalnego { get; set; }

    public byte? PewDodajJesliZero { get; set; }

    public byte? PewKosztPracodawcy { get; set; }

    public byte? PewDoWyplaty { get; set; }

    public byte? PewGotowka { get; set; }

    public int? PewPozycjaPitfirmy { get; set; }

    public int? PewPozycjaPitpracownika { get; set; }

    public int? PewPozycjaZus { get; set; }

    public int? PewPozycjaRp7 { get; set; }

    public int? PewPswid { get; set; }

    public byte? PewSkladkaSpoleczna { get; set; }

    public byte? PewSkladkaZdrowotna { get; set; }

    public byte? PewKosztyPrzychodu { get; set; }

    public short? PewKosztyWartosc { get; set; }

    public byte? PewPodatek { get; set; }

    public short? PewPodatekWartosc { get; set; }

    public byte? PewUlga { get; set; }

    public int? PewWynagrodzeniaGus { get; set; }

    public byte? PewPfron { get; set; }

    public byte? PewNieobecnosc { get; set; }

    public byte? PewNbUspPlatna { get; set; }

    public byte? PewNbUspNieplatna { get; set; }

    public byte? PewNbNieusp { get; set; }

    public byte? PewZwolnienieZus { get; set; }

    public byte? PewProporcjonalnosc { get; set; }

    public byte? PewOdchylek { get; set; }

    public byte? PewZasilekChorobowy { get; set; }

    public byte? PewUrlopWypoczynkowy { get; set; }

    public byte? PewUrlopWypoczynkowyTyp { get; set; }

    public byte? PewUrlopWypoczynkowySt { get; set; }

    public byte? PewEkwiwalentUrlopu { get; set; }

    public byte? PewEkwiwalentUrlopuTyp { get; set; }

    public byte? PewEkwiwalentUrlopuSt { get; set; }

    public byte? PewNadgodziny { get; set; }

    public byte? PewZaokraglenie { get; set; }

    public byte? PewZaokraglenieSposob { get; set; }

    public byte? PewTyp { get; set; }

    public decimal? PewKwota { get; set; }

    public byte? PewAlgorytm { get; set; }

    public byte? PewPomijajZasadnicze { get; set; }

    public byte? PewWspUrlop { get; set; }

    public decimal? PewWspUrlopWartosc { get; set; }

    public int? PewWskaznik { get; set; }

    public byte? PewWskTyp { get; set; }

    public byte? PewWyliczacPrace { get; set; }

    public byte? PewStazPierwszyDzien { get; set; }

    public byte? PewWspTyp { get; set; }

    public string? PewWspNazwa { get; set; }

    public int? PewWspProcent { get; set; }

    public int? PewWspUlamekL { get; set; }

    public int? PewWspUlamekM { get; set; }

    public int? PewWspLiczba { get; set; }

    public string? PewWzor { get; set; }

    public int? PewOpeNumerW { get; set; }

    public int? PewDataWprowadzenia { get; set; }

    public int? PewOpeNumerM { get; set; }

    public int? PewDataModyfikacji { get; set; }

    public virtual ICollection<PlaceElementyProgi> PlaceElementyProgis { get; set; } = new List<PlaceElementyProgi>();
}
