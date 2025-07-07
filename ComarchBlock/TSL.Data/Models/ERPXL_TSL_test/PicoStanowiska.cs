using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PicoStanowiska
{
    public int PsaId { get; set; }

    public int? PsaPcKid { get; set; }

    public string? PsaKod { get; set; }

    public string? PsaNazwa { get; set; }

    public string? PsaSeria { get; set; }

    public byte? PsaTrybPracy { get; set; }

    public int? PsaUrzadzenieZew { get; set; }

    public string? PsaDrukarka { get; set; }

    public int? PsaSzuflada { get; set; }

    public byte? PsaGenKpKwOtwarcie { get; set; }

    public byte? PsaGenKpKwZamkniecie { get; set; }

    public byte? PsaOtwZamBezStanu { get; set; }

    public byte? PsaAutoZamkniecieDnia { get; set; }

    public byte? PsaBezWyplaty { get; set; }

    public int? PsaCzasZamkniecia { get; set; }

    public byte? PsaDfiskWydruk { get; set; }

    public byte? PsaTylkoDostepneTwr { get; set; }

    public byte? PsaWydrukNaDomyslnejDrukarce { get; set; }

    public int? PsaLastSync { get; set; }

    public byte? PsaSzufladaOtwPlatnosc { get; set; }

    public byte? PsaSzufladaOtwWystawianie { get; set; }

    public byte? PsaSzufladaOtwZliczanie { get; set; }

    public byte? PsaSzufladaOtwZmianaOtw { get; set; }

    public byte? PsaSzufladaOtwZmianaZamk { get; set; }

    public string? PsaGuid { get; set; }

    public byte? PsaTypAplikacji { get; set; }

    public byte? PsaLicencja { get; set; }

    public byte? PsaSzybkaSprzedaz { get; set; }

    public byte? PsaKlawiaturaNumeryczna { get; set; }

    public byte? PsaOtwZamRapKasSesja { get; set; }

    public byte? PsaOtwZamRapKasDzien { get; set; }

    public int? PsaDataDodania { get; set; }

    public virtual ICollection<PicoStanowiskaWydruki> PicoStanowiskaWydrukis { get; set; } = new List<PicoStanowiskaWydruki>();

    public virtual PicoKonfig? PsaPcK { get; set; }
}
