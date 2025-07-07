using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Mesprofile
{
    public int MespId { get; set; }

    public string? MespNazwa { get; set; }

    public string? MespOpis { get; set; }

    public int? MespAktywny { get; set; }

    public int? MespProfilZrodlowyId { get; set; }

    public string? MespNazwaLogo { get; set; }

    public string? MespNazwaLogoNawigacji { get; set; }

    public string? MespNazwaPlikuTla { get; set; }

    public string? MespKolorTla { get; set; }

    public int? MespOpeWnumer { get; set; }

    public int? MespOpeMnumer { get; set; }

    public int? MespCzasUtworzenia { get; set; }

    public int? MespCzasModyfikacji { get; set; }
}
