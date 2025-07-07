using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdKalendarze
{
    public int PkaId { get; set; }

    public string? PkaKod { get; set; }

    public string? PkaNazwa { get; set; }

    public byte? PkaTyp { get; set; }

    public byte? PkaSystemCzasuPracy { get; set; }

    public byte? PkaWykrywajNiezdefiniowane { get; set; }

    public byte? PkaKontrolaKodeks { get; set; }

    public byte? PkaUwzgWymiarEtatu { get; set; }

    public int? PkaNormaUrlopuWypocz { get; set; }

    public byte? PkaRozliczenieNadgoszin { get; set; }

    public int? PkaWymiarDobowy { get; set; }

    public int? PkaNormaDobowa { get; set; }

    public int? PkaNormaTygodniowa { get; set; }

    public byte? PkaIloscMiesiecy { get; set; }

    public byte? PkaPoczatekWmiesiacu { get; set; }

    public byte? PkaWyplPoM { get; set; }

    public byte? PkaDopDoGodzNocnych { get; set; }

    public byte? PkaDopDoNadgodzin { get; set; }

    public byte? PkaWynagPowNormy { get; set; }
}
