using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class RodzajUpomnieniaParametryProcesow
{
    public int RuppId { get; set; }

    public short? RuppRodzicTyp { get; set; }

    public short? RuppRodzicLp { get; set; }

    public short? RuppSeriaLp { get; set; }

    public decimal? RuppKoszt { get; set; }

    public string? RuppWaluta { get; set; }

    public short? RuppNrKursuKosztu { get; set; }

    public short? RuppNrKursuOdsetek { get; set; }

    public byte? RuppPrzeliczanieOdsetekWgKursu { get; set; }

    public byte? RuppRodzajStawki { get; set; }

    public int? RuppTypOdsetek { get; set; }

    public decimal? RuppStawkaIndywidualna { get; set; }

    public byte? RuppCzyGenerowacPlatnoscUpomnieniaOdOdsetek { get; set; }

    public byte? RuppCzyGenerowacNotyDlaDokCzesciowoRozliczonych { get; set; }

    public byte? RuppCzyNaliczacOdsetkiOdPltRozFakturamiKorygujacymi { get; set; }

    public byte? RuppCzyNaliczacOdsetkiOdTerminowProlongowanych { get; set; }

    public byte? RuppCzyNaliczacOdsetkiOdTerminowMax { get; set; }

    public byte? RuppCzyMinKwotaOdsetek { get; set; }

    public decimal? RuppMinKwotaOdsetek { get; set; }

    public string? RuppWydrukNazwaWezwania { get; set; }

    public byte? RuppCzyKursWalutNaWydruku { get; set; }

    public byte? RuppCzyOdsetkiWkwocieDoZaplatyNaWydruku { get; set; }

    public string? RuppWydrukTrescNaglowka { get; set; }

    public string? RuppWydrukTrescStopki { get; set; }

    public byte? RuppFormatWydruku { get; set; }

    public string? RuppEmailTemat { get; set; }

    public string? RuppEmailTresc { get; set; }

    public string? RuppEmailPodpis { get; set; }

    public byte? RuppCzyObslugaProcesow { get; set; }
}
